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
        private readonly IDogLogic _dogLogic;
        public DogController(IDogLogic dogLogic) 
        {
            _dogLogic = dogLogic;
        }
        //TODO linea 23 y 24
        [HttpGet]
        public ActionResult GetDogs([FromQuery] DogGetModelIn dogGetModel)
        {
            DogGetModelOut dogModelOut = new DogGetModelOut(_dogLogic.GetByBreed(dogGetModel.ToEntity()));
            return Ok(dogModelOut);
        }
        //TODO linea 31 y 32
        [HttpPost]
        [AuthenticationFilter]
        public ActionResult Create([FromBody] DogCreateModelIn dogCreateModel)
        {
            DogCreateModelOut dogModelOut = new DogCreateModelOut(_dogLogic.CreateDog(dogCreateModel.ToEntity()));
            return CreatedAtAction(nameof(Create), dogModelOut);
        }
    }
}
