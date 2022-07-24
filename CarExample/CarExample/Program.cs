using System;

namespace CarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("red");
            car1.Color = "green";
            Console.WriteLine(car1.Describe());

            Car car2 = new Car("blue");
            Console.WriteLine(car2.Describe());

            // Pause
            Console.ReadLine();

        } // End main

        class Car
        {
            private string color;
            
            // Constructors
            public Car (string color)
            {
                this.color = color;
            }

            public string Color     // Setters and getters
            {
                get { return color; }
                set { color = value; }
            }

            // Create your own method to display the color of the car
            public string Describe()
            {
                return "This car color is " + color;
            }


        } // End Car class

    } // End class
} // End namespace
