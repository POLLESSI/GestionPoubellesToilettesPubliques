using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Bonus;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IBonusRepository
    {
        bool Create(Bonus bonus);
        void CreateBonus(Bonus bonus);
        IEnumerable<Bonus?> GetAll();
        Bonus? GetById(int bonus_Id);
        Bonus? Delete(int bonus_Id);
        Bonus? Update(int bonus_Id, string bonusType, string bonusDescription, string application);
    }
}
