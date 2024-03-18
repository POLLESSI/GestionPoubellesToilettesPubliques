using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.SiteInterest;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface ISiteInterestService
    {
        bool Create(SiteInterest siteInterest);
        void CreateSiteInterest(SiteInterest siteInterest);
        IEnumerable<SiteInterest?> GetAll();
        SiteInterest? GetById(int siteInterest_Id);
        SiteInterest? Delete(int siteInterest_Id);
        SiteInterest? Update(int siteInterest_Id, string siteInterestType, string posLat, string posLong, string Description);
    }
}
