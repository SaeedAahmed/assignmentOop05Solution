using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop05.static_and_constants
{
    //static class --( helper class )
    // is a just container for class members  (static member)[attribute , property , constructor , method]
    //and constans
    //you can't create object from this class 
    //no inheritance for this class
    internal static class Utility
    {
        ///static attribute
        ///private readonly static double pi = 3.14;
        ///compiler will initialize the static attribute with the default value of attribute datatype
        private const double pi = 3.14;

        ///public int X { get; set; }
        ///public int Y { get; set; }

        //class member property : static property
        /// *** static property get and set of these:
        ///    1. static attribute
        ///    2. constant
        public static double Pi
        {
            get { return pi; }
           // set { pi = value; }
        }
        ///Obj member constructor: non-static constructor
        ///public Utility(int _x , int _y)
        ///{
        ///    X = _x;
        ///    Y = _y;
        ///    //pi = 3.14; is not the place for initializing the static attributes
        ///}

        /// static constructor
        /// maximum only one static constructor per class
        /// can't specifiy access modifiers or parameters for static constructor
        /// well be executed just only one time per class lift time before the first use class
      
        ///Usages of class
        ///  1. call static method or static property
        ///  2.create object from this class
        ///  3.create object from another class inheriting from this class
        static Utility()
        {
           // pi = 3.14;
        }
      
        
        //class member method : static method
        public static double CmToInch(double Cm)
        {
            return Cm / 2.54;
        }

        public static double circleArea(double radius) 
        {
            return radius * radius * Pi;
        }
    }
}
