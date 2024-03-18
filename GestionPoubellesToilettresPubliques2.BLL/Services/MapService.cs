using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class MapService : IMapService
    {
        private readonly IMapRepository _mapRepository;

        public MapService(IMapRepository mapRepository)
        {
            _mapRepository = mapRepository;
        }
        public bool Create(Map map)
        {
            try
            {
                return _mapRepository.Create(map);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating map : {ex.ToString}");
            }
            return false;
        }
        public void CreateMap(Map map)
        {
            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error CreateMap : {ex.ToString}");
            }
        }
        public Map? Delete(int map_Id)
        {
            try
            {
                return _mapRepository.Delete(map_Id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error deleting map : {ex.ToString}");
            }
            return null;
        }
        public IEnumerable<Map?> GetAll()
        {
            return _mapRepository.GetAll();
        }
        public Map? GetById(int map_Id)
        {
            try
            {
                return _mapRepository.GetById(map_Id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error geting map : {ex.ToString}");
            }
            return null;
        }
        public Map? Update(int map_Id, DateTime dateCreation, string description)
        {
            try
            {
                var updateMap = _mapRepository.Update(map_Id, dateCreation, description);
            }
            catch (System.ComponentModel.DataAnnotations.ValidationException ex)
            {

                Console.WriteLine($"Validation error : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating map : {ex}");
            }
            return new Map();
        }
    }
}
