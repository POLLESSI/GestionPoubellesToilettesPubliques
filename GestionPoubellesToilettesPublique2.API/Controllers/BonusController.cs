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
    public class BonusController : ControllerBase
    {
        private readonly IBonusRepository _bonusRepository;
        private readonly BonusHub _bonusHub;
        private readonly Dictionary<string, string> _currentBonus = new Dictionary<string, string>();

        public BonusController(IBonusRepository bonusRepository, BonusHub bonusHub)
        {
            _bonusRepository = bonusRepository;
            _bonusHub = bonusHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bonusRepository.GetAll());
        }
        [HttpGet("{bonus_id}")]
        public IActionResult GetById(int bonus_Id)
        {
            return Ok(_bonusRepository.GetById(bonus_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(BonusRegisterForm bonus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (_bonusRepository.Create(bonus.BonusToDal()))
            {
                await _bonusHub.RefreshBonus();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("{bonus_id}")]
        public IActionResult Delete(int bonus_Id)
        {
            _bonusRepository.Delete(bonus_Id);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceiveBonusUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currentBonus[item.Key] = item.Value;
            }
            return Ok(_currentBonus);
        }
        //[HttpOptions("{bonus_id}")]
        //IActionResult PrefligthRoute(int bonus_Id)
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("{bonus_id}")]
        //IActionResult PutTodoItem(int bonus_Id)
        //{
        //    if (bonus_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(bonus_Id);
        //}
    }
}
