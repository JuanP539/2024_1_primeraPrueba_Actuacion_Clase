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
        //TODO Inyeccion de dependencia
        private readonly IUserLogic _userLogic;
        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        //TODO parametro, linea 23 y 24
        [HttpPost]
        [Route("sessions")]
        public IActionResult Login([FromBody] UserLoginModel loginModel)
        {
            UserLoginResponseModel userLoginResponse = new UserLoginResponseModel(_userLogic.GetUserToken(loginModel.Email, loginModel.Password));
            return CreatedAtAction(nameof(Login), userLoginResponse);
        }
    }
}
