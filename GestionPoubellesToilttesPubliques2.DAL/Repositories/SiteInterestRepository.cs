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
    public class SiteInterestRepository : ISiteInterestRepository
    {
        private readonly SqlConnection _connection;

        public SiteInterestRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(SiteInterest siteInterest)
        {
            throw new NotImplementedException();
        }

        public void CreateSiteInterest(SiteInterest siteInterest)
        {
            throw new NotImplementedException();
        }

        public SiteInterest? Delete(int siteInterest_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SiteInterest?> GetAll()
        {
            throw new NotImplementedException();
        }

        public SiteInterest? GetById(int siteInterest_Id)
        {
            throw new NotImplementedException();
        }

        public SiteInterest? Update(int siteInterestId, string siteInterestName, string siteInterstType, string posLat, string posLong, string description)
        {
            throw new NotImplementedException();
        }
    }
}
