using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Models.In;
using Models.Out;

namespace DogApi.Controllers
{
    public class UserController : Controller
    {
        //TODO Inyeccion de dependencia
        private readonly IUserLogic _userLogic;
        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        //TODO linea 21 y 22
        [HttpPost]
        [Route("sessions")]
        public IActionResult Login([FromBody] UserLoginModel loginModel)
        {
            UserLoginResponseModel userLoginResponse = new UserLoginResponseModel(_userLogic.GetUserToken(loginModel.Email, loginModel.Password));
            return CreatedAtAction(nameof(Login), userLoginResponse);
        }
    }
}
