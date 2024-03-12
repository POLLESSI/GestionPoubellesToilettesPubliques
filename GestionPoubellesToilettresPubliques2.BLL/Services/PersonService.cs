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
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public bool Create(Person person)
        {
            try
            {
                return _personRepository.Create(person);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating new person : {ex.ToString}");
            }
            return false;
        }

        public void CreatePerson(Person person)
        {
            try
            {
                _personRepository.CreatePerson(person);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error CreatePerson : {ex.ToString}");
            }
        }

        public Person? Delete(int person_Id)
        {
            try
            {
                return _personRepository.Delete(person_Id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error deleting person : {ex.ToString}");
            }
            return null;
        }

        public IEnumerable<Person?> GetAll()
        {
            return _personRepository.GetAll();
        }

        public Person? GetById(int person_Id)
        {
            try
            {
                return _personRepository.GetById(person_Id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error geting person : {ex.ToString}");
            }
            return null;
        }

        public Person? Update(int person_Id, string lastname, string firstname, string email, string address_Street, string address_Nbr, string postalCode, string address_City, string address_Country, string telephone, string gsm)
        {
            try
            {
                var updateNPerson = _personRepository.Update(person_Id, lastname, firstname, email, address_Street, address_Nbr, postalCode, address_City, address_Country, telephone, gsm);
            }
            catch (System.ComponentModel.DataAnnotations.ValidationException ex)
            {

                Console.WriteLine($"Validation error: {ex.Message}");
            }
            catch ( Exception ex )
            {
                Console.WriteLine($"Error updating person : {ex.Message}");
            }
            return new Person();
        }
    }
}
