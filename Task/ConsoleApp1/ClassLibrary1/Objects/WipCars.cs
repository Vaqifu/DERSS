using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Objects
{
    public class WipCars:Car
    {
        public static void AddWipAds()
        {
            WipCars car = new WipCars();
            Console.WriteLine("Wip Elanlari daxil edin");
            car.No = Console.ReadLine();
            DataOperation.WipCarsList.Add(car);
              
        }
    }
}
