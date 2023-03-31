using MarketManager.Models;
using System;
using System.Collections.Generic;

namespace MarketManager.Servises
{
    public class MarketManagerServise
    {
        public MarketManagerServise()
        {
            _product = new Product();
            _employee = new Employee();
            _cashRegister = new CashRegister();
        }

        private Product _product { get; set; }
        private Employee _employee { get; set; }
        private CashRegister _cashRegister { get; set; }
    }
}
