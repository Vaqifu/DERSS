using ClassLibrary1;
using ClassLibrary1.Implementation;
using ClassLibrary1.Interface;
using ClassLibrary1.Objects;
using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            string opt;
            do
            {
                Console.WriteLine("1.Yeni elan elave et");
                Console.WriteLine("2.WipMasinlara bax");
                Console.WriteLine("3.Masinlara bax");
                Console.WriteLine("4.Cix");

                Console.WriteLine("\n Emeliyyati secin:");
                opt = Console.ReadLine();


                switch (opt)
                {
                    case "1":
                        Car car = GetCarAddFromConsole();
                        mercedes.NewAd(car);
                        break;
                    case "2":

                        Console.WriteLine("WipElanlara Baxiniz:");
                        foreach (var item in DataOperation.WipCarsList)
                        {
                            Console.WriteLine($"No: {item.No} MOdel: {item.Model} Price :{item.Price} Count:{item.Count}");
                        }

                        
                        break;


                    case "3":
                        Console.WriteLine("Masinlara Bax :");
                        foreach (var item in DataOperation.CArs)
                        {
                            Console.WriteLine($"NO: {item.No}  Model: {item.Model}  Count: {item.Count} Price :{item.Price}");
                        }




                        break;
                    case "4":
                        Console.WriteLine("Menudan  cix");
                        break;

                    default:
                        break;
                }


            } while (opt!="4");
        }

        private static void ShowWipAds()
        {
            throw new NotImplementedException();
        }

        static Car GetCarAddFromConsole()
        {
            Console.WriteLine("masinin Nomresin  daxil edin");
            string No = Console.ReadLine();
            Console.WriteLine("Masinin Modelin daxil ed");
            string Model=Console.ReadLine();    



            string countStr;
            int count;
            do
            {
                Console.WriteLine("Masinin sayin daxil edin");
                 countStr = Console.ReadLine();
                


            } while (!int.TryParse(countStr, out count)||count <0);

            string priceStr;
            double price;

            do
            {
                Console.WriteLine(" Masinin qiymetin daxil edin ");
                priceStr = Console.ReadLine();  

            } while (double.TryParse(priceStr,out price)||price <0);

            Car car = new Car
            {
                No = No,
                Model = Model,
                Price = price,
                Count = count,
            };
            return car;
           
        }
        static void AddNewCar()
        {
            Car car = new Car();


            car.No = "N123";
            car.Model = "gls 3200";
            car.Count = 1;
            car.Price = 32000;      

        }

       
               
        
    }
}
