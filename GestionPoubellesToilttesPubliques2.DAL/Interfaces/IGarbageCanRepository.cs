using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.GarbageCan;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IGarbageCanRepository
    {
        bool Create(GarbageCan garbageCan);
        void CreateGarbageCan(GarbageCan garbageCan);
        IEnumerable<GarbageCan?> GetAll();
        GarbageCan? GetById(int garbageCan_Id);
        GarbageCan? Delete(int garbageCan_Id);
        GarbageCan? Update(int garbageCan_Id, string? num_Mat, string? posLat, string? posLong, int addres_Id, bool isFull, bool degradation);
    }
}
