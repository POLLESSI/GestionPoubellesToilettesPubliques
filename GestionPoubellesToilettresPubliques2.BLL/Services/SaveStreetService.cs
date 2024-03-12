using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class SaveStreetService : ISaveStreetService
    {
        private readonly ISaveStreetRepository _saveStreetRepository;

        public SaveStreetService(ISaveStreetRepository saveStreetRepository)
        {
            _saveStreetRepository = saveStreetRepository;
        }

        public bool Create(SaveStreet saveStreet)
        {
            try
            {
                return _saveStreetRepository.Create(saveStreet);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating scientific data : {ex.ToString}");
            }
            return false;
        }

        public void CreateSaveStreet(SaveStreet saveStreet)
        {
            try
            {
                _saveStreetRepository.CreateSaveStreet(saveStreet);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error Creation Save street : {ex.ToString}");
            }
        }

        public SaveStreet? Delete(int saveStreet_Id)
        {
            try
            {
                return _saveStreetRepository.Delete(saveStreet_Id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error deleting Save Street : {ex.ToString}");
            }
            return null;
        }

        public IEnumerable<SaveStreet?> GetAll()
        {
            return _saveStreetRepository.GetAll();
        }

        public SaveStreet? GetById(int saveStreet_Id)
        {
            try
            {
                return _saveStreetRepository.GetById(saveStreet_Id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error geting Save street : {ex.ToString}");
            }
            return null;
        }

        public SaveStreet? Update(int saveStreet_Id, string streetname, string startLatitude, string endLatitude, string startLongitude, string endLongitude, string securityScore)
        {
            try
            {
                var updateSaveStreet = _saveStreetRepository.Update(saveStreet_Id, streetname, startLatitude, endLatitude, startLongitude, endLongitude, securityScore);
                return updateSaveStreet;
            }
            catch (System.ComponentModel.DataAnnotations.ValidationException ex)
            {

                Console.WriteLine($"Validation error : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating Save Street : {ex}");
            }
            return new SaveStreet();
        }
    }
}
