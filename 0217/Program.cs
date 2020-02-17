using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0217
{
    class Program
    {
        static void Main(string[] args)
        {
            string kocsi;
            StreamReader sr = new StreamReader("auto.csv");
            while ((kocsi = sr.ReadLine()) != null)
            {
                Console.WriteLine(kocsi); 
            }
            Console.ReadKey();
        }
    }
}
