using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.NUser;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface INUserRepository
    {
        bool Create(NUser nUser);
        void CreateNUser(NUser nUser);
        IEnumerable<NUser?> GetAll();
        NUser? GetById(Guid nUser_Id);
        NUser? Delete(Guid nUser_Id);
        NUser? Update(Guid nUser_id, string email, string pwd, int person_Id, string role_Id);
        bool RegisterNUser(string email, string pwd, int person_Id, string role_Id);
        NUser? LoginNUser(string email, string pwd);
    }
}
