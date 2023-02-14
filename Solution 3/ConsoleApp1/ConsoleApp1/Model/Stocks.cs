using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    public class Stocks
    {
        private double vegetables;
        private double fruits;
        public double weight;

        public Stocks(double vegetables, double fruits,double weight)
        {
            Vegetables = vegetables;
            Fruits = fruits;
            Weight = weight;
        }

        public double Vegetables
        {
            get { return this.vegetables; }
            set { this.vegetables = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public double Fruits
        {
            get { return this.fruits; }
            set { this.fruits = value; }
        }

        public double CalculateVegetables()
        {
            return Vegetables * Weight;
        }
        public double CalculateFruits()
        {
            return Fruits * Weight;
        }
        public double CalculateTotal()
        {
            return (Fruits * Weight) + (Vegetables * Weight);
        }
    }
}
