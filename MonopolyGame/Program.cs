using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            while (true)
            {
                Console.WriteLine("Ilu graczy?");
                string choice = Console.ReadLine();
                if (int.TryParse(choice, out count))
                {
                    if (count > 1)
                        break;
                }
            }
            List<string> players = new List<string>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Podaj imię gracza o numerze " + (i + 1) + ":");
                players.Add(Console.ReadLine());
            }

            MonopolyGame.INITIALIZE(players);
            MonopolyGame.Game();
        }
    }
}
