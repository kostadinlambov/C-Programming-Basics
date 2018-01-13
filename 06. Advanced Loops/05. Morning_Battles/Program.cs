using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_20_11_2016_Morning_Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPokemonPlayer1 = int.Parse(Console.ReadLine());
            int numberPokemonPlayer2 = int.Parse(Console.ReadLine());
            int maxNumberBattles = int.Parse(Console.ReadLine());

            int cntBattles = 0;

            for (int i = 1; i <= numberPokemonPlayer1; i++)
            {
                for (int q = 1; q <= numberPokemonPlayer2; q++)
                {
                    cntBattles++;
                    Console.Write("({0} <-> {1}) ", i, q);
                    if (cntBattles==maxNumberBattles)
                    {
                        return;
                    }
                }
            }
        }
    }
}
