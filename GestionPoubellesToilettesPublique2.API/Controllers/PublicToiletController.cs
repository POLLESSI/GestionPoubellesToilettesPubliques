using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionPoubellesToilettesPublique2.API.Hubs;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettesPublique2.API.Dtos.Forms;
using GestionPoubellesToilettesPublique2.API.Tools;

namespace GestionPoubellesToilettesPublique2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicToiletController : ControllerBase
    {
        private readonly IPublicToiletRepository _publicToiletRepository;
        private readonly PublicToiletHub _publicToiletHub;
        private readonly Dictionary<string, string> _currentPublicToilet = new Dictionary<string, string>();

        public PublicToiletController(IPublicToiletRepository publicToiletRepository, PublicToiletHub publicToiletHub)
        {
            _publicToiletRepository = publicToiletRepository;
            _publicToiletHub = publicToiletHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_publicToiletRepository.GetAll());
        }
        [HttpGet("{publictoilet_id}")]
        public IActionResult GetById(int publicToilet_Id)
        {
            return Ok(_publicToiletRepository.GetById(publicToilet_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(PublicToiletRegisterForm publicToilet)
        {
            if (!ModelState.IsValid) 
                return BadRequest();
            if (_publicToiletRepository.Create(publicToilet.PublicToiletToDal()))
            {
                await _publicToiletHub.RefreshPublicToilet();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("{publictoilet_id}")]
        public IActionResult Delete(int publicToilet_Id)
        {
            _publicToiletRepository.Delete(publicToilet_Id);
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(int publicToilet_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation)
        {
            _publicToiletRepository.Update(publicToilet_Id, num_Mat, posLat, posLong, addres_Id, isFull, degradation);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceivePublicToiletUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currentPublicToilet[item.Key] = item.Value;
            }
            return Ok(_currentPublicToilet);
        }
        //[HttpOptions("{publictoilet_id}")]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PreflightRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("{publictoilet_id}")]
        //IActionResult PutTodoItem(int publicToilet_Id)
        //{
        //    if (publicToilet_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(publicToilet_Id);
        //}
    }
}
