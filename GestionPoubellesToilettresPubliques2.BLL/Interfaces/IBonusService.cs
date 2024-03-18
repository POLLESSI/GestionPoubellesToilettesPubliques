using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Bonus;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IBonusService
    {
        bool Create(Bonus bonus);
        void CreateBonus(Bonus bonus);
        IEnumerable<Bonus?> GetAll();
        Bonus? GetById(int bonus_Id);
        Bonus? Delete(int bonus_Id);
        Bonus? Update(int bonus_Id, string bonusType, string bonusDescription, string application);
    }
}
