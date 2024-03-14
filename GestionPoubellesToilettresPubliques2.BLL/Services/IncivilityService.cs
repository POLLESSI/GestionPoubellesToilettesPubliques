using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class IncivilityService : IIncivilityService
    {
        private readonly IIncivilityRepository _incivilityRepository;

        public IncivilityService(IIncivilityRepository incivilityRepository)
        {
            _incivilityRepository = incivilityRepository;
        }

        public bool Create(Incivility incivility)
        {
            throw new NotImplementedException();
        }

        public void CreateIncivility(Incivility incivility)
        {
            throw new NotImplementedException();
        }

        public Incivility? Delete(int incivility_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Incivility?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Incivility? GetById(int incivility_Id)
        {
            throw new NotImplementedException();
        }

        public Incivility? Update(int incivility_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool severe, bool absorbed)
        {
            throw new NotImplementedException();
        }
    }
}
