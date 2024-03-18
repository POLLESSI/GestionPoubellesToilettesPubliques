using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionPoubellesToilttesPubliques2.DAL.Repositories
{
    public class RecompenseRepository : IRecompenseRepository
    {
        private readonly SqlConnection _connection;

        public RecompenseRepository(SqlConnection connection)
        {
            _connection = connection;
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

        public Recompense? Update(int recompense_Id, string definition, string point, string implication)
        {
            throw new NotImplementedException();
        }
    }
}
