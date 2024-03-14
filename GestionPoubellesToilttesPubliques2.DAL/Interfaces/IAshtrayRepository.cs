using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Ashtray;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IAshtrayRepository
    {
        bool Create(Ashtray ashtray);
        void CreateAshtray(Ashtray ashtray);
        IEnumerable<Ashtray?> GetAll();
        Ashtray? GetById(int ashtray_Id);  
        Ashtray? Delete(int ashtray_Id);
        Ashtray? Update(int ashTray_Id, string? num_Mat, string? posLat, string? posLong, int addres_Id, bool isFull, bool degradation);
    }
}
