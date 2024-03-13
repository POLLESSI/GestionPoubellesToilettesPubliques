using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilettesPublique2.API.Dtos.Forms;
using GestionPoubellesToilettesPublique2.API.Models;

namespace GestionPoubellesToilettesPublique2.API.Tools
{
    public static class Mappers
    {
        public static Chat ChatToDal(this Message ch)
        {
            return new Chat
            {
                NewMessage = ch.NewMessage,
                Author = ch.Author,
            };
        }
        public static Person PersonToDal(this PersonForm np)
        {
            return new Person
            {
                Lastname = np.Lastname,
                Firstname = np.Firstname,
                Email = np.Email,
                Address_Street = np.Address_Street,
                Address_Nbr = np.Address_Nbr,
                PostalCode = np.PostalCode,
                Address_City = np.Address_City,
                Address_Country = np.Address_Country,
                Telephone = np.Telephone,
                Gsm = np.Gsm,
            };
        } 
        public static NUser NUserToDal(this NUserForm nu)
        {
            return new NUser
            {
                Email = nu.Email,
                Pwd = nu.Pwd,
                Person_Id = nu.Person_Id,
            };
        }
        public static SaveStreet SaveStreetToDal(this SaveStreetRegisterForm sst)
        {
            return new SaveStreet
            {
                StreetName = sst.StreetName,
                StartLatitude = sst.StartLatitude,
                EndLatitude = sst.EndLatitude,
                StartLongitude = sst.StartLongitude,
                EndLongitude = sst.EndLongitude,
                SecurityScore = sst.SecutityScore
            };
        }
        public static MakeshiftShelter MakeshiftSchelterToDal(this MakeshiftShelterRegisterForm mss)
        {
            return new MakeshiftShelter
            {
                Latitude = mss.Latitude,
                Longitude = mss.Longitude,
                Description = mss.Description,
            };
        }
    }
}
