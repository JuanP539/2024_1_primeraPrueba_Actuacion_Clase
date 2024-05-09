﻿using DogApi.Filters;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Models.In;
using Models.Out;

namespace DogApi.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUserLogic _userLogic;
        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        //TODO lines 23 y 24
        [HttpGet]
        [AuthenticationFilter] //Token es: C1B94565-BDF1-4C16-B890-2DD46328227A
        public IActionResult GetUserToken([FromBody] UserLoginModelIn loginModel)
        {
            UserLoginModelOut userLoginResponse = new UserLoginModelOut(_userLogic.GetUserToken(loginModel.Email, loginModel.Password));
            return Ok(userLoginResponse);
        }
    }
}
