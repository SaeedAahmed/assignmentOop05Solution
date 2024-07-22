using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop05.projectOne
{
    internal class Point3D : ICloneable , IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D( int x , int y , int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D() : this(0, 0, 0) { }
        public override string ToString()
        {
            return $"Point Coordinates: {X} , {Y} , {Z}";
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public int CompareTo(object? obj)
        {
            Point3D? point =(Point3D ?) obj;
            if (point == null)
                return 1;
            if (this.X == point.X)
            {
                return this.Y.CompareTo(point.Y);
            }
            return this.X.CompareTo(point.X);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point3D point)
            {
                return this.X == point.X && this.Y == point.Y && this.Z == point.Z;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X , Y , Z);
        }
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (p1?.X == p2?.X && p1?.Y == p2?.Y)
                return p1?.Z == p2?.Z;
            else
                return p1?.X == p2?.X && p1?.Y == p2?.Y;
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }


    }

 

}
