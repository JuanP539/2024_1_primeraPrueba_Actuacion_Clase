using IBusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DogApi.Controllers
{
    [ApiController]
    [Route("api/dogs")]
    public class DogController : ControllerBase
    {
        private readonly IDogLogic _dogLogic;
        public DogController(IDogLogic dogLogic) 
        {
            _dogLogic = dogLogic;
        }

        [HttpGet]
        public ActionResult Get()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }
    }
}
