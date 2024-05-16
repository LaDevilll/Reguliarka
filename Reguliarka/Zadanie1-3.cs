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
                Regex regex4 = new Regex(@"^(?<lastName>[а-яА-Яa-zA-Z]+)\s+(?<firstName>[а-яА-Яa-zA-Z]+)(?:\s+(?<middleName>[а-яА-Яa-zA-Z]+))?,\s+(?<age>[1-9]\d*)\s+(?:лет|года|год)(?:,\s+г\.\s+(?<city>[а-яА-Яa-zA-Z\s]+))?");
                string line = input[i];
                Match userMatch = regex4.Match(line);
                if (userMatch.Success)
                {
                    string lastName = userMatch.Groups["lastName"].Value;
                    string age = userMatch.Groups["age"].Value;
                    string city = userMatch.Groups["city"].Value;

                    Console.WriteLine($"Город: {city}");
                    Console.WriteLine($"Фамилия: {lastName}");
                    Console.WriteLine($"Возраст: {age}");
                }
                else
                {
                    if (regex1.IsMatch(line) || regex2.IsMatch(line) || regex3.IsMatch(line))
                    {
                        Console.WriteLine("ОК!");
                    }
                    else
                    {
                        Console.WriteLine("Не найдено-_-");
                    }
                }
            }
        }

    }
}
