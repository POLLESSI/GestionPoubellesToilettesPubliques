using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionPoubellesToilettesPublique2.API.Hubs;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettesPublique2.API.Dtos.Forms;
using GestionPoubellesToilettesPublique2.API.Tools;
using System.Security.Cryptography;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
namespace GestionPoubellesToilettesPublique2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonumentController : ControllerBase
    {
        private readonly IMonumentRepository _monumentRepository;
        private readonly MonumentHub _monumentHub;
        private readonly Dictionary<string, string> _currentMonument = new Dictionary<string, string>();

        public MonumentController(IMonumentRepository monumentRepository, MonumentHub monumentHub)
        {
            _monumentRepository = monumentRepository;
            _monumentHub = monumentHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_monumentRepository.GetAll());
        }
        [HttpGet("{monument_id}")]
        public IActionResult GetById(int monument_Id)
        {
            return Ok(_monumentRepository.GetById(monument_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(MonumentRegisterForm monument)
        {
            if (!ModelState.IsValid) 
                return BadRequest();
            if (_monumentRepository.Create(monument.MonumentToDal()))
            {
                await _monumentHub.RefreshMonument();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("{monument_id}")]
        public IActionResult Delete(int monument_Id)
        {
            _monumentRepository.Delete(monument_Id);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceiveEventUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currentMonument[item.Key] = item.Value;
            }
            return Ok(_currentMonument);
        }
        //[HttpOptions("{monument_id}")]
        //IActionResult PrefligthRoute(int monument_Id)
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("{monument_id}")]
        //IActionResult PutTodoItem(int monument_Id)
        //{
        //    if (monument_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(monument_Id);
        //}
    }
}
