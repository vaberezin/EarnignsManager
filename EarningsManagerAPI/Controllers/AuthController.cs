using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EarningsManagerAPI.Models;
using EarningsManagerAPI.Services;


namespace TimesheetAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    

    public class AuthController : ControllerBase
    {
        [HttpPost]
        public ActionResult<bool> Login(LoginRequest loginRequest){

            var authService = new AuthService();

            return Ok(authService.Login(loginRequest.lastName));
        }
    }

}