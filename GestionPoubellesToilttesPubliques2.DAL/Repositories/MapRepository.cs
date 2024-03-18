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
    public class MapRepository : IMapRepository
    {
        private readonly SqlConnection _connection;

        public MapRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(Map map)
        {
            try
            {
                string sql = "INSERT INTO Map(DateCreation, Description) VALUES" +
                    "(@DateCreation, @Description)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@DateCreation", map.DateCreation);
                parameters.Add("@Description", map.Description);
                return _connection.Execute(sql, parameters) > 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating Map : {ex.ToString}");
            }
            return false;
        }
        public void CreateMap(Map map)
        {
            try
            {
                string sql = "INSERT INTO Map(DateCreation, Description)" +
                    "VALUES (@DateCreation, @Description)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@dateCreation", map.DateCreation);
                parameters.Add("@description", map.Description);
                _connection.Query<Map?>(sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating new Map : {ex.ToString}");
            }
        }
        public Map? Delete(int map_Id) 
        {
            try
            {
                string sql = "DELETE FROM Map WHERE Map_Id = @map_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@map_Id", map_Id);
                return _connection.QueryFirst<Map?>(sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error deleting Map : {ex.ToString}");
            }
            return null;
        }
        public IEnumerable<Map?> GetAll()
        {
            string sql = "SELECT * FROM Map";
            return _connection.Query<Map?>(sql);
        }
        public Map? GetById(int map_Id)
        {
            try
            {
                string sql = "SELECT * FROM Map WHERE Map_Id = @map_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@map_Id", map_Id);
                return _connection.QueryFirst<Map?>( sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error geting Map : {ex.ToString}");
            }
            return null;
        }
        public Map? Update(int map_Id, DateTime dateCreation, string description) 
        {
            try
            {
                string sql = "UPDATE Map SET DateCreation = @dateCreation, Description = @dateDescription WHERE Map_Id = @map_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@dateCreation", dateCreation);
                parameters.Add("description", description);
                return _connection.QueryFirst<Map?>(sql, parameters);
            }
            catch (System.ComponentModel.DataAnnotations.ValidationException ex)
            {

                Console.WriteLine($"Validation error : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Updating Map : {ex}");
            }
            return new Map();
        }
    }
}
