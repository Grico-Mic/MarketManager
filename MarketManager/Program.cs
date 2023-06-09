﻿using MarketManager.Servises;
using System;

namespace MarketManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("    WELCOME TO OUR MARKET");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please choose one of options below");

            var servise = new MarketManagerServise();
            var shouldContinue = "";
            do
            {
                Console.WriteLine("1.Buy product");
                Console.WriteLine("2.Manage employeers");
                Console.WriteLine("3.Manage products");
                Console.WriteLine("4.Manage cash regiser");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("I will buy some products");
                        break;
                    case "2":
                        ManageEmpoyeers(servise);
                        break;
                    case "3":
                        ManageProducts(servise);
                        break;
                    case "4":
                        ManageCashRegister();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                Console.WriteLine("Do you want to continue?Enter no for exit");
                shouldContinue = Console.ReadLine().Trim().ToLower();
            } while (shouldContinue != "no");


        }

        private static void ManageCashRegister()
        {
            Console.WriteLine("Please choose one of options below:");
            Console.WriteLine("1.Create CashRegister");
            Console.WriteLine("2.Delete CashRegister");


            var userInputManageCashRegister = Console.ReadLine().Trim();
            switch (userInputManageCashRegister)
            {
                case "1":
                    Console.WriteLine("1.I will create cash register");
                    break;
                case "2":
                    Console.WriteLine("2.I will delete cash register");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        private static void ManageProducts(MarketManagerServise marketManagerServise)
        {
            Console.WriteLine("Please choose one of options below:");
            Console.WriteLine("1.Create Product");
            Console.WriteLine("2.Delete Product");


            var userInputManageProducts = Console.ReadLine().Trim().ToLower();
            switch (userInputManageProducts)
            {
                case "1":
                    marketManagerServise.CreateProduct();
                    break;
                case "2":
                    marketManagerServise.DeleteProduct();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        private static void ManageEmpoyeers(MarketManagerServise marketManagerServise)
        {
            Console.WriteLine("Please choose one of options below:");
            Console.WriteLine("1.Create Manager");
            Console.WriteLine("2.Create Employer");
            Console.WriteLine("3.Delete Employer");

            var userInputManageEmployer = Console.ReadLine().Trim().ToLower();
            switch (userInputManageEmployer)
            {
                case "1":
                    marketManagerServise.CreateManager();
                    break;
                case "2":
                    marketManagerServise.CreateEmployee();
                    break;
                case "3":
                    marketManagerServise.DeleteEmployee();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
