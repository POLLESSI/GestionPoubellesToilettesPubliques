using GestionPoubellesToilettesPublique2.API.Dtos.Forms;
using GestionPoubellesToilettesPublique2.API.Hubs;
using GestionPoubellesToilettesPublique2.API.Tools;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionPoubellesToilettesPublique2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakeshiftShelterController : ControllerBase
    {
        private readonly IMakeshiftShelterRepository _makeshiftShelterRepository;
        private readonly MakeshiftShelterHub _makeshiftShelterHub;
        private readonly Dictionary<string, string> _currentMakeshiftSchelter = new Dictionary<string, string>();

        public MakeshiftShelterController(IMakeshiftShelterRepository makeshiftShelterRepository, MakeshiftShelterHub makeshiftShelterHub)
        {
            _makeshiftShelterRepository = makeshiftShelterRepository;
            _makeshiftShelterHub = makeshiftShelterHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_makeshiftShelterRepository.GetAll());
        }
        [HttpGet("{makeshiftschelter_id}")]
        public IActionResult GetById(int makeshiftSchelter_Id)
        {
            return Ok(_makeshiftShelterRepository.GetById(makeshiftSchelter_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(MakeshiftShelterRegisterForm makeshiftShelter)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            if (_makeshiftShelterRepository.Create(makeshiftShelter.MakeshiftSchelterToDal()))
            {
                await _makeshiftShelterHub.RefreshMakeshiftShelter();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("{makeshiftschelter_id}")]
        public IActionResult Delete(int makeshiftSchelter_Id)
        {
            _makeshiftShelterRepository.Delete(makeshiftSchelter_Id);
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(int makeshiftSchelter_Id, string latitude, string longitude, string description) 
        {
            _makeshiftShelterRepository.Update(makeshiftSchelter_Id, latitude, longitude, description);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceiveMakeshiftSchelterUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currentMakeshiftSchelter[item.Key] = item.Value;
            }
            return Ok(_currentMakeshiftSchelter);
        }
        //[HttpOptions("{makeshiftschelter_id}")]
        //IActionResult PrefligthRoute(int makeshiftSchelter_Id)
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("makeshiftschelter_id")]
        //IActionResult PutTodoItem(int makeshiftSchelter_Id)
        //{
        //    if (makeshiftSchelter_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(makeshiftSchelter_Id);
        //}
    }
}
