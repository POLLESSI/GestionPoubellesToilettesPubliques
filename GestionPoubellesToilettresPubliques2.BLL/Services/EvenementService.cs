using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class EvenementService : IEvenementService
    {
        private readonly IEvenementRepository _evenementRepository;

        public EvenementService(IEvenementRepository evenementRepository)
        {
            _evenementRepository = evenementRepository;
        }

        public bool Create(Evenement evenement)
        {
            throw new NotImplementedException();
        }

        public void CreateEvenement(Evenement evenement)
        {
            throw new NotImplementedException();
        }

        public Evenement? Delete(int evenement_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evenement?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Evenement? GetById(int evenement_Id)
        {
            throw new NotImplementedException();
        }

        public Evenement? Update(int evenement_Id, string evenementName, string evenementDescription, string posLat, string posLong, bool positif)
        {
            throw new NotImplementedException();
        }
    }
}
