using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class PublicToiletService : IPublicToiletService
    {
        private readonly IPublicToiletRepository _publicToiletRepository;

        public PublicToiletService(IPublicToiletRepository publicToiletRepository)
        {
            _publicToiletRepository = publicToiletRepository;
        }

        public bool Create(PublicToilet publicToilet)
        {
            throw new NotImplementedException();
        }

        public void CreatePublicToilet(PublicToilet publicToilet)
        {
            throw new NotImplementedException();
        }

        public PublicToilet? Delete(int publicToilet_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PublicToilet?> GetAll()
        {
            throw new NotImplementedException();
        }

        public PublicToilet? GetById(int publicToilet_Id)
        {
            throw new NotImplementedException();
        }

        public PublicToilet? Update(int publicToilet_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation)
        {
            throw new NotImplementedException();
        }
    }
}
