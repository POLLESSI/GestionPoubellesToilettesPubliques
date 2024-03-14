using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Addres;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IAddresRepository
    {
        bool Create(Addres addres);
        void CreateAddres(Addres addres);
        IEnumerable<Addres?> GetAll();
        Addres? GetById(int addres_Id);
        Addres? Delete(int addres_Id);
        Addres? Update(int addres_Id, string rue, string numero, string cP, string ville, string pays);
    }
}
