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
    public class AddresController : ControllerBase
    {
        private readonly IAddresRepository _addresRepository;
        private readonly AddresHub _addresHub;
        private readonly Dictionary<string, string> _currentAddres = new Dictionary<string, string>();

        public AddresController(IAddresRepository addresRepository, AddresHub addresHub)
        {
            _addresRepository = addresRepository;
            _addresHub = addresHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_addresRepository.GetAll());
        }
        [HttpGet("{addres_id}")]
        public IActionResult GetById(int addres_Id) 
        {
            return Ok(_addresRepository.GetById(addres_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddresRegisterForm addres)
        {
            if (!ModelState.IsValid) 
                return BadRequest();
            if (_addresRepository.Create(addres.AddresToDal()))
            {
                await _addresHub.RefreshAddres();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("{addres_id}")]
        public IActionResult Delete(int addres_Id)
        {
            _addresRepository.Delete(addres_Id);
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(int addres_Id, string rue, string numero, string cP, string ville, string pays)
        {
            _addresRepository.Update(addres_Id, rue, numero, cP, ville, pays);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceiveAddressUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currentAddres[item.Key] = item.Value;
            }
            return Ok(_currentAddres);
        }
        //[HttpOptions("{addres_id}")]
        //IActionResult PrefligthRoute(int adddres_Id)
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("addres_id")]
        //IActionResult PutTodoItem(int addres_Id)
        //{
        //    if (addres_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(addres_Id);
        //}
    }
}
