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
    public class BonusRepository : IBonusRepository
    {
        private readonly SqlConnection _connection;

        public BonusRepository(SqlConnection connection)
        {
            _connection = connection;
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
