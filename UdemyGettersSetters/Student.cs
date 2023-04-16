using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyGettersSetters
{
    internal class Student
    {
        private string name;
        private int age;
        private double finalGrade;

        public Student(string name, int age, double finalGrade)
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }

        public Student(string name, int age) 
            : this(name, age, 0)
        {

        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }

        // Getters and Setters allows users to access or change it in a 'controlled' way.
        public string GetName()
        {
            if(age >= 18)
            {
                return name;
            }
            else
            {
                return "Student age is below the requirement";
            }
        }

        // Set function allows users to change the value
        public void SetName(string newName)
        {
            if (newName != "")
            {
                name = newName;
            }
        }

        public int GetAge()
        {
            if (age >= 18)
            {
                return age;
            }
            else
            {
                return -1;
            }
        }

        public void SetAge(int newAge)
        {
            if (newAge > 0) 
            {
                age = newAge;
            }
        }

        public double GetFinalGrade()
        {
            return finalGrade;
        }

        public void SetFinalGrade(double newGrade)
        {
            if(newGrade < 65)
            {
                newGrade = 65;
            }
            else if (newGrade > 100) {
                newGrade = 100;
            }
            finalGrade = newGrade;
        }
    }
}
