using System;

namespace Correctcontrwork1
{
    class MainClass
    {
        public struct City
        {
            public string Name;
            public long Population;
            public int Destiny;
        }
        public static void Main(string[] args)
        {
            string input = "Kharkiv = 1431000,350; Kiev = 2804000,839; Las Vegas = 603400,352";

            input = input + ";";
            string buff = "";
            int arraySize = 1;
            string[] Records = new string[arraySize];
            int n = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ';' )
                {
                    buff = buff + input[i];

                }
                else 
                {
                    Records[n] = buff;
                    n++;
                    arraySize++;
                    Array.Resize<string>(ref Records, arraySize);
                    buff = "";
                }
            }

			for (int i = 0; i < Records.Length; i++)
			{
				Console.WriteLine(Records[i]);
			}

            City[] RealCity = new City[Records.Length - 1];
            string population = "";
            string destiny = "";
            for (int i = 0; i < Records.Length - 1; i++)
            {
                RealCity[i] = new City();
                bool namefound = false;
                bool populationfound = false;

                for (int j = 0; j < Records[i].Length; j++)
                {
                    //
                }
            }
        }
    }
}
