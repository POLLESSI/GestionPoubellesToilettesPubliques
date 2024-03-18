﻿using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Recompense;

namespace GestionPoubellesToilettresPubliques2.BLL.Interfaces
{
    public interface IRecompenseService
    {
        bool Create(Recompense recompense);
        void CreateRecompense(Recompense recompense);
        IEnumerable<Recompense?> GetAll();
        Recompense? GetById(int recompense_Id);
        Recompense? Delete(int recompense_Id);
        Recompense? Update(int recompense_Id, string definition, string point, string implacation);
    }
}