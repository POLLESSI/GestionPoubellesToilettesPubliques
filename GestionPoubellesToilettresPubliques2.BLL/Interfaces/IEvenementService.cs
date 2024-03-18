using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Evenement;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IEvenementService
    {
        bool Create(Evenement evenement);
        void CreateEvenement(Evenement evenement);
        IEnumerable<Evenement?> GetAll();
        Evenement? GetById(int evenement_Id);
        Evenement? Delete(int evenement_Id);
        Evenement? Update(int evenement_Id, string evenementName, string evenementDescription, string posLat, string posLong, bool positif);
    }
}
