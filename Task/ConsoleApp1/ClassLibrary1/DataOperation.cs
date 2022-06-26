using ClassLibrary1.Implementation;
using ClassLibrary1.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public  class DataOperation
    {
        public static List<Mercedes> Mercedes;
        public static List<WipCars> WipCarsList;
        public static List<Car> CArs;
        static DataOperation() { 
       
            Mercedes=new List<Mercedes>();
            WipCarsList=new List<WipCars>();
            CArs=new List<Car>();


            Car car = new Car();
            car.No = "34.bc.343";
            car.Model = "Opel";
            car.Count = 1;
            car.Price = 8.400;
            CArs.Add(car);


            Car car1 = new Car();
            car1.No = "36.bc.348";
            car1.Model = "Opel Astra";
            car1.Count = 1;
            car1.Price = 6.400;
            CArs.Add(car1);

            Car car2 = new Car();
            car2.No = "78.AA.743";
            car2.Model = "Mercedes";
            car2.Count = 1;
            car2.Price = 11.400;
            CArs.Add(car2);


            Car car3 = new Car();
            car3.No = "38.CD.343";
            car3.Model = "BMW";
            car3.Count = 1;
            car3.Price = 18.400;
            CArs.Add(car3);


            WipCars wipCars1 = new WipCars();

            wipCars1.Price = 44.500;
            wipCars1.Model = "Renault";
            wipCars1.No = "33 bd 678";
            wipCars1.Count = 1;

            WipCarsList.Add(wipCars1);

            WipCars wipCars2 = new WipCars();

            wipCars2.Price = 49.500;
            wipCars2.Model = "Opel Astra 2002";
            wipCars2.No = "36 bd 678";
            wipCars2.Count = 1;

            WipCarsList.Add(wipCars2);  
        }

    }
}
