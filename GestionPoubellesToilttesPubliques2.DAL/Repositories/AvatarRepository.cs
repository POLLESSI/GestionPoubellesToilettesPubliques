using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionPoubellesToilttesPubliques2.DAL.Repositories
{
    public class AvatarRepository : IAvatarRepository
    {
        private readonly SqlConnection _connection;

        public AvatarRepository(SqlConnection connection)
        {
            _connection = connection;
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

        public Avatar? Update(int avatar_Id, string avatarName, string description, int nUser_Id)
        {
            throw new NotImplementedException();
        }
    }
}
