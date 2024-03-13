 using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class MakeshiftSchelterService : IMakeshiftSchelterService
    {
        private readonly IMakeshiftShelterRepository _makeshiftShelterRepository;

        public MakeshiftSchelterService(IMakeshiftShelterRepository makeshiftShelterRepository)
        {
            _makeshiftShelterRepository = makeshiftShelterRepository;
        }

        public bool Create(MakeshiftShelter makeshiftShelter)
        {
            try
            {
                return _makeshiftShelterRepository.Create(makeshiftShelter);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating makeshift shelter : {ex.ToString}");
            }
            return false;
        }

        public void CreateMakeshiftSchelter(MakeshiftShelter makeshiftShelter)
        {
            try
            {
                _makeshiftShelterRepository.CreateMakeshiftShelter(makeshiftShelter);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error Creation makeshift shelter : {ex.ToString}");
            }
        }

        public MakeshiftShelter Delete(int makeshiftShelter_Id)
        {
            try
            {
                return _makeshiftShelterRepository.Delete(makeshiftShelter_Id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error deleting Makeshift shelter : {ex.ToString}");
            }
            return null;
        }

        public IEnumerable<MakeshiftShelter> GetAll()
        {
            return _makeshiftShelterRepository.GetAll();
        }

        public MakeshiftShelter? GetbyId(int makeshiftShelter_Id)
        {
            try
            {
                return _makeshiftShelterRepository.GetById(makeshiftShelter_Id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error geting makeshift shelter : {ex.ToString}");
            }
            return null;
        }

        public MakeshiftShelter? Update(int makeshiftShelter_Id, string latitude, string longitude, string description)
        {
            try
            {
                var updateMakeshiftShelter = _makeshiftShelterRepository.Update(makeshiftShelter_Id, latitude, longitude, description);
            }
            catch (System.ComponentModel.DataAnnotations.ValidationException ex)
            {

                Console.WriteLine($"Validation error : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating Makeshift Shelter : {ex}");
            }
            return new MakeshiftShelter();
        }
    }
}
