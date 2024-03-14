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
    public class AshtrayRepository : IAshtrayRepository
    {
        private readonly SqlConnection _connection;

        public AshtrayRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(Ashtray ashtray)
        {
            throw new NotImplementedException();
        }

        public void CreateAshtray(Ashtray ashtray)
        {
            throw new NotImplementedException();
        }

        public Ashtray? Delete(int ashtray_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ashtray?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ashtray? GetById(int ashtray_Id)
        {
            throw new NotImplementedException();
        }

        public Ashtray? Update(int ashTray_Id, string? num_Mat, string? posLat, string? posLong, int addres_Id, bool isFull, bool degradation)
        {
            throw new NotImplementedException();
        }
    }
}
