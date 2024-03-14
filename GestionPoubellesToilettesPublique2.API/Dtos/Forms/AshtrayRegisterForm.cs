﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class AshtrayRegisterForm
    {
        [Required]
        [DisplayName("Numero mat : ")]
        public string? Num_Mat { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("Latitude : ")]
        public string? PosLat { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(9)]
        [DisplayName("Longitude : ")]
        public string? PosLong { get; set; }
        [Required]
        [DisplayName("Address id : ")]
        public int Addres_Id { get; set; }
        [Required]
        [DisplayName("C'est plein ? : ")]
        public bool IsFull { get; set; }
        [Required]
        [DisplayName("Degradation ? : ")]
        public bool Degradation { get; set; }

    }
}