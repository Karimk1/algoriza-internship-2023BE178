using Core.Helper;
using Core.Models;
using Core.Models.enums;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Veseeta.Controllers
{
    [Authorize(Roles = "Doctor")]

    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorServices _doctorServices;

        public DoctorController(IDoctorServices doctorServices)
        {
            _doctorServices = doctorServices;
        }
        [HttpGet("getallbooking/{skip}/{take}")]
        public async Task<IActionResult> getallbooking(int skip , int take)
        {
            var bearerToken = Request.Headers["Authorization"].ToString();
            var jti = TokenExtractor.Extractor(bearerToken);
            var v = await _doctorServices.GetAllBookings(jti, skip,take);
            return Ok(v);
        }
        [HttpPut("confirmCheckUp/{RequestId}/{requesttype}")]
        public async Task<IActionResult> confirmCheckUp(int RequestId, RequestType requesttype)
        {
            var bearerToken = Request.Headers["Authorization"].ToString();
            var jti = TokenExtractor.Extractor(bearerToken);
            var v = await _doctorServices.ConfirmCheckUp(jti,RequestId, requesttype);
            return Ok(v);
        }
        
        [HttpPost("AddAppointment")]
        public async Task<IActionResult> AddAppointment(List<DayTime> dayTimes)
        {
            var bearerToken = Request.Headers["Authorization"].ToString();
            var jti = TokenExtractor.Extractor(bearerToken);
            var v = await _doctorServices.AddAppointment(jti, dayTimes);
            if( v != false)
            {
                return Ok(v);
            }
            return BadRequest(v);
        }
        
        [HttpPut("updateAppointment/{oldTime}/{newTime}")]
        public async Task<IActionResult> updateAppointment(Double oldTime , Double newTime)
        {
            var bearerToken = Request.Headers["Authorization"].ToString();
            var jti = TokenExtractor.Extractor(bearerToken);
            var v = await _doctorServices.UpdateAppointment(jti, oldTime,newTime);
            if( v != false)
            {
                return Ok(v);
            }
            return BadRequest(v);
        }
        
        [HttpDelete("deleteAppointment/{time}")]
        
        public async Task<IActionResult> deleteAppointment(Double time)
        {
            var bearerToken = Request.Headers["Authorization"].ToString();
            var jti = TokenExtractor.Extractor(bearerToken);
            var v = await _doctorServices.DeleteAppointment(jti,time);
            if( v != false)
            {
                return Ok(v);
            }
            return BadRequest(v);
        }



    }
}
