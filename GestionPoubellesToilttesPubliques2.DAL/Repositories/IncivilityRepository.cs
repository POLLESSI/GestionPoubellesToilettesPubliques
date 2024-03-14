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
    public class IncivilityRepository : IIncivilityRepository
    {
        private readonly SqlConnection _connection;

        public IncivilityRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(Incivility incivility)
        {
            throw new NotImplementedException();
        }

        public void CreateIncivility(Incivility incivility)
        {
            throw new NotImplementedException();
        }

        public Incivility? Delete(int incivility_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Incivility?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Incivility? GetById(int incivility_Id)
        {
            throw new NotImplementedException();
        }

        public Incivility? Update(int incivility_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool severe, bool absorbed)
        {
            throw new NotImplementedException();
        }
    }
}
