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
    public class GarbageCanRepository : IGarbageCanRepository
    {
        private readonly SqlConnection _connection;

        public GarbageCanRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(GarbageCan garbageCan)
        {
            throw new NotImplementedException();
        }

        public void CreateGarbageCan(GarbageCan garbageCan)
        {
            throw new NotImplementedException();
        }

        public GarbageCan? Delete(int garbageCan_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GarbageCan?> GetAll()
        {
            throw new NotImplementedException();
        }

        public GarbageCan? GetById(int garbageCan_Id)
        {
            throw new NotImplementedException();
        }

        public GarbageCan? Update(int garbageCan_Id, string? num_Mat, string? posLat, string? posLong, int addres_Id, bool isFull, bool degradation)
        {
            throw new NotImplementedException();
        }
    }
}
