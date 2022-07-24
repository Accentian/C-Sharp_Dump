using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Chevy";
            car1.Model = "Corvette";
            car1.VIN = "123";

            Car car2 = new Car();
            car2.Make = "Ford";
            car2.Model = "Fusion";
            car2.VIN = "456";

            Car car3 = new Car() { Make = "BMW", Model = "328i", VIN = "789" };

            Employee emp1 = new Employee() { Name = "Don", Title = "Instructor", Dept = "IT" };

            // Old way - ArrayList
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(car3);
            //myArrayList.Add(emp1);        emp1 does not have a Make

            foreach(Car auto in myArrayList)
            {
                Console.WriteLine(auto.Make);
            }


            /////////////// Lists
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            myList.Add(car3);
            //myList.Add(emp1);     List will have a red line for emp1 since it is not Car

            foreach (Car auto in myList)
            {
                Console.WriteLine(auto.Make);
            }


            //////////////// Dictionary
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);
            myDictionary.Add(car3.VIN, car3);

            // Now we can print specific record using our key
            Console.WriteLine("Diction record is " + myDictionary["123"].Make);
            Console.WriteLine("Diction record is " + myDictionary["123"].Model);

            foreach( Car auto in myDictionary.Values)
            {
                Console.WriteLine("VIN is {0} Make is {1} Model is {2}", 
                    auto.VIN, auto.Make, auto.Model);

                Console.WriteLine();
            }

            // Pause
            Console.ReadLine();

        } // End main
    } // End class

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }


    } // End class Car

    class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Dept { get; set; }


    } // End class Employee

} // End namespace
