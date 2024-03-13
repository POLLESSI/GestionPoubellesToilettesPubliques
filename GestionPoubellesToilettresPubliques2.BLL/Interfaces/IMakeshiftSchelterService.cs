using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.MakeshiftShelter;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IMakeshiftSchelterService
    {
        bool Create(MakeshiftShelter makeshiftShelter);
        void CreateMakeshiftSchelter(MakeshiftShelter makeshiftShelter);
        IEnumerable<MakeshiftShelter> GetAll();
        MakeshiftShelter? GetbyId(int makeshiftShelter_Id);
        MakeshiftShelter Delete(int makeshiftShelter_Id);
        MakeshiftShelter? Update(int  makeshiftShelter_Id, string latitude, string longitude, string description);
    }
}
