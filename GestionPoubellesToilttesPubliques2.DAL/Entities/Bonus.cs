﻿
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class Bonus
    {
        public int Bonus_Id { get; set; }
        public string? BonusType { get; set; }
        public string? BonusDescription { get; set; } 
        public string? Application { get; set; }
        public bool Active { get; set; }
    }
}
