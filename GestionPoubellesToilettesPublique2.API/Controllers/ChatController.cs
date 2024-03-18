using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionPoubellesToilettesPublique2.API.Models;
using GestionPoubellesToilettesPublique2.API.Hubs;
using GestionPoubellesToilettesPublique2.API.Tools;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;

namespace GestionPoubellesToilettesPublique2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatRepository _chatRepository;
        private readonly ChatHub _hub;
        public ChatController(IChatRepository chatRepository, ChatHub hub)
        {
            _chatRepository = chatRepository;
            _hub = hub;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_chatRepository.GetAll());
        }
        [HttpGet("{chat_id}")]
        public IActionResult GetById(int chat_Id) 
        {
            return Ok(_chatRepository.GetById(chat_Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(Message newMessage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (_chatRepository.Create(newMessage.ChatToDal()))
            {
                await _hub.RefreshChat();
                return Ok(newMessage);
            }
            return BadRequest("Registration error");
        }
        [HttpDelete("{chat_id}")]
        public IActionResult Delete(int chat_Id)
        {
            _chatRepository.Delete(chat_Id);
            return Ok();
        }
        [HttpOptions("{chat_id}")]
        IActionResult PrefligthRoute(int chat_Id)
        {
            return NoContent();
        }
        [HttpPut("chat_id")]
        IActionResult PutToDoItem(int chat_Id) 
        {
            if (chat_Id < 1)
            {
                return BadRequest();
            }
            return Ok(chat_Id);
        }
    }
}
