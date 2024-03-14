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
    public class CanisiteRepository : ICanisiteRepository
    {
        private readonly SqlConnection _connection;

        public CanisiteRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(Canisite canisite)
        {
            throw new NotImplementedException();
        }

        public void createCanisite(Canisite canisite)
        {
            throw new NotImplementedException();
        }

        public Canisite? Delete(int canisite_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Canisite?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Canisite? GetById(int canisite_Id)
        {
            throw new NotImplementedException();
        }

        public Canisite? Update(int canisite_Id, string? num_Mat, string? posLat, string? posLong, int addres_Id, bool isFull, bool degradation)
        {
            throw new NotImplementedException();
        }
    }
}
