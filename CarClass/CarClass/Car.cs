using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class Car
    {
        // Instances vars
        private string year;
        private string make;
        private double speed;
        
        // Create constructor
        public Car()
        {
            year = "1997";
            make = "Honda";
            speed = 0;
        }

        // Create properties
        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        // Method for Accelerate
        public double Accelerate(double accel)
        {
            accel = 5;
            speed += accel;
            return speed;
        } // End Accelerate Method

        public double Brake(double brake)
        {
            brake = 5;
            speed -= brake;
            return speed;
        } // End Brake Method


    } // End class
} // End namespace
