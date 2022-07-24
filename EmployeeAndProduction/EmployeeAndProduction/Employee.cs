using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndProduction
{
    class Employee
    {
        // Instance variables
        private string name;
        private string number;

        // Constructor
        public Employee()
        {
            name = "";
            number = "";
        }

        // Get and Set
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Number
        {
            set { number = value; }
            get { return number; }
        }
    } // End class

    class ProductionWorker: Employee
    {
        private int shift;
        private double payRate;

        // Constructor
        public ProductionWorker()
        {
            shift = 0;
            payRate = 0;
        }

        // Get and Set
        public int Shift
        {
            set { shift = value; }
            get { return shift; }
        }

        public double PayRate
        {
            set { payRate = value; }
            get { return payRate; }
        }
    } // End ProductionWorker

    class ShiftSupervisor : Employee
    {
        private double anSalary;
        private double anBonus;

        // Constructor
        public ShiftSupervisor()
        {
            anSalary = 0;
            anBonus = 0;
        }

        // Get and Set
        public double AnnualSalary
        {
            set { anSalary = value; }
            get { return anSalary; }
        }

        public double AnnualBonus
        {
            set { anBonus = value; }
            get { return anBonus; }
        }
    } // End ProductionWorker

} // End namespace
