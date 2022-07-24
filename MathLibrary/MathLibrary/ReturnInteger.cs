using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    /// <summary>
    /// This class will contain three method that will return the largest integer
    /// </summary>

    public class ReturnInteger
    {
        public int Compare(int num1, int num2)
        {
            if ( num1 > num2 )
            {
                return num1;
            }
            else if( num2 > num1 )
            {
                return num2;
            }
            else
            {
                return num1;
            }

        } // End TwoParameters

        public int Compare(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else if (num3 > num2 && num3 > num1)
            {
                return num3;
            }
            else
            {
                return num1;
            }

        } // End ThreeParameters

        public int Compare(int num1, int num2, int num3, int num4)
        {
            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                return num2;
            }
            else if (num3 > num2 && num3 > num1 && num3 > num4)
            {
                return num3;
            }
            else if (num4 > num1 && num4 > num2 && num4 > num3)
            {
                return num4;
            }
            else
            {
                return num1;
            }

        } // End FourParameters

        } // End class

} // End namespace
