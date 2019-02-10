using System;

namespace dcp439
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int vowel = 0,n;
            n = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                string s;
                s =Console.ReadLine();
                
                for (int i = 0; i < s.Length; i++)
                {
                    
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    {
                        vowel++;

                    }


                }
                Console.WriteLine(vowel);
                vowel = 0;
               
                Console.ReadKey();
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
