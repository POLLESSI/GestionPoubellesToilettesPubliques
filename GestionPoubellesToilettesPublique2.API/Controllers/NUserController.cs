using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionPoubellesToilettesPublique2.API.Tools;
using GestionPoubellesToilettesPublique2.API.Dtos.Forms;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilettresPubliques2.BLL.Models;
using Microsoft.AspNetCore.Authorization;
using GestionPoubellesToilettesPublique2.API.Hubs;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.RegularExpressions;
using BelgianCaveRegister_Api.Tools;

namespace GestionPoubellesToilettesPublique2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NUserController : ControllerBase
    {
        private readonly GestionPoubellesToilttesPubliques2.DAL.Interfaces.INUserRepository _userRepository;
        private readonly TokenGenerator _tokenGenerator;
        private readonly NUserHub _nUserHub;
        private readonly Dictionary<string, string> _currentNUser = new Dictionary<string, string>();
        public NUserController(INUserRepository userRepository, NUserHub nUserHub, TokenGenerator tokenGenerator)
        {
            _userRepository = userRepository;
            _nUserHub = nUserHub;
            _tokenGenerator = tokenGenerator;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userRepository.GetAll());
        }
        [HttpGet("{nuser_id}")]
        public IActionResult GetById(Guid nUser_Id) 
        {
            return Ok(_userRepository?.GetById(nUser_Id));
        }
        [HttpPost("login")]
        public IActionResult Login(NUserLoginForm nUser)
        {
            try
            {
                NUser? connectedNUser = _userRepository.LoginNUser(nUser.Email, nUser.Pwd);
                if (connectedNUser != null)
                {
                    //var token = _tokenGenerator.GenerateToken(connectedNUser);
                    return Ok(/*new { Token = token, Role = connectedNUser.Role_Id }*/ );
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            try
            {
                NUser? connectedNUser = _userRepository.LoginNUser(nUser.Email, nUser.Pwd);
                string? MdpNUser = nUser.Pwd;
                string? hashpwd = connectedNUser.Pwd;
                bool motDePassValide = BCrypt.Net.BCrypt.Verify(MdpNUser, hashpwd);
                if (motDePassValide)
                {
                    return Ok(/*_tokenGenerator.GenerateToken(connectedNUser)*/); 
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost("register")]
        public IActionResult Register(NewNUser nu)
        {
            _userRepository.RegisterNUser(nu.Email, nu.Pwd, nu.Person_Id, nu.Role_Id);
            return Ok(nu);
        }
        [HttpPost]
        public async Task<IActionResult> Create(NUserForm nUser)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            if (_userRepository.Create(nUser.NUserToDal()))
            {
                await _nUserHub.RefreshNUser();
                return Ok();
            }
            return BadRequest("Registration Error");
        }
        [HttpDelete("nuser_id")]
        public IActionResult Delete(Guid nUser_Id)
        {
            _userRepository.Delete(nUser_Id);
            return Ok();
        }
        [HttpPut("nuser_id")]
        public IActionResult Update(Guid nUser_Id, string? email, string? pwd, int person_Id, string role_Id)
        {
            _userRepository.Update(nUser_Id, email, pwd, person_Id, role_Id);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult ReceiveNUserUpdate(Dictionary<string, string> newUpdate)
        {
            foreach (var item in newUpdate) 
            {
                _currentNUser[item.Key] = item.Value;
            }
            return Ok(_currentNUser);
        }
        [HttpPatch("setrole")]
        public IActionResult ChangeRole(ChangeRole role)
        {
            //_userRepository.SetRole(role.NUser_Id, role.Role_Id);
            return Ok();
        }
        //[HttpOptions("{nuser_id}")]
        //IActionResult PrefligthRoute(Guid nUser_Id)
        //{
        //    return NoContent();
        //}
        //// OPTIONS: api/NUser
        //[HttpOptions]
        //IActionResult PrefligthRoute()
        //{
        //    return NoContent();
        //}
        //[HttpPut("nuser_id")]
        //IActionResult PutToDoItem(Guid nUser_Id)
        //{
        //    if (nUser_Id == Guid.Empty)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(nUser_Id);
        //}
    }
}
