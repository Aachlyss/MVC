using ConsoleApp1.Model;
using ConsoleApp1.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Controllers
{
    public class StocksCalculatorController
    {
        private Stocks stock;
        private Display display;

        public StocksCalculatorController()
        {
            display = new Display();
            stock = new Stocks(display.Vegetables, display.Fruits, display.Weight);
            display.Weight = stock.CalculateFruits();
            display.Weight = stock.CalculateVegetables();
            display.Total = stock.CalculateTotal();
            display.ShowBill();
        }
    }
}
