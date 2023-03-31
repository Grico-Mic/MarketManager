using System;

namespace MarketManager.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(RoleEnum roleEnum)
        {
            RoleEnum = Models.RoleEnum.Manager;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Enum RoleEnum { get; set; }

    }
}
