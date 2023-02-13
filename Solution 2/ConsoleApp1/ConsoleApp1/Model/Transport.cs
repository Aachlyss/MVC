using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    class Transport
    {
        private double distanceKM;
        private string partOfDay;
        private double price;

        public Transport(double distanceKM, string partOfDay)
        {
            this.distanceKM = distanceKM;
            this.partOfDay = partOfDay;
        }
        public Transport() :this(0,"")
        {

        }

        public double DistanceKM
        {
            get { return this.distanceKM; }
            set { this.distanceKM = value; }
        }

        public string PartOfDay
        {
            get { return this.partOfDay; }
            set { this.partOfDay = value; }
        }

        public double CalculatePrice()
        {
            double tax = 0;
            double tariff = 0;
            if (this.DistanceKM<20)
            {
                tax = 0.70;
                if (this.PartOfDay == "day")
                {
                    tariff = 0.79;
                }
                else
                {
                    tariff = 0.9;
                }
            }
            else if(this.DistanceKM<100)
            {
                {
                    tariff = 0.9;
                }
            }
            else
            {
                tariff = 0.6;
            }
            return tax + tariff * this.DistanceKM;
        }
    }
}
