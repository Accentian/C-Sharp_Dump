using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyClassExercise2
{
    internal class Taxpayer
    {
        private string socialSecNum;
        private double yearlyGrossIncome;
        private double taxOwned;

        // Ignore constructor for this one. Use properties

        public String SocialSecNum
        {
            get { return socialSecNum; }
            set { socialSecNum = value; }
        }

        public double YearlyGrossIncome
        {
            get 
            { 
                return yearlyGrossIncome; 
            }

            set 
            { 
                yearlyGrossIncome = value;
                // Call CalcTaxOwned every time the income is set.
                CalcTaxOwned();
            }
        }

        // Make TaxOwned READ ONLY
        public double TaxOwned
        {
            get { return taxOwned; }
        }

        private void CalcTaxOwned()
        {
            if (yearlyGrossIncome < 3000) 
            {
                taxOwned = yearlyGrossIncome * .15;
            }
            else
            {
                taxOwned = yearlyGrossIncome * .28;
            }
        }
    }
}
