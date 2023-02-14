using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.View
{
    public class Display
    {
        public double Vegetables { get; set; }
        public double Fruits { get; set; }
        public double Weight { get; set; }
        public double Total { get; set; }
        public double CalVegetables { get; set; }
        public double CalFruits { get; set; }

        public Display()
        {
            Vegetables = 0;
                Fruits = 0;
            Weight = 0;
            Total = 0;
            CalVegetables = 0;
            CalFruits = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("Enter the gramage for the vegetables: ");
            Vegetables = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the gramage for the fruits: ");
            Fruits = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price per kilo: ");
            Weight = double.Parse(Console.ReadLine());
        }

        public void ShowBill()
        {
            Console.WriteLine("The price for the vegetables is {0:C}", Vegetables);
            Console.WriteLine("The price for the fruits is {0:C}", Fruits);
            Console.WriteLine("Your bill is {0:C}",Total);
        }
    }
}
