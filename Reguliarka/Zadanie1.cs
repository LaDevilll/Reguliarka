using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Reguliarka
{
    class Zadanie1
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"input.txt"); //чтение массива строк сделать для начал строки 
            for (int i = 0; i < input.Length; ++i)
            {
                Regex regex1 = new Regex(@"^a$|^a{6}$|^a\sa{2}\sa$");
                Regex regex2 = new Regex(@"^\w{5,}$");
                Regex regex3 = new Regex(@"^[\S\d]+@[\S\d]+\.\w{2,}$");
                string line = input[i];
                if (regex1.IsMatch(line) || regex2.IsMatch(line) || regex3.IsMatch(line))
                {
                    Console.WriteLine("ОК!");
                }
                else
                {
                    Console.WriteLine("Not ОК ☹");
                }
            }
        }

    }
}
