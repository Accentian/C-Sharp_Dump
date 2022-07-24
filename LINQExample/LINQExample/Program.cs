using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Language Integrated Query

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN="A1", Make = "BMW", Model="328i", Price=40000, Year=2016 },
                new Car() { VIN = "B2", Make = "Toyota", Model = "Camry", Price = 30000, Year = 2016 },
                new Car() { VIN = "C3", Make = "BMW", Model = "745li", Price = 75000, Year = 2015 },
                new Car() { VIN = "D4", Make = "Chevy", Model = "Camaro", Price = 35000, Year = 2017 },
                new Car() { VIN = "E5", Make = "BMW", Model = "330i", Price = 40000, Year = 2017 }
            };

            // LINQ Query
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       || car.Year == 2017      
                       select car;                  // Return all
                       //select new { car.Make, car.Model };    // Get certain fields

            // Show results
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", car.VIN, car.Make, car.Model
                    , car.Price, car.Year);
            }

            // LINQ Method
            var bmws1 = myCars.Where(p => p.Make == "BMW" && p.Year == 2017);

            // Show results
            Console.WriteLine("________________________");
            foreach (var car in bmws1)
            {
                Console.WriteLine("{0} {1}", car.Make, car.Model);
            }

            // How to order by LINQ Query
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;

            // Show results
            Console.WriteLine("________________________");
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Make, car.Model, car.Year);
            }

            // Show results
            var orderedCars1 = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine("________________________");
            foreach (var car in orderedCars1)
            {
                Console.WriteLine("{0} {1} {2}", car.Make, car.Model, car.Year);
            }

            // Getting first record with LINQ method
            Console.WriteLine("________________________");
            var firstBMW = myCars.First(p => p.Make == "BMW");
            Console.WriteLine("{0} {1}", firstBMW.Make, firstBMW.Model);

            // Method Chaining
            Console.WriteLine("________________________");
            var firstBMWChain = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine("{0} {1}", firstBMWChain.Make, firstBMWChain.Model);

            // See if all cars are newer than 2012
            Console.WriteLine("________________________");
            if (myCars.TrueForAll(p => p.Year > 2012))
            {
                Console.WriteLine("All cars are newer than 2012");
            }

            // Sum the prices of the cars
            Console.WriteLine("________________________");
            double sum = myCars.Sum(p => p.Price);
            Console.WriteLine("{0:C}", sum);

            // Subtract -3000 from each price
            myCars.ForEach(p => p.Price -= 3000);
            Console.WriteLine("________________________");
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.Make, p.Price));

            // pause
            Console.ReadLine();

        } // end main
    } // end class

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
    }


} // end namespace


