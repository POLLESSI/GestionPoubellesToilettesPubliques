using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Map;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IMapService
    {
        bool Create(Map map);
        void CreateMap(Map map);
        IEnumerable<Map?> GetAll();
        Map? GetById(int map_Id);
        Map? Delete(int map_Id);
        Map? Update(int map_Id, DateTime dateCreation, string description);
    }
}
