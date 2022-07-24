using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Employee
    {
        // Instance variables
        private string name;
        private string address;

        // Constructor
        public Employee()
        {
            name = "";
            address = "";
        }

        // Setters and getters
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Address
        {
            set { address = value; }
            get { return address; }
        }

    } // End class


    class Faculty: Employee
    {
        // Instance variables
        private double professionalDevHrs;
        private string committees;

        // Constructor
        public Faculty()
        {
            professionalDevHrs = 0;
            committees = "";
        }

        // Getters and setters
        public double ProfessionalDevHrs
        {
            set { professionalDevHrs = value; }
            get { return professionalDevHrs; }
        }

        public string Committees
        {
            set { committees = value; }
            get { return committees; }
        }
    } // End Faculty

    class Staff: Employee
    {
        // Instance variables
        private double workShopHrs;
        private double flexSpending;

        // Constructor
        public Staff()
        {
            workShopHrs = 0;
            flexSpending = 0;
        }

        // Getters and setters
        public double WorkShopHrs
        {
            set { workShopHrs = value; }
            get { return workShopHrs; }
        }

        public double FlexSpending
        {
            set { flexSpending = value; }
            get { return flexSpending; }
        }
    } // End Staff

} // End namespace
