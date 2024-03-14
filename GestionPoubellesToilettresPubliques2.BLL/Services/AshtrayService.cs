using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class AshtrayService : IAshtrayService
    {
        private readonly IAshtrayRepository _ashtrayRepository;

        public AshtrayService(IAshtrayRepository ashtrayRepository)
        {
            _ashtrayRepository = ashtrayRepository;
        }

        public bool Create(Ashtray ashtray)
        {
            throw new NotImplementedException();
        }

        public void CreateAshtray(Ashtray ashtray)
        {
            throw new NotImplementedException();
        }

        public Ashtray? Delete(int ashtray_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ashtray?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ashtray? GetById(int ashtray_Id)
        {
            throw new NotImplementedException();
        }

        public Ashtray? Update(int ashtray_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation)
        {
            throw new NotImplementedException();
        }
    }
}
