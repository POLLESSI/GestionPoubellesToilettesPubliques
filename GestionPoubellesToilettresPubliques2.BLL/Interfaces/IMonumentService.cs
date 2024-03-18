using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Monument;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IMonumentService
    {
        bool Create(Monument monument);
        void CreateMonument(Monument monument);
        IEnumerable<Monument?> GetAll();
        Monument? GetById(int monument_Id);
        Monument? Delete(int monument_Id);
        Monument? Update(int monument_Id, string? description, string? posLat, string? posLong);
    }
}
