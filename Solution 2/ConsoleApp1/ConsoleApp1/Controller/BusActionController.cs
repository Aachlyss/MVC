using ConsoleApp1.Model;
using ConsoleApp1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    public class BusActionController
    {
        private Display display;
        private Transport transport;

        public BusActionController()
        {
            display = new Display();
            transport = new Transport(display.DistanceKM, display.TimeOfDay);
            display.TotalPrice = transport.CalculatePrice();
            display.ShowPrice();
        }
    }
}
