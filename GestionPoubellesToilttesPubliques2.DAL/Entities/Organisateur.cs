﻿
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class Organisateur
    {
        public int Organisateur_Id { get; set; }
        public string? CompanyName { get; set; }
        public string? BusinessNumber { get; set; }
        public int NUser_Id { get; set; }
        public bool Active { get; set; }
    }
}
