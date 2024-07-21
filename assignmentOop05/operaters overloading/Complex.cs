using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop05.operaters_overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }


        //overloading operator : Must be non-private class  memper function

        #region Binary operators
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)
            };
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
            };
        }
        #endregion

        #region Unaary operators
        public static Complex operator ++(Complex c)
        {
            return new Complex
            {
                Real = (c?.Real ?? 0) + 1,
                Imag = (c?.Imag ?? 0)
            };
        }
        #endregion

        #region Comparison operator 
        public static bool operator >(Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
                return left?.Imag > right?.Imag;
            else
                return left?.Real > right?.Real;
        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
                return left?.Imag < right?.Imag;
            else
                return left?.Real < right?.Real;
        }
        #endregion

        #region Casting operator
        public static /*int*/ explicit operator int(Complex c)
        {
                return c?.Real ?? 0;
        }

        public static  explicit operator string(Complex c)
        {
            return c?.ToString() ?? string.Empty;
        }
        #endregion

        public override string ToString()
        {
            return $"{Real} + {Imag}i"; 
        }
    }

}
