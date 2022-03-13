using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppClassTest1
{
    internal class BMI
    {
        double weight, height;
        public BMI(double weight, double height)
        {
            this.weight = weight;
            this.height = height;
        }

        public double compute()
        {
            return weight / (height / 100.0 * height / 100.0);
        }
    }
}
