using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Incivility;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IIncivilityService
    {
        bool Create(Incivility incivility);
        void CreateIncivility(Incivility incivility);
        IEnumerable<Incivility?> GetAll();
        Incivility? GetById(int incivility_Id);
        Incivility? Delete(int incivility_Id);
        Incivility? Update(int incivility_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool severe, bool absorbed);
    }
}
