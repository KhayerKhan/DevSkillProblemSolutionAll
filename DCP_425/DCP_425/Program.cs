using System;

namespace DCP_425
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int n = 9;
            //Console.WriteLine(n);

            int n;
            string text;
            int sum = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                text = Console.ReadLine();

                for (int j = 0; j < text.Length; j++)
                {

                    sum = sum + Char.ConvertToUtf32(text, j);
                    // Console.WriteLine(sum);
                    // Console.WriteLine(text[i] + " => " + Char.ConvertToUtf32(text, i));
                }

                if (sum % 20 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else { Console.WriteLine("No"); }
            }
           
        }
    }
}
