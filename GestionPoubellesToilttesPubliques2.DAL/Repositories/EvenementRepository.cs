using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Evenement;

namespace GestionPoubellesToilttesPubliques2.DAL.Repositories
{
    public class EvenementRepository : IEvenementRepository
    {
        private readonly SqlConnection _connection;

        public EvenementRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(Evenement evenement)
        {
            throw new NotImplementedException();
        }

        public void CreateEvenement(Evenement evenement)
        {
            throw new NotImplementedException();
        }

        public Evenement? Delete(int evenement_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evenement?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Evenement? GetById(int evenement_Id)
        {
            throw new NotImplementedException();
        }

        public Evenement? Update(int evenement_Id, DateTime evenementDate, string evenementDescription, string posLat, string posLong, bool positif)
        {
            throw new NotImplementedException();
        }
    }
}
