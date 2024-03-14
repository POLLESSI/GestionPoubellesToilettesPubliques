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
    public class IncivilityController : ControllerBase
    {
        private readonly IIncivilityRepository _incivilityRepository;
        private readonly IncivilityHub _incivilityHub;
        private readonly Dictionary<string, string> _currentIncivility = new Dictionary<string, string>();

        public IncivilityController(IIncivilityRepository incivilityRepository, IncivilityHub incivilityHub)
        {
            _incivilityRepository = incivilityRepository;
            _incivilityHub = incivilityHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_incivilityRepository.GetAll());
        }
        [HttpGet("{incivility_id}")]
        public IActionResult GetById(int incivility_Id)
        {
            return Ok(_incivilityRepository.GetById(incivility_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(IncivilityRegisterForm incivility)
        {
            if (!ModelState.IsValid) 
                return BadRequest();
            if (_incivilityRepository.Create(incivility.IncivilityToDal()))
            {
                await _incivilityHub.RefreshIncivility();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("{incivility_id}")]
        public IActionResult Delete(int incivility_Id)
        {
            _incivilityRepository.Delete(incivility_Id);
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(int incivility_Id, string num_Mat, string posLat, string posLong, int addres_id, bool isFull, bool degradation)
        {
            _incivilityRepository.Update(incivility_Id, num_Mat, posLat, posLong, addres_id, isFull, degradation);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceiveIncivilityUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currentIncivility[item.Key] = item.Value;
            }
            return Ok(_currentIncivility);
        }
        //[HttpOptions("{incivility_id}")]
        //IActionResult PrefligthRoute(int incivility_Id)
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("incivility_id")]
        //IActionResult PutTodoItem(int incivility_Id)
        //{
        //    if (incivility_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(incivility_Id);
        //}
    }
}
