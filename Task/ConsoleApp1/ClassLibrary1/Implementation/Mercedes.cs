using ClassLibrary1.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Objects;

namespace ClassLibrary1.Implementation
{
    public class Mercedes : Car, ICarOperation
    {



        public void NewAd(Car _car)
        {

            if (CarLimit > DataOperation.Mercedes.Count)
            {
                DataOperation.Mercedes.Add((Mercedes)_car);
            }



        }

        public void ShowAds(string Cars)
        {
            if (Cars == null)
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

        public Car FindCarsByNo(string no)
        {

            Car findedCar = null;
            foreach (var car in DataOperation.Mercedes)
            {
                if (car.No == no)
                {

                    findedCar = car;
                    break;
                }
            }
            return findedCar;
        }

        public List<Car> GetAddedList()
        {
            List<Car> list = new List<Car>();
            foreach (var item in DataOperation.Mercedes)
            {
                list.Add((Car)item);
            }
            return list;
        }

        public void ShowCars(string Car)
        {
            throw new NotImplementedException();
        }
    }
}
