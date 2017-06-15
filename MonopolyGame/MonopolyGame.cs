using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public static class MonopolyGame
    {
        public static List<Field> allFields;
        public static List<Player> players;
        public static List<Card> chanceCards;
        public static List<Card> communityChestCards;

        public static int availableHouses;
        public static int availableHotels;
        public static Player currentPlayer;
        public static int lastRoll;

        public static void INITIALIZE(List<string> _players)
        {
            allFields = new List<Field>();
            DataInitializer.initializeFields();
            players = new List<Player>();
            DataInitializer.initializePlayers(_players);
            availableHouses = settings.maxHouses;
            availableHotels = settings.maxHotels;
            chanceCards = new List<Card>();
            DataInitializer.initializeChanceCards();
            communityChestCards = new List<Card>();
            DataInitializer.initializeCommunityChestCards();
        }       

        public static void Game()
        {
            while (true)
            {
                int removed = 0;
                Player winner = null;
                foreach (var player in players)
                {
                    if (player.isRemoved())
                        removed++;
                    else
                        winner = player;
                }

                if(removed == players.Count - 1)
                {
                    Console.Clear();
                    Console.WriteLine(winner.getName() + " wygrał grę!\n\nWciśnij enter zaby zakończyć.");
                    Console.ReadLine();
                    break;
                }
                
                foreach (var player in players)
                {
                    if (player.isRemoved())
                        continue;

                    if(player.isJailed())
                        goto END_TURN;

                    currentPlayer = player;
                    Console.Clear();
                    Console.WriteLine("Tura gracza: " + currentPlayer.getName());
                    Console.WriteLine("Twoje pieniądze: " + currentPlayer.getMoney() + " zł");
                    int roll = player.roll2d6();
                    lastRoll = roll;
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(currentPlayer.getName() + " rzuca " + roll);
                    Console.WriteLine();
                    player.walkTo(roll);

                    if (player.getMoney() < 0)
                    {
                        Console.WriteLine(currentPlayer.getName() + " zbankrutował!");
                        player.removePlayer();
                        goto END_TURN;
                    }

                    if(player.isJailed())
                    {
                        goto END_TURN;
                    }

                    System.Threading.Thread.Sleep(1000);
                    if(currentPlayer.getProperties().Count > 0)
                    {
                        while (true)
                        {
                            Console.WriteLine("Ulepszanie nieruchomości: ");
                            int i = 0;
                            foreach (var item in currentPlayer.getProperties())
                            {
                                string level = "";
                                for (int j = 0; j < item.getHousesCount(); j++)
                                {
                                    level += "[X]";
                                }
                                for (int j = item.getHousesCount(); j < 5; j++)
                                {
                                    level += "[ ]";
                                }
                                if (item.GetType() == typeof(PropertyField))
                                    Console.WriteLine(i + ": " + item.getName() + " | " + level);
                                i++;
                            }
                            Console.WriteLine("a - anuluj");

                            string choice = Console.ReadLine();
                            int index = -1;
                            if (choice == "a")
                            {
                                break;
                            }
                            else if (int.TryParse(choice, out index))
                            {
                                PropertyField property =(PropertyField) currentPlayer.getProperties()[index];
                                if (property.getHousesCount() < 4)
                                {
                                    Console.WriteLine("Masz " + property.getHousesCount() + " apartamentów na tej nieruchomości. Zbudować apartament za " + property.getHouseCost() + "?\n t - tak, n - nie");
                                    while (true)
                                    {
                                        choice = Console.ReadLine();
                                        if (choice == "n")
                                        {
                                            break;
                                        }
                                        if (choice == "t")
                                        {
                                            currentPlayer.pay(property.getHouseCost());
                                            property.increaseHouseCount();
                                            if (player.getMoney() < 0)
                                            {
                                                Console.WriteLine(currentPlayer.getName() + " zbankrutował!");
                                                player.removePlayer();
                                                goto END_TURN;
                                            }
                                            break;
                                        }
                                    }
                                }
                                else if (property.getHousesCount() == 4)
                                {
                                    Console.WriteLine("Masz " + property.getHousesCount() + " apartamentów na tej nieruchomości. Zbudować hotel za " + property.getHotelCost() + "?\n t - tak, n - nie");
                                    while (true)
                                    {
                                        choice = Console.ReadLine();
                                        if (choice == "n")
                                        {
                                            break;
                                        }
                                        if (choice == "t")
                                        {
                                            currentPlayer.pay(property.getHotelCost());
                                            property.increaseHouseCount();
                                            if (player.getMoney() < 0)
                                            {
                                                Console.WriteLine(currentPlayer.getName() + " zbankrutował!");
                                                player.removePlayer();
                                                goto END_TURN;
                                            }
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Na tej nieruchomości jest już hotel.");
                                }
                            }
                        }
                    }
                END_TURN:
                    Console.WriteLine("Wciśnij enter aby zakończyć kolejkę!");
                    Console.ReadLine();
                    Console.WriteLine(currentPlayer.getName() + " kończy turę!");
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}
