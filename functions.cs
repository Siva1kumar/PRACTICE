using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE
{
    class functions
    {
        //public void show()
        //{
        //    Console.WriteLine("no values");
        //}
        //static void Main(string[] args)
        //{
        //    functions sk = new functions();
        //    sk.show();
        //}


            
           //functions>>>>>>>>>>>>>

        //public string show (string city )
        //{
        //    Console.WriteLine("hello");
        //    return city;
        //}
        //static void Main(string[] args)
        //{
        //    functions sk = new functions();
        //    string city = sk.show("Bangalore");
        //    Console.WriteLine(""+city);

        //}
          // call by value>>>>>>>>>>>>
        public void Show(int val)
        {
            val = 10;
            Console.WriteLine("inside function"+ val);

        }
        static void Main(string[] args)
        {
            functions sk = new functions();
            int val = 50;
            Console.WriteLine(" out side function" + val);
            sk.Show(val);
        }



        
    }
}
