using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{
    class Display
    {
        public Display()
        {
            this.DistanceKM = 0;
            this.TimeOfDay = "";
            this.TotalPrice = 0;
            this.GetValues();
        }

        public double DistanceKM { get; set; }
        public string TimeOfDay { get; set; }
        public double TotalPrice { get; set; }
        public void GetValues()
        {
            Console.WriteLine("Enter distance in KM: ");
            this.DistanceKM = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter time of the day: ");
            this.TimeOfDay = Console.ReadLine();
        }

        public void ShowPrice()
        {
            Console.WriteLine($"The cheapest price is: {this.TotalPrice:f2}");
        }
    }
}
