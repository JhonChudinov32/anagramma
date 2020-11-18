using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagramma
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите текст: ");
            var text = Console.ReadLine();
            var split = text.Split();
            var s = "";
            foreach (var item in split)
            {
                s += Reverse(item.ToList()) + " ";
            }
            Console.WriteLine($"{text} => {s}");
            Console.ReadLine();
        }

        private static string Reverse(List<char> word) 
        {
            var list = new List<(int ind, char ch)>();
            for (int i = 0; i < word.Count; i++)
            {
                if (!char.IsLetter(word[i]))
                {
                    list.Add((i, word[i]));
                }
            }
            foreach (var item in word.ToList())
            {
                if (!char.IsLetter(item))
                {
                    word.Remove(item);
                }
            }
            word.Reverse();
            foreach (var (ind, ch) in list)
            {
                word.Insert(ind, ch);
            }
            return string.Join("", word);
        }


    }
}
