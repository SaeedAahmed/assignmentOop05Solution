using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop05.project_Two
{
    internal static class Maths
    {
        public static int Sum( int num01 , int num02)
        {
            return num01 + num02; 
        }
        public static int Sub(int num01, int num02)
        {
            return num01 - num02;
        }
        public static int Multiply(int num01, int num02)
    {
            return num01 * num02;
        }
        public static double Divide(int num01, int num02)
    {
            if(num02 ==0)
            {
                Console.WriteLine("Can't Division by zero");
            }
               

            return num01 / num02;
        }
    }
}
