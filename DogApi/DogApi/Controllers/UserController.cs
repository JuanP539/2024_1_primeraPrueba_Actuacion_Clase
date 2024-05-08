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
        //TODO linea 23 y 24
        [HttpPost]
        [Route("sessions")]
        public IActionResult Login([FromBody] UserLoginModelIn loginModel)
        {
            UserLoginResponseModel userLoginResponse = new UserLoginResponseModel(_userLogic.GetUserToken(loginModel.Email, loginModel.Password));
            return CreatedAtAction(nameof(Login), userLoginResponse);
        }
    }
}
