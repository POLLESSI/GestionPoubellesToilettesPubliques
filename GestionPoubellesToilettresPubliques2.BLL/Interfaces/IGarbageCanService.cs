using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.GarbageCan;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IGarbageCanService
    {
        bool Create(GarbageCan garbageCan);
        void CreateSaveStreet(GarbageCan garbageCan);
        IEnumerable<GarbageCan?> GetAll();
        GarbageCan? GetById(int garbageCan_Id);
        GarbageCan? Delete(int garbageCan_Id);
        GarbageCan? Update(int garbageCan_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation);
    }
}
