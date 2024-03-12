﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class NUserForm
    {
        [Required(ErrorMessage = "Email is required")]
        [MinLength(8)]
        [MaxLength(64)]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email : ")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "The Password is required")]
        [MinLength(8)]
        [MaxLength(64)]
        [DataType(DataType.Password)]
        [DisplayName("Password : ")]
        //[RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\-\.=+*@?]).*$", ErrorMessage = "The format is too simple for security.")]
        public string? Pwd { get; set; }
        [Required(ErrorMessage = "The Person's Id is required")]
        [DisplayName("Person's Id : ")]
        public int Person_Id { get; set; }
        [Required(ErrorMessage = "The rôle's Id is required")]
        [DisplayName("Rôle's Id : ")]
        public string? Role_Id { get; set; }
    }
}