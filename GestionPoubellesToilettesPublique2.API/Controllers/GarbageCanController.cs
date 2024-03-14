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
    public class GarbageCanController : ControllerBase
    {
        private readonly IGarbageCanRepository _garbageCanRepository;
        private readonly GarbageCanHub _garbageCanHub;
        private readonly Dictionary<string, string> _currentGarbageCan = new Dictionary<string, string>();

        public GarbageCanController(IGarbageCanRepository garbageCanRepository, GarbageCanHub garbageCanHub)
        {
            _garbageCanRepository = garbageCanRepository;
            _garbageCanHub = garbageCanHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_garbageCanRepository.GetAll());
        }
        //[HttpGet("{garbagecan_id}")]
        //public IActionResult GetById(int garbageCan_Id);
        //{
        //    return Ok(_garbageCanRepository.GetById(garbageCan_Id));
        //}
        //[HttpPost]
        //public async Task<IActionResult> Create(GarbageCanRegisterForm garbageCan)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest();
        //    if (_garbageCanRepository.Create(garbageCan.GarbageCanToDal()))
        //    {
        //        await _garbageCanHub.RefreshGarbageCan();
        //        return Ok();
        //    }
        //    return BadRequest("Registration Error");
        //}
        //[HttpDelete("{garbagecan_id}")]
        //public IActionResult Delete(int garbageCan_Id)
        //{
        //    _garbageCanRepository.Delete(garbageCan_Id);
        //    return Ok();
        //}
        //[HttpPut("update")]
        //public IActionResult Update(int garbageCan_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation)
        //{
        //    _garbageCanRepository.Update(garbageCan_Id, num_Mat, posLat, posLong, addres_Id, isFull, degradation);
        //    return Ok();
        //}
        //[HttpPost("update")]
        //public IActionResult ReceiveGarbageCanUpdate(Dictionary<string, string> newUpdate)
        //{
        //    foreach (var item in newUpdate)
        //    {
        //        _currentGarbageCan[item.Key] = item.Value;
        //    }
        //    return Ok(_currentGarbageCan);
        //}
        //[HttpOptions("{garbagecan_id}")]
        //IActionResult PrefligthRoute(int garbageCan_Id)
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //return NoContent();
        //}
        //[HttpPut("garbagecan_id")]
        //IActionResult PutTodoItem(int garbageCan_Id)
        //{
        //    if (garbageCan_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //return Ok(garbageCan_Id);
        //}
    }
}
