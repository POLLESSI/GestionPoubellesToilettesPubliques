﻿
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class Recompense
    {
        public int Recompense_Id { get; set; }
        public string? Definition { get; set; }
        public string? Point { get; set; }
        public string? Implication { get; set; }
        public bool Active { get; set; }
    }
}