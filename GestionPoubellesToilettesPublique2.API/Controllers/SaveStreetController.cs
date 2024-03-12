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
    public class SaveStreetController : ControllerBase
    {
        private readonly ISaveStreetRepository _saveStreetRepository;
        private readonly SaveStreetHub _saveStreetHub;
        private readonly Dictionary<string,  string> _currentSaveStreet = new Dictionary<string, string>();

        public SaveStreetController(ISaveStreetRepository saveStreetRepository, SaveStreetHub saveStreetHub)
        {
            _saveStreetRepository = saveStreetRepository;
            _saveStreetHub = saveStreetHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_saveStreetRepository.GetAll());
        }
        [HttpGet("{savestreet_id}")]
        public IActionResult GetById(int saveStreet_Id)
        {
            return Ok(_saveStreetRepository.GetById(saveStreet_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(SaveStreetRegisterForm saveStreet)
        {
            if (!ModelState.IsValid) 
                return BadRequest();
            if (_saveStreetRepository.Create(saveStreet.SaveStreetToDal()))
            {
                await _saveStreetHub.RefreshSaveStreet();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("{savestreet_id}")]
        public IActionResult Delete(int saveStreet_Id) 
        {
            _saveStreetRepository.Delete(saveStreet_Id);
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(int saveStreet_Id, string streetName, string startLatitude, string endLatitude, string startLongitude, string endLongitude, string securityScore)
        {
            _saveStreetRepository.Update(saveStreet_Id, streetName, startLatitude, endLatitude, startLongitude, endLongitude, securityScore);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceivesaveStreetUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currentSaveStreet[item.Key] = item.Value;
            }
            return Ok(_currentSaveStreet);
        }
        //[HttpPatch("update")]
        //public IActionResult Update(SaveStreetUpdate sst)
        //{
        //    _saveStreetRepository.Update(sst.SaveStreet_Id, sst.StreetName, sst.StartLatitude, sst.EndLatitude, sst.StartLongitude, sst.EndLongitude, sst.SecurityScore);
        //    return Ok();
        //}
        //[HttpOptions("{savestreet_id}")]
        //IActionResult PrefligthRoute(int saveStreet_Id)
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("savestreet_id")]
        //IActionResult PutTodoItem(int saveStreet_Id)
        //{
        //    if (saveStreet_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(saveStreet_Id);
        //}
    }
}
