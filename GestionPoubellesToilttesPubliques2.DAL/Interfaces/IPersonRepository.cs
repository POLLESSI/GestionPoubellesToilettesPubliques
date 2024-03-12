using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Person;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IPersonRepository
    {
        bool Create(Person person);
        void CreatePerson(Person person);
        IEnumerable<Person?> GetAll();
        Person? GetById(int person_Id);
        Person? Delete(int person_Id);
        Person? Update(int person_id, string lastname, string firstname, string email, string address_Street, string address_Nbr, string postalCode, string address_City, string address_Country, string telephone, string gsm);
    }
}
