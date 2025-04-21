using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public enum Categories { חלב, ירקות, פירות, חדפ}
    public class Product
    {
        public const int MAX_LENGTH = 20;

        public static int Index = 100;

        public readonly int Code;

        //כמו readonly
        //public int MyProperty { get; }

        private string name = "";

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            this.name = value;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length > MAX_LENGTH)
                    throw new Exception($"אורך שם עד {MAX_LENGTH} תווים");
                else
                    name = value;
            }
        }

        public Categories Category { get; set; }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool ByWeight { get; init; }

        private DateTime expDate;

        public DateTime ExpDate
        {
            get { return expDate; }
            set { expDate = value; }
        }

        private int countInStock;

        public int CountInStock
        {
            get { return countInStock; }
            set { countInStock = value; }
        }

        public Product()
        {
            Code = Index++;
            Category = 0; // Categories.חלב;

            //MyProperty = 0;
        }
        public Product(bool byWeight) : this()
        {
            ByWeight = byWeight;
        }
        public Product(string name, DateTime expDate, double price, bool byWeight, int count) : this(byWeight)
        {
            Name = name;
            Price = price;
            //ByWeight = byWeight;
            ExpDate = expDate;
            CountInStock = count;
        }

        public void PrintIndex()
        {
            Console.WriteLine(Index);
        }

        public static void IndexUp(int val)
        {
            Index += val;            
        }
    }
}
