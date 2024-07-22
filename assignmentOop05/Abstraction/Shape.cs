using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop05.Abstraction
{
    // Abstract class
    //is a partial implementation to other classes
    // U cant create object from abstract class , because it is not Fully-implemented
    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        public abstract decimal Perimeter { get; }

        public abstract decimal CalcArea();
    }

    // : ----> inherits and implements 

    abstract class RectBase : Shape
    {
            public override decimal CalcArea()
            {
                return Dim01 * Dim02;
            }  
    }

    //Rect is a RectBase
    //Concrete class
    class Rect : RectBase 
    {
        public override decimal Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }
    }
    //Concrete class
    class Square : RectBase
    {
        public Square( decimal dim)
        {
            Dim01 = Dim02 = dim;
        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }  

     
    }

    class Circle : Shape
    {
        public Circle(decimal Radius)
        {
            Dim01 = Dim02 = Radius;
        }
        public override decimal Perimeter
        {
            get { return 2 * 3.14m * Dim01; }
        } 

        public override decimal CalcArea()
        {
            return 3.14m * Dim01 * Dim02; 
        }
    }

}
