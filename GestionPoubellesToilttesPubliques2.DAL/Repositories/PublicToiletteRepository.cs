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
    public class PublicToiletteRepository : IPublicToiletRepository
    {
        private readonly SqlConnection _connection;

        public PublicToiletteRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(PublicToilet publicToilet)
        {
            throw new NotImplementedException();
        }

        public void CreatePublicToilet(PublicToilet publicToilet)
        {
            throw new NotImplementedException();
        }

        public PublicToilet? Delete(int publicToilet_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PublicToilet?> GetAll()
        {
            throw new NotImplementedException();
        }

        public PublicToilet? GetById(int publicToilet_Id)
        {
            throw new NotImplementedException();
        }

        public PublicToilet? Update(int publicToilet_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation)
        {
            throw new NotImplementedException();
        }
    }
}
