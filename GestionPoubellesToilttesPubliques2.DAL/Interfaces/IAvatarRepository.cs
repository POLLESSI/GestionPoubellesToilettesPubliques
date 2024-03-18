using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Avatar;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IAvatarRepository
    {
        bool Create(Avatar avatar);
        void CreateAvatar(Avatar avatar);
        IEnumerable<Avatar?> GetAll();
        Avatar? GetById(int avatar_Id);
        Avatar? Delete(int avatar_Id);
        Avatar? Update(int avatar_Id, string avatarName, string description, int nUser_Id);
    }
}
