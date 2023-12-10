using Core.Helper;
using Core.Models;
using Core.Repository;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Veseeta.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    
    public class AdminController : ControllerBase
    {
        private readonly IAdminServices _adminServices;

        public AdminController(IAdminServices adminServices)
        {
            _adminServices = adminServices;
        }

        
        //[HttpGet("GetAllAppointment")]
        //public async Task<IActionResult> GetAllAppointment() 
        //{
        //    var user = await _adminServices.GetAllAppointment();
        //    return  Ok(user);
        //}
        
        //[HttpGet("GetAllSpecialize")]
        //public async Task<IActionResult> GetAllSpecialize() 
        //{
        //    var user = await _adminServices.GetAllspecialization();
        //    return  Ok(user);
        //}
        
        [HttpGet("NumberOfDoctors")]
        public async Task<IActionResult> NumberOfDoctors() 
        {
            var user = await _adminServices.NumberOfDoctors();
            return  Ok(user);
        }
        
        
        [HttpGet("NumberOfPationts")]
        public async Task<IActionResult> GetNumberPationts() 
        {
            var user = await _adminServices.NumberOfPationts();
            return  Ok(user);
        }
        
        
        [HttpGet("NumberOfRequest")]
        public async Task<IActionResult> NumberOfRequests() 
        {
            var user = await _adminServices.NumberOfRequests();
            return  Ok(user);
        }
        
        
        [HttpGet("topFiveSpecialize")]
        public async Task<IActionResult> topSpecialize() 
        {
            var user = await _adminServices.TopSpecialize();
            return  Ok(user);
        }
        
        
        [HttpGet("topTenDoctors")]
        public async Task<IActionResult> topDoctors() 
        {
            var user = await _adminServices.TopDoctor();
            return  Ok(user);
        }
        
        
        [HttpGet("GetAllDoctors/{skip}/{take}")]
        public async Task<IActionResult> GetAlldoctor(int skip , int take) 
        {
            var doctors = await _adminServices.GetAllDoctor(skip , take);
            //var s = from d in doctors
            //        join u in users on d.UserId equals u.Id
            //        select new
            //        {
            //            u.UserName,
            //            u.Email,
            //            u.dateOfBirth,
            //            u.gender,
            //            u.image,
            //            u.PhoneNumber,
            //            d.price,
            //            d.SpecializeId,
            //        };
            return  Ok(doctors);
        }
        

        [HttpGet("GetDoctorById/{id}")]
        public async Task<IActionResult> GetDoctorByID(int id) 
        {
            var user = await _adminServices.GetDoctorById(id);
            return  Ok(user);
        }
        

        [HttpPost("AddDoctor")]
        public async Task<IActionResult> AddDoctor([FromForm]DoctorModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _adminServices.AddDoctor(model);
            if (!result.IsAuthenticated)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPut("UpdateDoctor/{id}")]
        public async Task<IActionResult> updateDoctor(int id ,[FromForm] DoctorModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var s = await _adminServices.UpdateDoctor(id, model);
            
            return Ok(s);
        }


        [HttpDelete("DeleteDoctor/{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            
            var a = await _adminServices.DeleteDoctor(id);
            return Ok (a);
        }
        
        [HttpGet("GetAllPationts/{skip}/take")]
        public async Task<IActionResult> GetAllPationts(int skip , int take) 
        {
            var user = await _adminServices.GetAllPationts(skip,take);
            return  Ok(user);
        }


        [HttpGet("GetPationtsById/{id}")]
        public async Task<IActionResult> GetPationtByID(String id) 
        {
            try
            {
            var user = await _adminServices.GetPationtById(id);
            return  Ok(user);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        


        [HttpPost("AddCoupon")]
        public async Task<IActionResult> AddCoupon(Coupon coupon)
        {
            var c = await _adminServices.AddCoupon(coupon);
            
            return Ok(c);
        }

        [HttpPut("UpdateCoupon/{couponId}")]
        public async Task<IActionResult> UpdateCoupon(int couponId, Coupon coupon)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState.Values);
            }
            var updateCoupon = await _adminServices.UpdateCoupon(couponId,coupon);
            if (!updateCoupon)
            {
                return BadRequest(updateCoupon);
            }
            return Ok(updateCoupon);
        }
        

        [HttpDelete("DeleteCoupon/{id}")]
        public async Task<IActionResult> deleteCoupon(int id)
        {
            var c = await _adminServices.DeleteCoupon(id);
            return Ok(c);
        }
        
        [HttpPut("deactivateCoupon/{id}")]
        public async Task<IActionResult> deactivateCoupon(int id)
        {
            var c = await _adminServices.DeactivateCoupon(id);
            return Ok(c);
        }

    }
}
