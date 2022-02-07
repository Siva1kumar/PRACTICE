using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class methodpractice
    {
        static void simpleFunc() => Console.WriteLine("static function");
        public static void Value(ref int x)
        {
            int X = 123;
            Console.WriteLine($" the value is: {X}");
        }
        public static void shiva( double v1, double v2, ref double res1, ref double res2,ref double res3)
        {
            res1 = v1 + v2;
            res2 = v1 - v2;
            res3 = v1 * v2;
        }
        void Normalfunc() => Console.WriteLine("instance function");
        static void Main(string[] args)
        {
           // simpleFunc();
           
            {
                int x = 10;
                Value(ref x);
                Console.WriteLine($"after retrun this value: {x}");
            }
            methodpractice varu =new  methodpractice();
            varu.Normalfunc();
            double res1 = 0, res2 = 0, res3 = 0;
            shiva (123, 10, ref res1, ref res2, ref res3);
            Console.WriteLine($" res1:{res1},\t res2:{res2},\t res3:{res3}");


        }
    }
}
