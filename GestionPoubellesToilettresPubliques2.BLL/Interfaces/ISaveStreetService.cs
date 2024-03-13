using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.SaveStreet;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface ISaveStreetService
    {
        bool Create(SaveStreet saveStreet);
        void CreateSaveStreet(SaveStreet saveStreet);
        IEnumerable<SaveStreet?> GetAll();
        SaveStreet? GetById(int saveStreet_Id);
        SaveStreet? Delete(int saveStreet_Id);
        SaveStreet? Update(int saveStreet_Id, string streetname, string startLatitude, string endLatitude, string startLongitude, string endLongitude, string securityScore);
    }
}
