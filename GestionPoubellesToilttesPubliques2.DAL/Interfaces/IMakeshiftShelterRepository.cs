using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.MakeshiftShelter;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IMakeshiftShelterRepository
    {
        bool Create(MakeshiftShelter makeshiftShelter);
        void CreateMakeshiftShelter(MakeshiftShelter makeshiftShelter);
        IEnumerable<MakeshiftShelter> GetAll();
        MakeshiftShelter? GetById(int makeshiftShelter_Id);
        MakeshiftShelter? Delete(int makeshiftShelter_Id);
        MakeshiftShelter? Update(int makeshiftShelter_Id, string latitude, string longitude, string description);
    }
}
