using IBusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.In;
using Models.Out;

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
        public ActionResult GetDogs([FromQuery] DogGetModel dogGetModel)
        {
            DogGetModelOut dogModelOut = new DogGetModelOut(_dogLogic.GetByName(dogGetModel.ToEntity()));
            return Ok(dogModelOut);
        }

        [HttpPost]
        public ActionResult Create([FromBody] DogCreateModel dogCreateModel)
        {
            DogCreateModelOut dogModelOut = new DogCreateModelOut(_dogLogic.CreateDog(dogCreateModel.ToEntity()));
            return Ok(dogModelOut);
        }
    }
}
