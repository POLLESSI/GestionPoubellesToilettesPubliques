using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.PublicToilet;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IPublicToiletRepository
    {
        bool Create(PublicToilet publicToilet);
        void CreatePublicToilet(PublicToilet publicToilet);
        IEnumerable<PublicToilet?> GetAll();
        PublicToilet? GetById(int publicToilet_Id);
        PublicToilet? Delete(int publicToilet_Id);
        PublicToilet? Update(int publicToilet_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation);
    }
}
