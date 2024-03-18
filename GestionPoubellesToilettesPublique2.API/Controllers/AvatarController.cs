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
    public class AvatarController : ControllerBase
    {
        private readonly IAvatarRepository _avatarRepository;
        private readonly AvatarHub _avatarHub;
        private readonly Dictionary<string, string> _currentAvatar = new Dictionary<string, string>();

        public AvatarController(IAvatarRepository avatarRepository, AvatarHub avatarHub)
        {
            _avatarRepository = avatarRepository;
            _avatarHub = avatarHub;
        }
    }
}
