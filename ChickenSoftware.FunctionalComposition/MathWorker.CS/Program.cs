using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenSoftware.MathWorker.CS
{
    class Program
    {
        public static Int32 AddTen(Int32 x)
        {
            return x + 10;
        }

        public static Int32 MultiplyFive(Int32 x)
        {
            return x * 5;
        }

        public static Int32 SubtractTwo(Int32 x)
        {
            return x - 2;
        }

        static void Main(string[] args)
        {

            Int32 x = 10;

            //Way #1
            Int32 addedNumber = AddTen(x);
            Int32 multipliedNumber = MultiplyFive(addedNumber);
            Int32 answer = SubtractTwo(multipliedNumber);
            Console.WriteLine(answer);

            //Way #2
            Int32 anotherAnswer = SubtractTwo(MultiplyFive(AddTen(x)));
            Console.WriteLine(anotherAnswer);

            Console.ReadKey();

        }
    }
}
