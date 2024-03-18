using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class SiteInterestService : ISiteInterestService
    {
        private readonly ISiteInterestRepository _siteInterestRepository;

        public SiteInterestService(ISiteInterestRepository siteInterestRepository)
        {
            _siteInterestRepository = siteInterestRepository;
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

        public SiteInterest? Update(int siteInterest_Id, string siteInterestType, string posLat, string posLong, string Description)
        {
            throw new NotImplementedException();
        }
    }
}
