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
            using (StreamReader reader = new StreamReader("Numbers.txt"))
            {

                string line;

                while ((line = reader.ReadLine()) != null)
                {


                    char[] numbers = line.Select(i => i).ToArray();
                    int holeCount = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {

                        if (numbers[i] == '4')
                        {
                            holeCount += 1;
                        }
                        else if (numbers[i] == '6')
                        {
                            holeCount += 1;
                        }
                        else if (numbers[i] == '8')
                        {
                            holeCount += 2;
                        }
                        else if (numbers[i] == '9')
                        {
                            holeCount += 1;
                        }
                        else if (numbers[i] == '0')
                        {
                            holeCount += 1;
                        }

                        else
                        {
                            continue;
                        }

                    }
                    Console.WriteLine(holeCount);

                }

            }
        }
    }
}

