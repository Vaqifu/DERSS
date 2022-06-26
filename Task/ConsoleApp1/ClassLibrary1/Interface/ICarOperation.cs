using ClassLibrary1.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Interface
{
    public interface ICarOperation
    {
        void NewAd(Car Car);

        void ShowAds(string Car);

        void ShowWipAds(string Car);
        void ShowCars(string Car);



        List<Car> GetAddedCars();

        List<Car> GetAddedList();
    }
}
