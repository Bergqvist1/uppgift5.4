using System;
namespace Uppgift_5_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] namn = new string[5];

            namn[0] = "Simon";
            namn[1] = "Elin";
            namn[2] = "Ali";
            namn[3] = "Elis";
            namn[4] = "Alfred";

            string första = "Simon";

            for(int i = 0; i < namn.Length; i++)
            {

                if (namn[i].CompareTo(första) < 0)
                {
                    första = namn[i];
                }

            }

            Console.WriteLine(första);
        }
    }
}
