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
                    int holeCount = 0;
                    //List<int> numListr = new List<int>(int.Parse(line));
                    //int[] numbers = line.Split().Select(str => int.Parse(str)).ToArray();
                    //string [] numList = line.Split().ToArray();
                    //List<int> numList = line.Split().Select(Int32.Parse).ToList();
                    int [] numbers = line.Select(c => c - '0').ToArray();
                    //Console.WriteLine(numbers[1]);

                    for(int i = 0; i <numbers.Length; i++)
                    {
                      
                        if (numbers[i] == 4)
                        {
                            holeCount += 1;
                        }
                        else if (numbers[i] == 6)
                        {
                            holeCount += 1;
                        }
                        else if (numbers[i] == 8)
                        {
                            holeCount += 2;
                        }
                        else if (numbers[i] == 9)
                        {
                            holeCount += 1;
                        }
                        else if (numbers[i] == 0)
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
