using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionPoubellesToilttesPubliques2.DAL.Repositories
{
    public class AddresRepository : IAddresRepository
    {
        private readonly SqlConnection _connection;

        public AddresRepository(SqlConnection connection)
        {
            _connection = connection;
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
