using GestionPoubellesToilettesPublique2.API.Dtos.Forms;
using GestionPoubellesToilettesPublique2.API.Hubs;
using GestionPoubellesToilettesPublique2.API.Tools;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace GestionPoubellesToilettesPublique2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly IMapRepository _mapRepository;
        private readonly MapHub _mapHub;
        private readonly Dictionary<string, string> _currenMap = new Dictionary<string, string>();

        public MapController(IMapRepository mapRepository, MapHub mapHub)
        {
            _mapRepository = mapRepository;
            _mapHub = mapHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mapRepository.GetAll());
        }
        [HttpGet("{map_id}")]
        public IActionResult GetById(int map_Id) 
        {
            return Ok(_mapRepository.GetById(map_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(MapRegisterForm map)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            if (_mapRepository.Create(map.MapToDal()))
            {
                await _mapHub.RefreshMap();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("{map_id}")]
        public IActionResult Delete(int map_Id)
        {
            _mapRepository.Delete(map_Id);
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(int map_Id, DateTime dateCreation, string description) 
        {
            _mapRepository.Update(map_Id, dateCreation, description);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceiveMapUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currenMap[item.Key] = item.Value;
            }
            return Ok(_currenMap);
        }
        [HttpOptions("{map_id}")]
        IActionResult PrefligthRoute(int map_Id)
        {
            return NoContent();
        }
        [HttpOptions]
        IActionResult PrefligthRoute()
        {
            return NoContent();
        }
        [HttpPut("map_id")]
        IActionResult PutTodoItem(int map_Id)
        {
            if (map_Id < 1)
            {
                return BadRequest();
            }
            return Ok(map_Id);
        }
    }
}
