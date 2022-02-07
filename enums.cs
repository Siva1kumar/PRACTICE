using System;

namespace day3
{
    enum Names { shiva,varun,goutham,prejawal};
    class Enumdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" select the type of names");
            var names = Enum.GetValues(typeof(Names));
            foreach (var data in names)
            {
                Console.WriteLine(data);
            }
            Names type = (Names)Enum.Parse(typeof(Names), Console.ReadLine());

        }
    }
}