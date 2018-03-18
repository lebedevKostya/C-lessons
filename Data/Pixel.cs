using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
   public class Pixel
    {
        private double red;
        public double Red
        {
            get { return red; }
            set
            {
                red = Check(value);
            }
        }
        private double green;
        public double Green
        {
            get { return green; }
            set
            {
                green = Check(value);
            }
        }
        private double blue;
        public double Blue
        {
            get { return blue; }
            set
            {
                blue = Check(value);
            }
        }

        public double Check(double value)
        {
            if (value < 0 || value > 1) throw new ArgumentException();
            return value;
        }
        public static double Trim(double value)
        {
            if (value > 1) return 1;
            if (value < 0) return 0;
            return value;
        }
    }
}
