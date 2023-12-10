using Core.Helper;
using Core.Models;
using Core.Models.enums;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Veseeta.Controllers
{
    [Authorize(Roles = "Patient")]
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientServices _patientServices;

        public PatientController(IPatientServices patientServices)
        {
            _patientServices = patientServices;
        }
        //[HttpPost("Regester")]
        //public async Task<IActionResult> Regester(PationtRegisterModel pationtRegisterModel)
        //{
            
        //        var user = new User
        //        {
        //            image = pationtRegisterModel.image,
        //            UserName = pationtRegisterModel.firstname + " " + pationtRegisterModel.lastname,
        //            Email = pationtRegisterModel.email,
        //            gender = pationtRegisterModel.gender,
        //            dateOfBirth = pationtRegisterModel.dateOfBirth,
        //            PhoneNumber = pationtRegisterModel.phone,
        //            role = Role.Patient,
        //        };
        //        var result = await _userManager.CreateAsync(user, password: pationtRegisterModel.password);

        //        if (result.Succeeded)
        //        {
        //            return Ok(result);
        //        }
        //        foreach(var item in result.Errors)
        //        {
        //            ModelState.AddModelError("", item.Description);
        //        }
            

        //    return BadRequest();
        //}
        //[HttpPost("Login")]
        //public async Task<IActionResult> Login(LogInModel loginModel)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(loginModel.Email,password: loginModel.password,false,false);
        //        if (result.Succeeded)
        //        {
        //            return Ok(result);
        //        }
        //        ModelState.AddModelError(String.Empty, "Invalid Login");
        //    }
        //    return BadRequest();
        //}

        [HttpGet("GetAllDoctors")]
        public async Task<IActionResult> GetAllDoctors()
        {
                var p = await _patientServices.GetAllDoctors();
                return Ok(p);
            
        }

        [HttpPost("Booking/{timeId}")]
        public async Task<IActionResult> Booking(int timeId, String? code = null)
        {
            var bearerToken = Request.Headers["Authorization"].ToString();
            var jti = TokenExtractor.Extractor(bearerToken);
            var book = await _patientServices.Book(jti, timeId, code);
            return Ok(book);
        }

        [HttpGet("getAllBooking/")]
        public async Task<IActionResult> GetAllBooking()
        {
            var bearerToken = Request.Headers["Authorization"].ToString();
            var jti = TokenExtractor.Extractor(bearerToken);
            var booking = await _patientServices.GetPationtBooking(jti);
            if(booking != Empty)
            {
                return Ok(booking);
            }
            return BadRequest("you have no booking");
        }
        
        [HttpPut("CancelBooking/{id}")]
        public async Task<IActionResult> CancelBooking(int id)
        {
            var bearerToken = Request.Headers["Authorization"].ToString();
            var jti = TokenExtractor.Extractor(bearerToken);
            var booking = await _patientServices.CancelBooking(id);
            if(booking != false)
            {
                return Ok(booking);
            }
            return BadRequest(booking);
        }
    }
}
