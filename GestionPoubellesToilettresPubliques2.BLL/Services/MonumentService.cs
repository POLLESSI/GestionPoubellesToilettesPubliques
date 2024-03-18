using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class MonumentService : IMonumentService
    {
        private readonly IMonumentRepository _monumentRepository;

        public MonumentService(IMonumentRepository monumentRepository)
        {
            _monumentRepository = monumentRepository;
        }

        public bool Create(Monument monument)
        {
            throw new NotImplementedException();
        }

        public void CreateMonument(Monument monument)
        {
            throw new NotImplementedException();
        }

        public Monument? Delete(int monument_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Monument?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Monument? GetById(int monument_Id)
        {
            throw new NotImplementedException();
        }

        public Monument? Update(int monument_Id, string? description, string? posLat, string? posLong)
        {
            throw new NotImplementedException();
        }
    }
}
