﻿using MarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketManager.Servises
{
    public class MarketManagerServise
    {
        public MarketManagerServise()
        {
            _product = new List<Product>();
            _employers = new List<Employee>();
            _cashRegister = new List<CashRegister>();
        }

        private List<Product> _product { get; set; }
        private List<Employee> _employers { get; set; }
        private List<CashRegister> _cashRegister { get; set; }

        public void CreateManager()
        {
            Console.WriteLine("Please enter Id number");
            var userInputIdNumber = Console.ReadLine();
            var checkIdIfExist = CheckForIdExist(userInputIdNumber);
            if (checkIdIfExist == null)
            {
                Console.WriteLine("Please enter a name");
                var userInputName = Console.ReadLine();
                Console.WriteLine("Please enter a surname");
                var userInputSurname = Console.ReadLine();

                var manager = new Employee();
                manager.Id = userInputIdNumber;
                manager.Name = userInputName;
                manager.Surname = userInputSurname;
                manager.Role = RoleEnum.Manager;

                _employers.Add(manager);
            }
            else
            {
                Console.WriteLine($"Number with id number {checkIdIfExist.Id} alredy exist.");
            }
        }

        public void CreateEmployee()
        {

            Console.WriteLine("This operation can be handle ONLY by Manager!!!");
            Console.WriteLine("Please enter your Id");
            var userManagerId = Console.ReadLine();

            Employee manager = GetManager(userManagerId);

            if (manager != null)
            {
                Console.WriteLine("Please enter Id number");
                var userInputIdNumber = Console.ReadLine();

                var checkIdIfExist = CheckForIdExist(userInputIdNumber);
                if (checkIdIfExist != null )
                {
                    Console.WriteLine($"Id number {userInputIdNumber} alredy exist.");
                    return;
                }
              
                Console.WriteLine("Please enter a name");
                var userInputName = Console.ReadLine();
                Console.WriteLine("Please enter a surname");
                var userInputSurname = Console.ReadLine();

                var employers = new Employee();
                employers.Id = userInputIdNumber;
                employers.Name = userInputName;
                employers.Surname = userInputSurname;
                employers.Role = RoleEnum.Employee;

                _employers.Add(employers);
                return;
            }
            bool IsUneployded = IsUnemploye(userManagerId);
            if (IsUneployded)
            {
                Console.WriteLine($"Person with Id {userManagerId} does not exist.");
                return;
            }
            bool isManager = IsManager(userManagerId);
            if (isManager)
            {
                Console.WriteLine("To create employee the requestor must have manager role.");
                return;
            }
            
        }

        private Employee GetManager(string employeeId)
        {
            return _employers.FirstOrDefault(employee =>
                employee.Id == employeeId &&
                employee.Role == RoleEnum.Manager);
        }
        private Employee CheckForIdExist(string accountNumber)
        {
            return _employers.FirstOrDefault(x => x.Id == accountNumber);
        }
        private bool IsManager(string managerId)
        {
            var e = _employers.FirstOrDefault(e => e.Id == managerId && e.Role == RoleEnum.Manager);
            return e == null;
        }
        private bool IsUnemploye(string managerId)
        {
            var e = _employers.FirstOrDefault(e => e.Id == managerId);
            return e == null;
        }
    }

}
