using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();





        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //1-BEYAZ, 2-SİYAH, 3-GRİ, 4-LACİVERT, 5-KIRMIZI
            colorManager.Add(new Color
            {
                ColorId = 2,
                ColorName = "SİYAH"
            });
            

            colorManager.Update(new Color { ColorId = 3, ColorName = "GRİ" });
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            // 1-GÜNSEL  2- MERCEDES  3- BMW   4- AUDİ  5-VOSLSWAOGEN  6- VOLVO
            brandManager.Add(new Brand
            {
                BrandId = 2,
                BrandName = "MERCEDES"
            });

            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                
                Console.WriteLine(brand.BrandName);
            }
            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            
            carManager.Add(new Car
            {
                CarId = 1,
                BrandId = 1,
                ColorId = 5,
                ModelYear = 2021,
                DailyPrice = 1000,
                Description = "J9"
            });



            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(" => " +  car.CarName + " - " + car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
