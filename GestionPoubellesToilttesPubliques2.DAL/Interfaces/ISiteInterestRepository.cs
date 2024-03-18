using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.SiteInterest;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface ISiteInterestRepository
    {
        bool Create(SiteInterest siteInterest);
        void CreateSiteInterest(SiteInterest siteInterest);
        IEnumerable<SiteInterest?> GetAll();
        SiteInterest? GetById(int siteInterest_Id);
        SiteInterest? Delete(int siteInterest_Id);
        SiteInterest? Update(int siteInterestId, string siteInterestName, string siteInterstType, string posLat, string posLong, string description);
    }
}
