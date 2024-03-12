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
    public class SaveStreetRepository : ISaveStreetRepository
    {
        private readonly SqlConnection _connection;

        public SaveStreetRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(SaveStreet saveStreet)
        {
            try
            {
                string sql = "INSERT INTO SaveStreet (StreetName, StartLatitude, EndLatitude, StartLongitude, EndLongitude, SecurityScore) VALUES" +
                    "(@StreetName, @StartLatitude, @EndLatitude, @StartLongitude, @EndLongitude, @SecurityScore)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@StreetName", saveStreet.StreetName);
                parameters.Add("@StartLatitude", saveStreet.StartLatitude);
                parameters.Add("@EndLatitude", saveStreet.EndLatitude);
                parameters.Add("@StartLongitude", saveStreet.StartLongitude);
                parameters.Add("@EndLongitude", saveStreet.EndLongitude);
                parameters.Add("@SecurityScore", saveStreet.SecurityScore);
                return _connection.Execute(sql, parameters) > 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error encoding New Person : {ex.ToString}");
            }
            return false;
        }

        public void CreateSaveStreet(SaveStreet saveStreet)
        {
            try
            {
                string sql = "INSERT INTO SaveStreet (StreetName, StartLatitude, EndLatitude, StartLongitude, EndLongitude, SecurityScore)" +
                    "VALUES (@streetName, @startLatitude, @endLatitude, @startLongitude, @endLongitude, @securityScore)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@streetName", saveStreet.StreetName);
                parameters.Add("@startLatitude", saveStreet.StartLatitude);
                parameters.Add("@endLatitude", saveStreet.EndLatitude);
                parameters.Add("@startLongitude", saveStreet.StartLongitude);
                parameters.Add("@endLongitude", saveStreet.EndLongitude);
                parameters.Add("@securityScore", saveStreet.SecurityScore);
                _connection.Query<SaveStreet?>(sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating New Save Street : {ex.ToString}");
            }
        }

        public SaveStreet? Delete(int saveStreet_Id)
        {
            try
            {
                string sql = "DELETE FROM SaveStreet WHERE SaveStreet_Id = @saveStreet_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@saveStreet_Id", saveStreet_Id);
                return _connection.QueryFirst<SaveStreet?>(sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error deleting Save Street : {ex.ToString}");
            }
            return null;
        }

        public IEnumerable<SaveStreet?> GetAll()
        {
            string sql = "SELECT * FROM SaveStreet";
            return _connection.Query<SaveStreet?>(sql);
        }

        public SaveStreet? GetById(int saveStreet_Id)
        {
            try
            {
                string sql = "SELECT * FROM SaveStreet WHERE SaveStreet_Id = @saveStreet_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@saveStreet_Id", saveStreet_Id);
                return _connection.QueryFirst<SaveStreet?>(sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error geting Save Street : {ex.ToString}");
            }
            return null;
        }

        public SaveStreet? Update(int saveStreet_Id, string streetName, string startLatitude, string endLatitude, string startLongitude, string endLongitude, string securityScore)
        {
            try
            {
                string sql = "UPDATE SaveStreet SET StreetName = @streetName, StartLatitude = @startLatitude, EndLatitude = @endLatitude, StartLongitude = @startLongitude, EndLongitude = @endLongitude, SecurityScore = @securityScore WHERE SaveStreet_Id = @saveStreet_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@saveStreet_Id", saveStreet_Id);
                parameters.Add("@streetName", streetName);
                parameters.Add("@startLatitude", startLatitude);
                parameters.Add("@endLatitude", endLatitude);
                parameters.Add("@startLongitude", startLongitude);
                parameters.Add("@securityScore", securityScore);
                return _connection.QueryFirst<SaveStreet?>(sql, parameters);
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
