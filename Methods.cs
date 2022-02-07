using System;

namespace Day3
{
    internal class Methods
    {
        static void StaticFunction() => Console.WriteLine(" static function");
        public static void PassValue(ref int X)
        {
            int x = 123;
            Console.WriteLine($" the value of {x} ");
        }
        static void MathFunc (double v1, double v2, ref double res1, ref double res2, ref double res3)
        {
            res1 = v1 + v2;
            res2 = v1 - v2;
            res3 = v1 * v2;
        }
        public static void mathoutfunc (double v1, double v2,  out double res1, out double res2, out double res3)
        {
            res1 = v1 + v2;
            res2 = v1 - v2;
            res3 = v1 * v2;

        }
        
        


        void normalFunction() => Console.WriteLine("instance method");
        static void Main(string[] args)
        {
            //StaticFunction();
            
            {
                int x = 143;
                PassValue(ref x);
                Console.WriteLine($" after return it will print {x} ");
            }
            Methods demo = new Methods();
            demo.normalFunction();
            double  res1 = 0, res2 = 0, res3 = 0;
            //MathFunc(123, 23, ref res1, ref res2, ref res3);
            mathoutfunc(123, 24, out res1, out res2, out res3);
            Console.WriteLine($" the res1:{res1},\t the res2:{res2},\t the res3: {res3}");
        }

    }
}