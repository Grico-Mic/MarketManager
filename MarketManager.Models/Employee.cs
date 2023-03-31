using System;

namespace MarketManager.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Enum RoleEnum { get; set; }

    }
}
