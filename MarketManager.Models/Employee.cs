using System;

namespace MarketManager.Models
{
    public class Employee
    {
        
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public RoleEnum Role { get; set; }
    }
}
