using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionPoubellesToilttesPubliques2.DAL.Repositories
{
    public class MakeshiftShelterRepository : IMakeshiftShelterRepository
    {
        private readonly SqlConnection _connection;

        public MakeshiftShelterRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(MakeshiftShelter makeshiftShelter)
        {
            try
            {
                string sql = "INSERT INTO MakeshiftSchelter (Latitude, Longitude, Description) VALUES" +
                    "(@Latitude, @Longitude, @Description)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Latitude", makeshiftShelter.Latitude);
                parameters.Add("@Longitude", makeshiftShelter.Longitude);
                parameters.Add("@Description", makeshiftShelter.Description);
                return _connection.Execute(sql, parameters) > 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error encoding new makeshift Schelter : {ex.ToString}");
            }
            return false;
        }

        public void CreateMakeshiftShelter(MakeshiftShelter makeshiftShelter)
        {
            try
            {
                string sql = "INSERT INTO MakeshiftSchelter (Latitude, Longitude, Description)" +
                    "VALUES (@latitude, @longitude, @description)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@latitude", makeshiftShelter.Latitude);
                parameters.Add("@longitude", makeshiftShelter.Longitude);
                parameters.Add("@description", makeshiftShelter.Description);
                _connection.Query<MakeshiftShelter?>(sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating new Makeshift Schelter : {ex.ToString}");
            }
        }

        public MakeshiftShelter? Delete(int makeshiftShelter_Id)
        {
            try
            {
                string sql = "DELETE FROM MakeshiftSchelter WHERE MakeshiftSchelter_Id = @makeshiftSchelter_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@makeshiftSchelter_Id", makeshiftShelter_Id);
                return _connection.QueryFirst<MakeshiftShelter?>(sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error deleting Makeshift Schelter : {ex.ToString}");
            }
            return null;
        }

        public IEnumerable<MakeshiftShelter> GetAll()
        {
            string sql = "SELECT * FROM MakeshiftSchelter";
            return _connection.Query<MakeshiftShelter?>(sql);
        }

        public MakeshiftShelter? GetById(int makeshiftShelter_Id)
        {
            try
            {
                string sql = "SELECT * FROM MakeshiftSchelter WHERE MakeshiftSchelter_Id = @makeshiftSchelter_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@makeshiftSchelter_Id", makeshiftShelter_Id);
                return _connection.QueryFirst<MakeshiftShelter?>(sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error geting Makeshift Schelter : {ex.ToString}");
            }
            return null;
        }

        public MakeshiftShelter? Update(int makeshiftShelter_Id, string latitude, string longitude, string description)
        {
            try
            {
                string sql = "UPDATE MakeshiftSchelter SET Latitude = @latitude, Longitude = @longitude, Description = @description WHERE MakeshiftSchelter_Id = @makeshiftSchelter";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@latitude", latitude);
                parameters.Add("@longitude", longitude);
                parameters.Add("@description", description);
                return _connection.QueryFirst<MakeshiftShelter?>(sql, parameters);
            }
            catch (System.ComponentModel.DataAnnotations.ValidationException ex)
            {

                Console.WriteLine($"Validation error : {ex.Message}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error updating Makeshift Schelter : {ex}");
            }
            return new MakeshiftShelter();
        }
    }
}
