using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blatte_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //this program shows on the console the number of Prime numbers in a specific intervals  :))
            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|" + " Intervall " + " | " + "Anzahl"+" | ");
            Console.WriteLine("+-----------+-----------|");
            int st;
            int en;
            Prime(st = 0, en = 1000); //Prime is the Method below
            Prime(st = 1000, en = 2000);
            Prime(st = 2000, en = 3000);
            Prime(st = 3000, en = 4000);
            Prime(st = 4000, en = 5000);
            Prime(st = 5000, en = 6000);
            Prime(st = 6000, en = 7000);
            Prime(st = 7000, en = 8000);
            Prime(st = 8000, en = 9000);
            Prime(st = 9000, en = 10000);
            Prime(st = 10000, en = 11000);
            Prime(st = 11000, en = 12000);
            Prime(st = 12000, en = 13000);
            Prime(st = 13000, en = 14000);
            Prime(st = 14000, en = 15000);
            Prime(st = 15000, en = 16000);
            Prime(st = 16000, en = 17000);
            Prime(st = 17000, en = 18000);
            Prime(st = 18000, en = 19000);
            Prime(st = 19000, en = 20000);
            Prime(st = 20000, en = 21000);
            Prime(st = 21000, en = 22000);
            Prime(st = 22000, en = 23000);
            Prime(st = 23000, en = 24000);
            Prime(st = 24000, en = 25000);
            Prime(st = 25000, en = 26000);
            Prime(st = 26000, en = 27000);
            Prime(st = 27000, en = 28000);
            Prime(st = 28000, en = 29000);
            Prime(st = 29000, en = 30000);
            Console.WriteLine("+-----------+-----------+");

            Console.ReadLine();

        }
            
            
        
        static void  Prime( int st=0 , int en=1000)
        {
            
            int cnt = 0; 
            List<int> isprime = new List<int>();
            for (int i = st; i < en; i++)
            {
                for (int j = 1; j < en; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt == 2)
                {
                    isprime.Add(i);
                }
                cnt = 0;

            }
            Console.WriteLine("|"+"["+ st +"," + en +"]" + " | " + isprime.Count + "   |   "  );
            





        }
        
    }
    
}

