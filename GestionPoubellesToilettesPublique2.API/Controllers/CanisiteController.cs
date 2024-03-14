using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionPoubellesToilettesPublique2.API.Hubs;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettesPublique2.API.Dtos.Forms;
using GestionPoubellesToilettesPublique2.API.Tools;
using System.Security.Cryptography;

namespace GestionPoubellesToilettesPublique2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CanisiteController : ControllerBase
    {
        private readonly ICanisiteRepository _canisiteRepository;
        private readonly CanisiteHub _canisiteHub;
        private readonly Dictionary<string, string> _currentCanisite = new Dictionary<string, string>();

        public CanisiteController(ICanisiteRepository canisiteRepository, CanisiteHub canisiteHub)
        {
            _canisiteRepository = canisiteRepository;
            _canisiteHub = canisiteHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_canisiteRepository.GetAll());
        }
        [HttpGet("{canisite_id}")]
        public IActionResult GetById(int canisite_Id)
        {
            return Ok(_canisiteRepository.GetById(canisite_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(CanisiteRegisterForm canisite)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            if (_canisiteRepository.Create(canisite.CanisiteToDal()))
            {
                await _canisiteHub.RefreshCanisite();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("{canisite_id}")]
        public IActionResult Delete(int canisite_Id)
        {
            _canisiteRepository.Delete(canisite_Id);
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(int canisite_Id, string num_Mat, string posLat, string posLong, int Addres_Id, bool isFull, bool degradation)
        {
            _canisiteRepository.Update(canisite_Id, num_Mat, posLat, posLong, Addres_Id, isFull, degradation);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceiveCanisiteUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currentCanisite[item.Key] = item.Value;
            }
            return Ok(_currentCanisite);
        }
        //[HttpOptions("{canisite_id}")]
        //IActionResult PrefligthRoute(int canisite_Id)
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("canisite_id")]
        //IActionResult PutTodoItem(int canisite_Id)
        //{
        //    if (canisite_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(canisite_Id);
        //}
    }
}
