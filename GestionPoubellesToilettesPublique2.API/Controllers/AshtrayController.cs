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
    public class AshtrayController : ControllerBase
    {
        private readonly IAshtrayRepository _ashtrayRepository;
        private readonly AshtrayHub _ashtrayHub;
        private readonly Dictionary<string, string> _currentAshtray = new Dictionary<string, string>();

        public AshtrayController(IAshtrayRepository ashtrayRepository, AshtrayHub ashtrayHub)
        {
            _ashtrayRepository = ashtrayRepository;
            _ashtrayHub = ashtrayHub;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_ashtrayRepository.GetAll());
        }
        [HttpGet("{ashtray_id}")]
        public IActionResult GetById(int ashtray_Id)
        {
            return Ok(_ashtrayRepository.GetById(ashtray_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(AshtrayRegisterForm ashtray)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (_ashtrayRepository.Create(ashtray.AshtrayToDal()))
            {
                await _ashtrayHub.RefreshAshtray();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("{ashtray_id}")]
        public IActionResult Delete(int ashtray_Id)
        {
            _ashtrayRepository.Delete(ashtray_Id);
            return Ok();
        }       
        [HttpPut("update")]
        public IActionResult Update(int ashtray_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation)
        {
            _ashtrayRepository.Update(ashtray_Id, num_Mat, posLat, posLong, addres_Id, isFull, degradation);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceiveAshtrayUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currentAshtray[item.Key] = item.Value;
            }
            return Ok(_currentAshtray);
        }
        //[HttpOptions("{ashtray_id}")]
        //IActionResult PrefligthRoute(int ashtray_Id)
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("{ashtray_Id}")]
        //IActionResult PutTodoItem(int ashtray_Id)
        //{
        //    if (ashtray_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(ashtray_Id);
        //}
    }
}
