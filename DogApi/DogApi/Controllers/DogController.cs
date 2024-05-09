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
        //TODO lines 24 y 25
        [HttpGet]
        [AuthenticationFilter] //Token: C1B94565-BDF1-4C16-B890-2DD46328227A
        public ActionResult GetDogs([FromQuery] DogGetModelIn dogGetModel)
        {
            DogGetModelOut dogModelOut = new DogGetModelOut(_dogLogic.GetByBreed(dogGetModel.ToEntity()));
            return Ok(dogModelOut);
        }
        //TODO lines 32 y 33
        [HttpPost]
        [AuthenticationFilter] //Token: C1B94565-BDF1-4C16-B890-2DD46328227A
        public ActionResult Create([FromBody] DogCreateModelIn dogCreateModel)
        {
            DogCreateModelOut dogModelOut = new DogCreateModelOut(_dogLogic.CreateDog(dogCreateModel.ToEntity()));
            return CreatedAtAction(nameof(Create), dogModelOut);
        }
    }
}
