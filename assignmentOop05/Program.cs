using assignmentOop05.castiong_operator_overloading;
using assignmentOop05.operaters_overloading;

namespace assignmentOop05
{
    internal class Program
    {
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
        }
    }
}
