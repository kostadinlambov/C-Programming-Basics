﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();

            if (word1.ToLower()==word2.ToLower())
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
