using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public enum CardType
    {
        Chance,
        CommunityCehst
    }
    public class Card
    {
        CardType type;
        string description;

        public Action onDrawn;

        public Card(CardType _type, string _description)
        {
            type = _type;
            description = _description;
        }

        public string getDescription()
        {
            return description;
        }
    }
}
