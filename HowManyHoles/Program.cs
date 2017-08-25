using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyHoles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Numbers.txt");
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
