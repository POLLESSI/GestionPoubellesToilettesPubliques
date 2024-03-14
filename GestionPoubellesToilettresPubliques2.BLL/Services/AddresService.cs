using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class AddresService : IAddresService
    {
        private readonly IAddresRepository _addresRepository;

        public AddresService(IAddresRepository addresRepository)
        {
            _addresRepository = addresRepository;
        }

        public bool Create(Addres addres)
        {
            throw new NotImplementedException();
        }

        public void CreateAddres(Addres addres)
        {
            throw new NotImplementedException();
        }

        public Addres? Delete(int addres_Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Addres?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Addres? GetById(int addres_Id)
        {
            throw new NotImplementedException();
        }

        public Addres? Update(int addres_Id, string rue, string numero, string cP, string ville, string pays)
        {
            throw new NotImplementedException();
        }
    }
}
