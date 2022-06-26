using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.InterFace;

namespace ConsoleApp1.Implementation
{
    public class Mercedes : Cars
    {
        private Cars[] _cars;
        public Cars[] Carss => _cars;
        public int CarLimit { get;set; }
        public string No { get;set;}
        public void NewAd(Cars Car)
        {
           if (CarLimit > _cars.Length )
            {
                Array.Resize(ref _cars, _cars.Length+1);
                _cars[_cars.Length-1] = Car;
            } 
        }

        public void ShowAds(string Cars)
        {
            if (Cars == null )
            {

                Console.WriteLine(Cars);
            }
        }

        public void ShowWipAds(string Cars)
        {
            if (Cars != null)
            {
                Console.WriteLine(Cars);
            }
        }

        public Cars FindCarsByNo(string id)
        {
            Cars cars = null;
            
            foreach (var car in _cars )
            {
                if (car.No == id)
                {
                    cars = car;
                    break;  
                }
            }
            return cars;
        }

    }
}
