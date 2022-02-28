using System;

namespace Dec_Mult_Finder
{
    internal class Program
    {
        static decimal avg(decimal numA, decimal numB) {
            return (numA + numB) / 2;
        }

        static void Main(string[] args)
        {
            decimal numA = 5;
            decimal numB = 6;
            decimal[] goals = new decimal[] { 1, 2, 3, 4, 5 };

            foreach (decimal goal in goals) {
                decimal tmpNumA = numA;
                decimal tmpNumB = numB;
                decimal numC = 0;

                for (int i = 0; i < 5000; i++)
                {
                    numC = avg(tmpNumA, tmpNumB);

                    decimal temp = numC * (numC % 1);

                    if (temp > goal)
                    {
                        tmpNumB = numC;
                    }
                    else if (temp < goal)
                    {
                        tmpNumA = numC;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write(goal + "\t");
                Console.Write(numC + "\t");
                Console.WriteLine((numC % 1) + "\t");
            }
        }
    }
}
