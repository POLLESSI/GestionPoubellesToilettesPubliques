using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Canisite;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface ICanisiteRepository
    {
        bool Create(Canisite canisite);
        void createCanisite(Canisite canisite);
        IEnumerable<Canisite?> GetAll();
        Canisite? GetById(int canisite_Id);
        Canisite? Delete(int  canisite_Id);
        Canisite? Update(int canisite_Id, string? num_Mat, string? posLat, string? posLong, int addres_Id, bool isFull, bool degradation);
    }
}
