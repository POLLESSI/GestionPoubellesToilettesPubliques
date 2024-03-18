using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class BonusService : IBonusService
    {
        private readonly IBonusRepository _bonusRepository;

        public BonusService(IBonusRepository bonusRepository)
        {
            _bonusRepository = bonusRepository;
        }

        public bool Create(Bonus bonus)
        {
            throw new NotImplementedException();
        }

        public void CreateBonus(Bonus bonus)
        {
            throw new NotImplementedException();
        }

        public Bonus? Delete(int bonus_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bonus?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Bonus? GetById(int bonus_Id)
        {
            throw new NotImplementedException();
        }

        public Bonus? Update(int bonus_Id, string bonusType, string bonusDescription, string application)
        {
            throw new NotImplementedException();
        }
    }
}
