using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            for (int l = 1; l <= 8; l++)
            {
                s = "";
                for (int c = 1; c <= 8; c++)
                {
                    if ((c+l)%2==0) 
                        s = s + "X";
                    else
                        s = s + "O";
                }
                Console.WriteLine(s);
            }
        }
    }
}
