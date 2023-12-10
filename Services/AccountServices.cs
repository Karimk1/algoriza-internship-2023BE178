using Core.Helper;
using Core.Models;
using Core.Models.enums;
using Core.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountServices : IAccountServices
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<User> _userManager;
        private readonly JWT _jwt;


        public AccountServices(UserManager<User> userManager, SignInManager<User> signInManager, IOptions<JWT> jwt, IHostingEnvironment hostingEnvironment)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _jwt = jwt.Value;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<AuthModel> Register(PationtRegisterModel model)
        {
            if (await _userManager.FindByEmailAsync(model.email) is not null)
                return new AuthModel { Massage = "Email is already registered" };
            if (await _userManager.FindByNameAsync(model.firstname + " " + model.lastname) is not null)
                return new AuthModel { Massage = "UserName is already registered" };
            String uniqeFileName = null;
            if (model.image !=  null)
            {
                //byte[] imageBytes = Convert.FromBase64String(model.image.FileName);
                string uploadsFolder =  Path.Combine(_hostingEnvironment.WebRootPath, "images");
                uniqeFileName = Guid.NewGuid().ToString() + "_" + model.image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqeFileName);
                model.image.CopyTo(new FileStream(filePath , FileMode.Create));
            }
            var user = new User
            {
                image = uniqeFileName,
                UserName = model.firstname,
                Email = model.email,
                gender = model.gender,
                dateOfBirth = model.dateOfBirth,
                PhoneNumber = model.phone,
                role = Role.Patient,
            };
            var result = await _userManager.CreateAsync(user, password: model.password);
            if (!result.Succeeded)
            {
                var errors = String.Empty;
                foreach (var error in result.Errors)
                {
                    errors += $"{error.Description} , ";
                }
                return new AuthModel { Massage = errors };
            }
            await _userManager.AddToRoleAsync(user, "Patient");

            var jwtSecurityToken = await CreateJwtToken(user);

            return new AuthModel
            {
                Email = user.Email,
                Username = user.UserName,
                ExpiresOn = jwtSecurityToken.ValidTo,
                IsAuthenticated = true,
                Roles = new List<string> { "Patient" },
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken)
            };
        }

        public async Task<AuthModel> Login(LogInModel model)
        {
            var authModel = new AuthModel { };
            var user = await _userManager.FindByEmailAsync(model.email);
            if (user is null || !await _userManager.CheckPasswordAsync(user, model.password) ) 
            {
                authModel.Massage = "Email or Password is invalid";
                return authModel;
            }
            var jwtSecurityToken = await CreateJwtToken(user);
            var roleList = await _userManager.GetRolesAsync(user);

            authModel.Email = user.Email;
            authModel.Username = user.UserName;
            authModel.IsAuthenticated = true;
            authModel.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            authModel.ExpiresOn = jwtSecurityToken.ValidTo;
            authModel.Roles = roleList.ToList();

            return authModel;
        }

        private async Task<JwtSecurityToken> CreateJwtToken(User user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = new List<Claim>
            {
                new Claim("roles", roles[0])
            };


            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id),
            }.Union(userClaims).Union(roleClaims);

            var symmetricSecurityKey =  new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.Now.AddDays(_jwt.DurationInDays),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }
    }
}
