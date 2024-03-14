using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.PublicToilet;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IPublicToiletService
    {
        bool Create(PublicToilet publicToilet);
        void CreatePublicToilet(PublicToilet publicToilet);
        IEnumerable<PublicToilet?> GetAll();
        PublicToilet? GetById(int publicToilet_Id);
        PublicToilet? Delete(int publicToilet_Id);
        PublicToilet? Update(int publicToilet_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation);
    }
}
