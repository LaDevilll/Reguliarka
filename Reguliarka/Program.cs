using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Reguliarka
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"input.txt"); //чтение массива строк сделать для начал строки 
            for (int i = 0; i < input.Length; ++i)
            {
                Regex regex = new Regex(@"a aaaa ");
                
            }
        }

    }

}
