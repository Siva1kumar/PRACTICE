using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE
{
    class If_else_if
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name:");
            var name = Console.ReadLine();
            Console.WriteLine("enter number:");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s<35 )
            {
                Console.WriteLine("fail");
            }
            else if (s>35)
            
            {
                Console.WriteLine("pass");
            }
        }
    }
}
