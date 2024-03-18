using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class RecompenseService : IRecompenseService
    {
        private readonly IRecompenseRepository _recompnseRepository;

        public RecompenseService(IRecompenseRepository recompnseRepository)
        {
            _recompnseRepository = recompnseRepository;
        }

        public bool Create(Recompense recompense)
        {
            throw new NotImplementedException();
        }

        public void CreateRecompense(Recompense recompense)
        {
            throw new NotImplementedException();
        }

        public Recompense? Delete(int recompense_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recompense?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Recompense? GetById(int recompense_Id)
        {
            throw new NotImplementedException();
        }

        public Recompense? Update(int recompense_Id, string definition, string point, string implacation)
        {
            throw new NotImplementedException();
        }
    }
}
