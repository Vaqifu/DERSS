using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Objects
{
    public  class Car
    {
        public int CarLimit { get; set; }
        public string No { get; set; }
        public string Model { get; set; }

        public double Price { get; set; }
        public int Count { get; set; }


        public List<Car> GetAddedCars()
        {
            List<Car> CArs = new List<Car>();
            foreach (var item in DataOperation.CArs)
            {
                CArs.Add((Car)item);
            }
            return CArs;
        }


        public static void AddCar1()
        {
            Car car = new Car();
            Console.WriteLine("Masinlari daxil edin");
           car.No=Console.ReadLine();
            DataOperation.CArs.Add(car);    



        }

    
    }
}
