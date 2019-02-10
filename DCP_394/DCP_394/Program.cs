using System;

namespace DCP_394
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    var  n =(Console.ReadLine());

            //    if (n == null) { break; }

            //    var k = n.Split(' ');
            //    decimal  n1 = Convert.ToDecimal(k[0]);
            //    n1 = n1 * n1;
            //    Console.WriteLine(n1);
            //}


            //int p;

            //p = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= p; i++)
            //{
            //    long n = long.Parse(Console.ReadLine());


            //    long n1 = (n * (n + 1)) / 2;
            //    Console.WriteLine(n1);
            //}
            //    long  n2 = (n * (n + 1) * (2 * n + 1)) / 6;

            //  
            //}

            //int n;
            //n = int.Parse(Console.ReadLine());
            //for(int i=0; i<n; i++)
            //{
            //    int n1;
            //    n1 = int.Parse(Console.ReadLine());

            //    if (n1 >= 120)
            //    {
            //        Console.WriteLine("Good Boy Sifat");
            //    }
            //    else { Console.WriteLine("Naughty Boy Sifat"); }

            //}


            string s = Console.ReadLine();

            var s1 = s.Split(' ');
            var s2 = Convert.ToString(s1[0]);
            for(int i=0; i<s2.Length; i++)
            {
                if(s[i]>=65 && s2[i] <= 90)
                {
                    
                }


            }










                Console.ReadKey();


        }
    }
}
