using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Ashtray;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IAshtrayService
    {
        bool Create(Ashtray ashtray);
        void CreateAshtray(Ashtray ashtray);
        IEnumerable<Ashtray?> GetAll();
        Ashtray? GetById(int ashtray_Id);
        Ashtray? Delete(int ashtray_Id);
        Ashtray? Update(int ashtray_Id, string num_Mat, string posLat, string posLong, int addres_Id, bool isFull, bool degradation);
    }
}
