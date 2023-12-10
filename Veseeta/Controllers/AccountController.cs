using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Veseeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServices _accountServices;

        public AccountController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }

        [HttpPost("PatientRegister")]
        public async Task<IActionResult> Register([FromForm]PationtRegisterModel model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _accountServices.Register(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Massage);
            return Ok(result);
        }
        
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LogInModel model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _accountServices.Login(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Massage);
            return Ok(result);
        }
    }
}
