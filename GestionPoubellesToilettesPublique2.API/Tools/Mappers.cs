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
                Evenement_Id = ch.Evenement_Id,
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
        public static Map MapToDal(this MapRegisterForm mrf)
        {
            return new Map
            {
                DateCreation = mrf.DateCreation,
                Description = mrf.Description,
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
        public static Addres AddresToDal(this AddresRegisterForm arf)
        {
            return new Addres
            {
                Rue = arf.Rue,
                Numero = arf.Numero,
                CP = arf.CP,
                Ville = arf.Ville,
                Pays = arf.Pays,
            };
        }
        public static Ashtray AshtrayToDal(this AshtrayRegisterForm achf) 
        {
            return new Ashtray
            {
                Num_Mat = achf.Num_Mat,
                PosLat = achf.PosLat,
                PosLong = achf.PosLong,
                Addres_Id = achf.Addres_Id,
                IsFull = achf.IsFull,
                Degradation = achf.Degradation,
            };
        }
        public static Bonus BonusToDal(this BonusRegisterForm brf)
        {
            return new Bonus
            {
                BonusType = brf.BonusType,
                BonusDescription = brf.BonusDescription,
                Application = brf.Application,
            };
        }
        public static Canisite CanisiteToDal(this CanisiteRegisterForm crf)
        {
            return new Canisite
            {
                Num_Mat = crf.Num_Mat,
                PosLat = crf.PosLat,
                PosLong = crf.PosLong,
                Addres_Id = crf.Addres_Id,
                IsFull = crf.IsFull,
                Degradation = crf.Degradation,
            };
        }
        public static Evenement EvenementToDal(this EvenementRegisterForm erf)
        {
            return new Evenement
            {
                EvenementName = erf.EvenementName,
                EvenementDescription = erf.EvenementDecription,
                PosLat = erf.PosLat,
                PosLong = erf.PosLong,
                positif = erf.Positif,
            };
        }
        public static GarbageCan GarbageCanToDal(this GarbageCanRegisterForm gcrf)
        {
            return new GarbageCan
            {
                Num_Mat = gcrf.Num_Mat,
                PosLat = gcrf.PosLat,
                PosLong = gcrf.PosLong,
                Addres_Id = gcrf.Addres_Id,
                IsFull = gcrf.IsFull,
                Degradation = gcrf.Degradation,
            };
        }
        public static Incivility IncivilityToDal(this IncivilityRegisterForm irf)
        {
            return new Incivility
            {
                Num_Mat = irf.Num_Mat,
                PosLat = irf.PosLat,
                PosLong = irf.PosLong,
                Addres_Id = irf.Addres_Id,
                Severe = irf.Severe,
                Absorbed = irf.absorbed,
            };
        }
        public static Monument MonumentToDal(this MonumentRegisterForm mrf)
        {
            return new Monument
            {
                MonumentName = mrf.MonumentName,
                PosLat = mrf.PosLat,
                PosLong = mrf.PosLong,
                Description = mrf.Description,
            };
        }
        public static PublicToilet PublicToiletToDal(this PublicToiletRegisterForm ptrf) 
        {
            return new PublicToilet
            {
                Num_Mat = ptrf.Num_Mat,
                PosLat = ptrf.PosLat,
                PosLong = ptrf.PosLong,
                Addres_Id = ptrf.Addres_Id,
                IsFull= ptrf.IsFull,
                Degradation = ptrf.Degradation,
            };
        } 
        public static Recompense RecompenseToDal(this RecompenseRegisterForm rrf) 
        {
            return new Recompense
            {
                Definition = rrf.Definition,
                Point = rrf.Point,
                Implication = rrf.Implacation
            };
        }
        public static SiteInterest SiteInterestToDal(this SiteInterestRegisterForm sirf)
        {
            return new SiteInterest
            {
                SiteInterestName = sirf.SiteInterestName,
                SiteInterestType = sirf.SiteInterestType,
                PosLat = sirf.PosLat,
                PosLong = sirf.PosLong,
                Description = sirf.Description,
            };
        }
    }
}
