using System.ComponentModel;
using System.Reflection;
using System.Transactions;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int uInt1, int uInt2)
          {
            return uInt1 + uInt2;
          }
        public static decimal Add(decimal uDec1, decimal uDec2)
          {
            return uDec1 + uDec2;
          }
        public static string Add(double uDollar, double uDollar2, bool yayNe)
          {
            var mAnswer = uDollar + uDollar2;

            if (yayNe == true && mAnswer == 1)
            {
                return $"You have, {mAnswer} dollar.";
            }
            else
            {
                return $"You have, {mAnswer} dollars.";
            }
            if (yayNe == true && mAnswer < 1)
            {
                return "you have no money";
            }
          }
        




        static void Main(string[] args)
        {
            int uInt1 = 23; int uInt2 = 5;
            int iAnswer = Add(uInt1, uInt2);

            decimal uDec1 = 12.36m;
            decimal uDec2 = 11.4m;
            decimal dAnswer = Add(uDec1, uDec2);

            var uDollar = 45;
            var uDollar2 = 45;

            Console.WriteLine(Add(uInt1, uInt2));
            Console.WriteLine(iAnswer);

            Console.WriteLine(Add(uDec1, uDec2));
            Console.WriteLine(dAnswer);

            Console.WriteLine(Add(uDollar, uDollar2, true));
            
              


        }
    }
}
