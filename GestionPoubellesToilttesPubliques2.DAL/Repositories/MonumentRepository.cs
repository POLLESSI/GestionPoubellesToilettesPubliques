using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionPoubellesToilttesPubliques2.DAL.Repositories
{
    public class MonumentRepository : IMonumentRepository
    {
        private readonly SqlConnection _connection;

        public MonumentRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(Monument monument)
        {
            throw new NotImplementedException();
        }

        public void CreateMonument(Monument monument)
        {
            throw new NotImplementedException();
        }

        public Monument? Delete(int monument_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Monument?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Monument? GetById(int monument_Id)
        {
            throw new NotImplementedException();
        }

        public Monument? Update(int monument_Id, string monumentName, string description, string posLat, string posLong)
        {
            throw new NotImplementedException();
        }
    }
}
