using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Field
    {
        protected string name;
        protected string slug;
        public Action onEnter;
        public Action onPass;

        public Field(string _name, string _slug)
        {
            name = _name;
            slug = _slug;
            onEnter += () =>
            {
                Console.WriteLine(MonopolyGame.currentPlayer.getName() + " wkracza do " + name);
            };

            onPass += () =>
            {
                Console.WriteLine(MonopolyGame.currentPlayer.getName() + " przechodzi obok " + name);
            };
        }

        public string getName()
        {
            return name;
        }
        public string getSlug()
        {
            return slug;
        }
    }

    class StartField : Field
    {
        public StartField(string _name, string _slug) : base(_name, _slug)
        {
            onEnter += () =>
            {
                MonopolyGame.currentPlayer.earn(settings.startFieldMoney);
            };

            onPass += () =>
            {
                MonopolyGame.currentPlayer.earn(settings.startFieldMoney);
            };
        }
    }

    public enum PropertyGroup
    {
        Brown,
        LightBlue,
        Pink,
        Orange,
        Red,
        Yellow,
        Green,
        Blue,
        Airport,
        Media
    }

    public class BasePropertyField : Field
    {
        protected Player owner;
        protected PropertyGroup group;

        protected int basicCost;
        protected int[] earnArray;
        protected int housesCount;
        protected int mortageValue;

        public BasePropertyField(string _name, string _slug, PropertyGroup _group, int _basicCost, int _mortageValue, int[] _earnArray) : base(_name, _slug)
        {
            owner = null;
            group = _group;
            basicCost = _basicCost;
            earnArray = _earnArray;
            mortageValue = _mortageValue;
            housesCount = 0;

            onEnter += () =>
            {
                if (MonopolyGame.currentPlayer == owner)
                {
                    Console.WriteLine(MonopolyGame.currentPlayer.getName() + ", ta nieruchomość należy do ciebie.");
                    return;
                }
                if (owner == null)
                {
                    Console.WriteLine(MonopolyGame.currentPlayer.getName() + " moze kupić " + name);
                    Console.WriteLine("Masz: " + MonopolyGame.currentPlayer.getMoney() + " zł");
                    Console.WriteLine("Koszt zakupu: " + basicCost + " zł");
                    Console.WriteLine("Kup - k\nAnuluj - a");
                    while (true)
                    {
                        string choice = Console.ReadLine();
                        if (choice == "k")
                        {
                            MonopolyGame.currentPlayer.buyProperty(this);
                            if (group == PropertyGroup.Airport)
                            {
                                List<BasePropertyField> airports = MonopolyGame.currentPlayer.getProperties().FindAll(x => x.group == PropertyGroup.Airport);
                                foreach (var item in airports)
                                {
                                    item.housesCount = airports.Count - 1;
                                }
                            }
                            else if (group == PropertyGroup.Media)
                            {
                                List<BasePropertyField> medias = MonopolyGame.currentPlayer.getProperties().FindAll(x => x.group == PropertyGroup.Media);
                                foreach (var item in medias)
                                {
                                    item.housesCount = medias.Count - 1;
                                }
                            }
                            break;
                        }
                        else if (choice == "a")
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(MonopolyGame.currentPlayer.getName() + " ta nieruchomość należy do " + owner.getName() + ".");
                    if (group == PropertyGroup.Media)
                    {
                        MonopolyGame.currentPlayer.pay(earnArray[housesCount] * MonopolyGame.lastRoll);
                        owner.earn(earnArray[housesCount] * MonopolyGame.lastRoll);
                    }
                    else
                    {
                        MonopolyGame.currentPlayer.pay(earnArray[housesCount]);
                        owner.earn(earnArray[housesCount]);
                    }
                }
            };
        }

        public int getBasicCost()
        {
            return basicCost;
        }

        public int getHousesCount()
        {
            return housesCount;
        }

        public void setOwner(Player player)
        {
            owner = player;
        }

        public void increaseHouseCount()
        {
            housesCount++;
        }

        public void resetHouseCount()
        {
            housesCount = 0;
        }
    }

    public class PropertyField : BasePropertyField
    {
        int houseCost;
        int hotelCost;

        public PropertyField(string _name, string _slug, PropertyGroup _group, int _basicCost, int _mortageValue, int[] _earnArray, int _houseCost, int _hotelCost) : base(_name, _slug, _group, _basicCost, _mortageValue, _earnArray)
        {
            houseCost = _houseCost;
            hotelCost = _hotelCost;
        }

        public int getHouseCost()
        {
            return houseCost;
        }

        public int getHotelCost()
        {
            return hotelCost;
        }
    }


    class TaxField : Field
    {
        int taxValue;

        public TaxField(string _name, string _slug, int _taxValue) : base(_name, _slug)
        {
            taxValue = _taxValue;

            onEnter += () =>
            {
                MonopolyGame.currentPlayer.pay(taxValue);
            };
        }
    }
    class CardField : Field
    {
        CardType type;

        public CardField(string _name, string _slug, CardType _type) : base(_name, _slug)
        {
            var random = new Random();
            type = _type;
            onEnter += () =>
            {
                Card x;
                switch (type)
                {
                    case CardType.Chance:
                        x = MonopolyGame.chanceCards[random.Next(0, MonopolyGame.chanceCards.Count)];
                        Console.WriteLine("SZANSA\n" + x.getDescription());
                        x.onDrawn();
                        break;
                    case CardType.CommunityCehst:
                        x = MonopolyGame.communityChestCards[random.Next(0, MonopolyGame.communityChestCards.Count)];
                        Console.WriteLine("KASA SPOŁECZNA\n" + x.getDescription());
                        x.onDrawn();
                        break;
                    default:
                        break;
                }
            };
        }
    }

    class JailedField : Field
    {
        public JailedField(string _name, string _slug) : base(_name, _slug)
        {
            onEnter += () =>
            {
                MonopolyGame.currentPlayer.jail(settings.jailTime);
            };
        }
    }
}
