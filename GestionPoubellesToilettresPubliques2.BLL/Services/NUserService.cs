﻿using GestionPoubellesToilettresPubliques2.BLL.Interfaces;
using GestionPoubellesToilttesPubliques2.DAL.Entities;
using GestionPoubellesToilttesPubliques2.DAL.Interfaces;
using GestionPoubellesToilettresPubliques2.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Xml.Linq;

namespace GestionPoubellesToilettresPubliques2.BLL.Services
{
    public class NUserService : INUserService
    {
        private readonly INUserRepository _nUserRepository;

        public NUserService(INUserRepository nUserRepository)
        {
            _nUserRepository = nUserRepository;
        }

        public bool Create(NUser nUser)
        {
            try
            {
                return _nUserRepository.Create(nUser);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating new user : {ex.ToString}");
            }
            return false;
        }

        public void CreateNUser(NUser nUser)
        {
            try
            {
                _nUserRepository.CreateNUser(nUser);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error CreateNUser : {ex.ToString}");
            }
        }

        public NUser? Delete(Guid nUser_Id)
        {
            try
            {
                return _nUserRepository.Delete(nUser_Id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error deleting user : {ex.ToString}");
            }
            return null;
        }

        public IEnumerable<NUser?> GetAll()
        {
            return _nUserRepository.GetAll();
        }

        public NUser? GetById(Guid nUser_id)
        {
            try
            {
                return _nUserRepository.GetById(nUser_id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error geting user : {ex.ToString}");
            }
            return null;
        }

        public NUser? LoginNUser(string email, string pwd)
        {
            try
            {
                return _nUserRepository.LoginNUser(email, pwd);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error loging : {ex.ToString}");
            }
            return null;
        }

        public bool RegisterNUser(string email, string pwd, int person_Id, string role_Id)
        {
            try
            {
                _nUserRepository.RegisterNUser(email, pwd, person_Id, role_Id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error registrating new user : {ex.ToString}");
            }
            return false;
        }

        public NUser? Update(Guid nUser_Id, string email, string pwd, int person_Id, string role_Id)
        {
            try
            {
                var updateNUser = _nUserRepository.Update(nUser_Id, email, pwd, person_Id, role_Id);
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
