using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class AvatarService : IAvatarService
    {
        private readonly IAddresRepository _addresRepository;

        public AvatarService(IAddresRepository addresRepository)
        {
            _addresRepository = addresRepository;
        }

        public bool Create(Avatar avatar)
        {
            throw new NotImplementedException();
        }

        public void CreateAvatar(Avatar avatar)
        {
            throw new NotImplementedException();
        }

        public Avatar? Delete(int avatar_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Avatar?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Avatar? GetById(int avatar_Id)
        {
            throw new NotImplementedException();
        }

        public Avatar? Update(int avatar_Id, string avatarName, string description, Guid nUser_Id)
        {
            throw new NotImplementedException();
        }
    }
}
