using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class CanisiteService : ICanisiteService
    {
        private readonly ICanisiteRepository _canisiteRepository;

        public CanisiteService(ICanisiteRepository canisiteRepository)
        {
            _canisiteRepository = canisiteRepository;
        }

        public bool Create(Canisite canisite)
        {
            throw new NotImplementedException();
        }

        public void CreateCanisite(Canisite canisite)
        {
            throw new NotImplementedException();
        }

        public Canisite? delete(int canisite_Id)
        {
            throw new NotImplementedException();
        }

        public Canisite? Delete(int canisite_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Canisite?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Canisite? GetById(int canisite_Id)
        {
            throw new NotImplementedException();
        }

        public Canisite? Update(int canisite_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation)
        {
            throw new NotImplementedException();
        }
    }
}
