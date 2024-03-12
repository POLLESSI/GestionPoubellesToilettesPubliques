using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.SaveStreet;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface ISaveStreetRepository
    {
        bool Create(SaveStreet saveStreet);
        void CreateSaveStreet(SaveStreet saveStreet);
        IEnumerable<SaveStreet?> GetAll();
        SaveStreet? GetById(int saveStreet_Id);
        SaveStreet? Delete(int saveStreet_Id);
        SaveStreet? Update(int  saveStreet_Id, string streetName, string startLatitude, string endLatitude, string startLongitude, string endLongitude, string securityScore);
    }
}
