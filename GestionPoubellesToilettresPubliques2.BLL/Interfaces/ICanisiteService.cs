using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Canisite;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface ICanisiteService
    {
        bool Create(Canisite canisite);
        void CreateCanisite(Canisite canisite);
        IEnumerable<Canisite?> GetAll();
        Canisite? GetById(int canisite_Id);
        Canisite? Delete(int canisite_Id);
        Canisite? Update(int canisite_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation);
    }
}
