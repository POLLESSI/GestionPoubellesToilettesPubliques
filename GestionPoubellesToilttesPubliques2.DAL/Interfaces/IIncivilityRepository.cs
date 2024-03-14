using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Incivility;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IIncivilityRepository
    {
        bool Create(Incivility incivility);
        void CreateIncivility(Incivility incivility);
        IEnumerable<Incivility?> GetAll();
        Incivility? GetById(int incivility_Id);
        Incivility? Delete(int incivility_Id);
        Incivility? Update(int incivility_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool severe, bool absorbed);
    }
}
