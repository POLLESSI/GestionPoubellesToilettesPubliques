﻿namespace GestionPoubellesToilettesPublique2.API.Dtos
{
    public class OrganisateurDTO
    {
        public string? CompanyName { get; set; }
        public string? BusinessNumber { get; set; }
        public Guid NUser_Id { get; set; }
        public bool Active { get; set; }
    }
}
