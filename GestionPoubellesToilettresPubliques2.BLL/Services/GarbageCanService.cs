using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class GarbageCanService : IGarbageCanService
    {
        private readonly IGarbageCanRepository _garbageCanRepository;

        public GarbageCanService(IGarbageCanRepository garbageCanRepository)
        {
            _garbageCanRepository = garbageCanRepository;
        }

        public bool Create(GarbageCan garbageCan)
        {
            throw new NotImplementedException();
        }

        public void CreateSaveStreet(GarbageCan garbageCan)
        {
            throw new NotImplementedException();
        }

        public GarbageCan? Delete(int garbageCan_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GarbageCan?> GetAll()
        {
            throw new NotImplementedException();
        }

        public GarbageCan? GetById(int garbageCan_Id)
        {
            throw new NotImplementedException();
        }

        public GarbageCan? Update(int garbageCan_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation)
        {
            throw new NotImplementedException();
        }
    }
}
