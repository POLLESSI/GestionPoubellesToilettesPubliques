﻿using GestionPoubellesToilttesPubliques2.DAL.Entities;
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
    public class NUserRepository : INUserRepository
    {
        private readonly SqlConnection _connection;

        public NUserRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Create(NUser nUser)
        {
            try
            {
                string sql = "INSERT INTO NUser (Email, Pwd, Person_Id, Role_Id) VALUES " +
                    "(@email, CONVERT(varbinary(64), @Pwd), @Person_Id, @Role_Id)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Email", nUser.Email);
                parameters.Add("@Pwd", nUser.Pwd);
                parameters.Add("@Person_Id", nUser.Person_Id);
                parameters.Add("@Role_Id", nUser.Role_Id);
                return _connection.Execute(sql, parameters) > 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error Encoding New User : {ex.ToString}");
            }
            return false;
        }

        public void CreateNUser(NUser nUser)
        {
            try
            {
                string sql = "INSERT INTO NUser (Email, Pwd, Person_Id, Role_Id) " +
                    "VALUES (@email, CONVERT(varbinary(64), @pwd), @person_Id, @role_Id)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@email", nUser.Email);
                parameters.Add("@pwd", nUser.Pwd);
                parameters.Add("@person_Id", nUser.Person_Id);
                parameters.Add("@role_Id", nUser.Role_Id);
                _connection.Query<NUser>(sql, parameters);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error Create New Person : {ex.ToString}");
            }
        }

        public NUser? Delete(Guid nUser_Id)
        {
            try
            {
                string sql = "DELETE FROM NUser WHERE NUser_Id = @nUser_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@nUser_Id", nUser_Id);
                return _connection.QueryFirst<NUser>(sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Erro deleting User : {ex.ToString}");
            }
            return null;
        }

        public IEnumerable<NUser?> GetAll()
        {
            string sql = "SELECT * FROM NUser";
            return _connection.Query<NUser?>(sql);
        }

        public NUser? GetById(Guid nUser_Id)
        {
            try
            {
                string sql = "SELECT * FROM NUser WHERE NUser_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@nUser_Id", nUser_Id);
                return _connection.QueryFirst<NUser?>(sql, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error geting User : {ex.ToString}");
            }
            return null;
        }

        public NUser? LoginNUser(string email, string pwd)
        {
            try
            {
                string sqlCheckPassword = "SELECT * FROM NUser WHERE Email = @email, Pwd = CONVERT(varbinary(64), @pwd)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@email", email);
                parameters.Add("@pwd", pwd);
                return _connection.QueryFirst<NUser?>(sqlCheckPassword, parameters);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Non-existent user : {ex.ToString}");
            }
            return null;
        }

        public bool RegisterNUser(string email, string pwd, int person_Id, string role_Id)
        {
            try
            {
                string sql = "INSERT INTO NUser (Email, Pwd, Person_Id, Role_Id) " +
                "VALUES (@email, CONVERT(varbinary(64), @pwd), @person_Id, @role_Id)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@email", email);
                parameters.Add("@pwd", pwd);
                parameters.Add("@person_Id", person_Id);
                parameters.Add("@role_Id", role_Id);
                return _connection.Execute(sql, parameters) > 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error Registrating New User : {ex.ToString}");

            }
            return false;
        }
        public NUser? Update(Guid nUser_id, string email, string pwd, int person_Id, string role_Id)
        {
            try
            {
                string sql = "UPDATE NUser SET Email = @email, Pwd = CONVERT(varbinary(64),@pwd), Person_Id = @person_Id WHERE NUser_Id = @nUser_Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@nUser_Id", nUser_id);
                parameters.Add("@email", email);
                parameters.Add("@person_Id", person_Id);
                parameters.Add("@role_Id", role_Id);
                return _connection.QueryFirst<NUser>(sql, parameters);
            }
            catch (System.ComponentModel.DataAnnotations.ValidationException ex)
            {

                Console.WriteLine($"Validation error : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating user : {ex}");
            }
            return new NUser();
        }
    }
}