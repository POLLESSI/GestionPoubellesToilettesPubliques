using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Avatar;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IAvatarService
    {
        bool Create(Avatar avatar);
        void CreateAvatar(Avatar avatar);
        IEnumerable<Avatar?> GetAll();
        Avatar? GetById(int avatar_Id);
        Avatar? Delete(int avatar_Id);
        Avatar? Update(int avatar_Id, string avatarName, string description, Guid nUser_Id);
    }
}
