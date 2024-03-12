using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.NUser;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface INUserService
    {
        bool Create(NUser nUser);
        void CreateNUser(NUser nUser);
        IEnumerable<NUser?> GetAll();
        NUser? GetById(Guid nUser_id);
        NUser? Delete(Guid nUser_Id);
        NUser? Update(Guid nUser_Id, string email, string pwd, int person_Id, string role_Id );
        bool RegisterNUser(string email, string pwd, int person_Id, string role_Id);
        NUser? LoginNUser(string email, string pwd);
    }
}
