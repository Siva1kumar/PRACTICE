using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE
{
    class switch_example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 10: Console.WriteLine("it is 10:");break;
                case 20: Console.WriteLine("it is 20:");break;
                case 30: Console.WriteLine("it is 30:");break;
                case 40: Console.WriteLine("it is 40:");break;


                default: Console.WriteLine(" not 10,20,30,40 "); break;
            }
        }
    }
}
