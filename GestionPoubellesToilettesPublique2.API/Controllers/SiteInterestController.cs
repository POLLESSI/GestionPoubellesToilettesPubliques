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
    public class SiteInterestController : ControllerBase
    {
        private readonly ISiteInterestRepository _siteInterestRepository;
        private readonly SiteInterestHub _siteInterestHub;
        private readonly Dictionary<string, string> _currentSiteInterest = new Dictionary<string, string>();

        public SiteInterestController(ISiteInterestRepository siteInterestRepository, SiteInterestHub siteInterestHub)
        {
            _siteInterestRepository = siteInterestRepository;
            _siteInterestHub = siteInterestHub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_siteInterestRepository.GetAll());

        }
        [HttpGet("{siteinterest_id}")]
        public IActionResult GetById(int siteInterest_Id)
        {
            return Ok(_siteInterestRepository.GetById(siteInterest_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(SiteInterestRegisterForm siteInterest)
        {
            if (!ModelState.IsValid) 
                return BadRequest();
            if (_siteInterestRepository.Create(siteInterest.SiteInterestToDal()))
            {
                await _siteInterestHub.RefreshSiteInterest();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("siteinterest_id")]
        public IActionResult Delete(int siteInterest_Id)
        {
            _siteInterestRepository.Delete(siteInterest_Id);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceiveSiteInterestUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate)
            {
                _currentSiteInterest[item.Key] = item.Value;
            }
            return Ok(_currentSiteInterest);
        }
        //[HttpOptions("{siteinterest_id}")]
        //IActionResult PrefligthRoute(int siteInterest_Id)
        //{
        //    return NoContent();
        //}
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("{siteinterest_id}")]
        //IActionResult PutTodoItem(int siteinterest_Id)
        //{
        //    if (siteinterest_Id < 1)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(siteinterest_Id);
        //}
    }
}
