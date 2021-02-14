//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_VIII
{
    public class Rectangle
    {
        private int _a;
        private int _b;

        //prop  ************ It is different than C++ so its important.

        public int a
        {
            get { return _a; }
            set
            {
                if (value < 0)      //By using this lines we pretend negative input values.
                {
                    _a = 0;
                }
                else
                    _a = value;
            }
        }

        public int b 
        {
            get { return _b; }
            set
            {
                if (value < 0)
                {
                    _b = 0;
                }
                else
                    _b = value;
            }
        }

        public int CalculateArea()
        {
            return _a * _b;
        }
    }
}
