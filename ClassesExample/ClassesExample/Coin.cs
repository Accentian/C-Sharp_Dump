using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    class Coin
    {
        // Create instance vars
        private string sideUp;

        // Constructor
        public Coin(string startSide)
        {
            sideUp = startSide;
        } // End constructor Coin

        // Create a property
        public string Flip
        {
            get { return sideUp; }
            set { sideUp = value; }
        } // End flip



        // Method of tossing coin
        public void toss()
        {
            Random rand = new Random();
            if (rand.Next(2) == 0)
            {
                sideUp = "Tails";
            } // End if
            else
            {
                sideUp = "Heads";
            } // End else

        } // End toss

       // Method to get the cost
       public string getToss()
        {
            return sideUp;
        } // End getToss


    } // End class
} // End namespace
