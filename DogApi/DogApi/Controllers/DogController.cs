using DogApi.Filters;
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
        //TODO Inyección dependencia
        private readonly IDogLogic _dogLogic;
        public DogController(IDogLogic dogLogic) 
        {
            _dogLogic = dogLogic;
        }
        //TODO linea 23 y 24
        [HttpGet]
        public ActionResult GetDogs([FromQuery] DogGetModel dogGetModel)
        {
            DogGetModelOut dogModelOut = new DogGetModelOut(_dogLogic.GetByBreed(dogGetModel.ToEntity()));
            return Ok(dogModelOut);
        }
        //TODO line 33 y 34
        [HttpPost]
        [AuthenticationFilter]
        public ActionResult Create([FromBody] DogCreateModel dogCreateModel)
        {
            DogCreateModelOut dogModelOut = new DogCreateModelOut(_dogLogic.CreateDog(dogCreateModel.ToEntity()));
            return CreatedAtAction(nameof(Create), dogModelOut);
        }
    }
}
