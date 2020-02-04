using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> agesOfStudents = new Dictionary<string, int>();

            agesOfStudents["Mads"] = 29;
            agesOfStudents["Kasper"] = 20;
            agesOfStudents["Andreas"] = 25;
            agesOfStudents["Logan"] = 18;



            //10000 linjer senere

            Console.WriteLine(agesOfStudents["Andreas"]);




        }
    }
}
