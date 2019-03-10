using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project
{
    public enum CarType
    {
        light, rover, truck
    }
    public class Car
    {
        public Car() { }
        public string brand { get; set; }
        public DateTime date { get; set; }
        public string model { get; set; }
        public CarType type { get; set; }
        public int garageNum { get; set; }

        public Car(string brand, DateTime date, string model, CarType type)
        {
            this.brand = brand;
            this.date = date;
            this.model = model;
            this.type = type;
            this.garageNum = garageNum;
        }

        public void showInfo()
        {
            Console.WriteLine("Brand - {0} ", this.brand);
            Console.WriteLine("Model - {0} ", this.model);
            Console.WriteLine("Year of issue- {0} ", this.date);
            Console.WriteLine("Type of car - {0} ", this.type);
            Console.WriteLine("Garage number - {0} ", this.garageNum);
        }

    }
}
