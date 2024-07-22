using assignmentOop05.Abstraction;
using assignmentOop05.castiong_operator_overloading;
using assignmentOop05.objectThree;
using assignmentOop05.operaters_overloading;
using assignmentOop05.project_Two;
using assignmentOop05.projectOne;
using assignmentOop05.static_and_constants;

namespace assignmentOop05
{

  


    internal class Program
    {

        public static Point3D ReadPoint(string pointName)
        {
            int x, y, z;
            Console.WriteLine(pointName);

            while (true)
            {
                Console.Write("X: ");
                if (int.TryParse(Console.ReadLine(), out x))
                    break;
                Console.WriteLine("please enter an integer.");
            }


            while (true)
            {
                Console.Write("Y: ");
                if (int.TryParse(Console.ReadLine(), out y))
                    break;
                Console.WriteLine("please enter an integer.");
            }

            while (true)
            {
                Console.Write("Z: ");
                if (int.TryParse(Console.ReadLine(), out z)) break;
                Console.WriteLine("please enter an integer.");
            }

            return new Point3D(x, y, z);
        }
        static void Main(string[] args)
        {
            #region overloading operator
            Complex complex01 = new Complex()
            {
                Real = 1,
                Imag = 2,
            };
            Complex complex02 = new Complex()
            {
                Real = 6,
                Imag = 3,
            };
            #region Binary operator
            //Complex complex03 = default;

            //complex03 = complex01 + complex02;
            //Console.WriteLine(complex01);
            //Console.WriteLine(complex02);
            //Console.WriteLine("-------------");
            //Console.WriteLine(complex03);
            #endregion

            #region Unary operator
            //Console.WriteLine(complex01);
            //complex03 = ++complex01;
            //Console.WriteLine("After ++complex01");
            //Console.WriteLine(complex01);
            #endregion

            #region Comparison operator
            //if (complex01 > complex02)
            //    Console.WriteLine("c1 greater than c2");
            //else if (complex01 < complex02)
            //    Console.WriteLine("c1 !greater than c2");
            //else
            //    Console.WriteLine("c1 equals c2");
            #endregion

            #region casting operators
            //int x = (int)complex01;
            //Console.WriteLine($"X = {x}");

            //object O = "saeed";
            //string S = (string)O;
            #endregion

            #region Casting overloading
            //User user = new User()
            //{
            //    Id = 1,
            //    FullName = "saeed ahmed",
            //    Email = "saeed@gmail.com",
            //    Password = "123456",
            //    SecurityStmp = Guid.NewGuid()
            //};

            //UserViewModel userViewModel = (UserViewModel)user;

            //Console.WriteLine(userViewModel.Fname);
            //Console.WriteLine(userViewModel.Lname);
            //Console.WriteLine(userViewModel.Password);
            //Console.WriteLine(userViewModel.Email);
            #endregion

            #endregion

            #region Abstraction [class , method , property]
            //Rect rect = new Rect() { Dim01 = 10, Dim02 = 20 };

            //Console.WriteLine($"Rect area = {rect.CalcArea()}");
            //Console.WriteLine($"Rcct perimeter = {rect.Perimeter}");

            //Circle circle = new Circle(10);
            //Console.WriteLine(circle.Perimeter);
            //Console.WriteLine(circle.CalcArea()); 
            #endregion

            #region static member

            //Utility utility01 = new Utility(4 , 5);
            //Utility utility02 = new Utility(2, 6);


            //the result of calling method "cmToInch" will not be different by the difference of the obj [state(x,y)]
            //Console.WriteLine(Utility.CmToInch(254));
            //Console.WriteLine(Utility.circleArea(10)); 
            #endregion

            #region Project one

            //Point3D P1 = ReadPoint("P1");

            //Point3D P2 = ReadPoint("P2");

            //if (P1 == P2)
            //{
            //    Console.WriteLine("P1 and P2 are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("P1 and P2 are not equal.");
            //}

            //Point3D[] points = new Point3D[]
            //{
            //new Point3D(5, 3, 2),
            //new Point3D(1, 4, 6),
            //new Point3D(2, 8, 3),
            //new Point3D(7, 0, 9)
            //};

            //Array.Sort(points);

            //Console.WriteLine("Sorted points:");
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine(points[i].ToString());
            //}
            #endregion

            #region project two
            //int num01 = 15;
            //int num02 = 3;



            //Console.WriteLine($"Sum = {Maths.Sum(num01 , num02)}");
            //Console.WriteLine($"Sub = {Maths.Sub(num01, num02)}");
            //Console.WriteLine($"Multiply = {Maths.Multiply(num01, num02)}");
            //Console.WriteLine($"Divide = {Maths.Divide(num01, num02)}");


            #endregion

            #region project three
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString()); 
            //D3 = D1 + D2;
            //Console.WriteLine(D3.ToString()); 
            //D3 = D1 + 7800;
            //Console.WriteLine(D3.ToString());

            //D3 = 666 + D3;
            //Console.WriteLine(D3.ToString());

            //D3 = ++D1;
            //Console.WriteLine(D3.ToString());

            //D3 = --D2;
            //Console.WriteLine(D3.ToString()); 

            //D1 = D1 - D2;
            //Console.WriteLine(D1.ToString());

            //if (D1 > D2)
            //{
            //    Console.WriteLine("D1 is greater than D2");
            //}
            //else
            //{
            //    Console.WriteLine("D1 is not greater than D2");
            //}

            //if (D1 <= D2)
            //{
            //    Console.WriteLine("D1 is less than or equal to D2");
            //}

            //if ((bool)D1)
            //{
            //    Console.WriteLine("D1 is not zero");
            //}

            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj.ToString("HH:mm:ss")); 
            #endregion

        }
    }
}
