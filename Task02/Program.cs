using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection carPark = new CarCollection();

            carPark.AddCar("Skoda Octavia", 2006);
            carPark.AddCar("Toyota Corolla", 2020);
            carPark.AddCar("Ford Mustang", 1968);
            carPark.AddCar("Tesla Model S", 2022);

            Console.WriteLine("Машини з колекції: ");
            for(int i = 0; i < carPark.Count; i++)
            {
                Console.WriteLine(carPark[i]);
            }

            carPark.Clear();
            Console.WriteLine($"Всього число машин після чистки: {carPark.Count}");
        }
    }
}
