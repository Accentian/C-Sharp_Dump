using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyClassExercise1
{
    internal class Square
    {
        private int side;
        private int area;

        public Square(int side)
        {
            this.side = side;
            CalcArea();
        }

        private void CalcArea()
        {
            this.area = side * side;

        }

        public int Side
        {
            get { return side; }
            set { side = value; }
        }

        public int Area
        {
            get { return area; }
            set { area = value; }
        }
    }
}
