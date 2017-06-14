using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Player
    {
        string name;
        int money;
        List<BasePropertyField> properties;
        uint currentJailTime;
        Field currentField;
        int JailCards;
        bool removedFromGame;

        public Player(string _name)
        {
            name = _name;
            properties = new List<BasePropertyField>();
            money = settings.startingMoney;
            currentField = MonopolyGame.allFields[0];
            removedFromGame = false;
        }

        public string getName()
        {
            return name;
        }

        public int getMoney()
        {
            return money;
        }

        public void earn(int howMuch)
        {
            money += howMuch;
            Console.WriteLine(name + " dostaje " + howMuch + " zł");
            Console.WriteLine(name + " ma " + money + " zł");
        }

        public void pay(int howMuch)
        {
            money -= howMuch;
            Console.WriteLine(name + " płaci " + howMuch + " zł");
            Console.WriteLine(name + " ma " + money + " zł");            
        }

        public void jail(uint jailTime)
        {
            currentJailTime = jailTime;
        }

        public int roll2d6()
        {
            Random roll = new Random();
            int roll1 = roll.Next(1, 7);
            int roll2 = roll.Next(1, 7);

            return roll1 + roll2;
        }

        public List<BasePropertyField> getProperties()
        {
            return properties;
        }

        public void walkTo(Field field)
        {
            int currentIndex = MonopolyGame.allFields.FindIndex(x => x == currentField);
            int goalIndex = MonopolyGame.allFields.FindIndex(x => x == field);

            if (goalIndex < currentIndex)
            {
                for (int i = currentIndex + 1; i < MonopolyGame.allFields.Count; i++)
                {
                    MonopolyGame.allFields[i].onPass();
                    System.Threading.Thread.Sleep(500);
                }

                for (int i = 0; i < goalIndex; i++)
                {
                    MonopolyGame.allFields[i].onPass();
                    System.Threading.Thread.Sleep(500);
                }
            }
            else
            {
                for (int i = currentIndex + 1; i < goalIndex; i++)
                {
                    MonopolyGame.allFields[i].onPass();
                    System.Threading.Thread.Sleep(500);
                }
            }
            currentField = field;
            Console.WriteLine();
            field.onEnter();
        }

        public void walkTo(int steps)
        {
            int currentIndex = MonopolyGame.allFields.FindIndex(x => x == currentField);
            int goalIndex, first;
            if (currentIndex + steps > MonopolyGame.allFields.Count - 1)
            {
                first = MonopolyGame.allFields.Count - 1 - currentIndex;
                goalIndex = steps - first - 1;
            }
            else
                goalIndex = currentIndex + steps;
            walkTo(MonopolyGame.allFields[goalIndex]);        
        }

        public void buyProperty(BasePropertyField property)
        {
            pay(property.getBasicCost());
            properties.Add(property);
            property.setOwner(this);
        }

        public void skipTo(Field field)
        {
            field.onEnter();
            currentField = field;
        }

        public void drawnNoJailCard()
        {
            JailCards++;
        }

        public void removePlayer()
        {
            removedFromGame = true;
            foreach (var item in properties)
            {
                item.setOwner(null);
                item.resetHouseCount();
            }
        }

        public bool isRemoved()
        {
            return removedFromGame;
        }

        public bool progressJail()
        {
            if (currentJailTime > 0)
            {
                if (JailCards > 0)
                {
                    JailCards--;
                    Console.WriteLine(name + " używa karty wyjścia z więzienia.");
                    currentJailTime = 0;
                    return false;
                }
                Console.WriteLine(name + " spędza rundę w więzieniu.");
                currentJailTime--;
                return true;
            }
            return false;
        }

        public bool isJailed()
        {
            if (currentJailTime > 0)
                return true;
            return false;
        }
    }
}
