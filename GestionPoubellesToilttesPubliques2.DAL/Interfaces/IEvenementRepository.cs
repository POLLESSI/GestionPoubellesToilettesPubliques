using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Evenement;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IEvenementRepository
    {
        bool Create(Evenement evenement);
        void CreateEvenement(Evenement evenement);
        IEnumerable<Evenement?> GetAll();
        Evenement? GetById(int evenement_Id);
        Evenement? Delete(int evenement_Id);
        Evenement? Update(int evenement_Id, DateTime evenementDate, string evenementDescription, string posLat, string posLong, bool positif);
    }
}
