using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Recompense;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IRecompenseRepository
    {
        bool Create(Recompense recompense);
        void CreateRecompense(Recompense recompense);
        IEnumerable<Recompense?> GetAll();
        Recompense? GetById(int recompense_Id);
        Recompense? Delete(int recompense_Id);
        Recompense? Update(int recompense_Id, string definition, string point, string implication);
    }
}
