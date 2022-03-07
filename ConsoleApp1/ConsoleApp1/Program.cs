using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sahe("ucbucaq",2,3,5,7,8,9));
            Console.ReadLine();
        }
        static int sahe(string ad, int a,int b,int c,int n,int m,int rad)
        {
            int s = 1;
            if (ad == "duzbucaqli")
            {
                s = m * n;
               
            }
            else if (ad == "cevre")
            {
              
                int p = 3;
                s = p * rad * rad;
               
            }
            else if (ad == "ucbucaq")
            {
              
                int p = (a + b + c) / 2;
                s = p * rad;
               
            }
             return s;  
        }
    }
}
