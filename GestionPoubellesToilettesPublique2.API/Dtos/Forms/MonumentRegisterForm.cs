﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class MonumentRegisterForm
    {
        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        [DisplayName("Monument name : ")]
        public string? MonumentName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(128)]
        [DisplayName("Description : ")]
        public string? Description { get; set; }
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
    }
}