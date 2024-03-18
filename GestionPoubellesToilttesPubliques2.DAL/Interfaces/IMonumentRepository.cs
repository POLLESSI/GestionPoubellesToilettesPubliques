using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Monument;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IMonumentRepository
    {
        bool Create(Monument monument);
        void CreateMonument(Monument monument);
        IEnumerable<Monument?> GetAll();
        Monument? GetById(int monument_Id);
        Monument? Delete(int monument_Id);
        Monument? Update(int monument_Id, string monumentName, string description, string posLat, string posLong);
    }
}
