using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab3._2Decorator
{
    public class Warrior : IHero
    {
        public string GetDescription() => "Warrior";
        public int Strength => 15;
        public int Agility => 10;
        public int Wisdom => 5;
        public int Charisma => 7;
    }

    public class Mage : IHero
    {
        public string GetDescription() => "Mage";
        public int Strength => 4;
        public int Agility => 7;
        public int Wisdom => 16;
        public int Charisma => 10;
    }

    public class Palladin : IHero
    {
        public string GetDescription() => "Palladin";
        public int Strength => 12;
        public int Agility => 8;
        public int Wisdom => 10;
        public int Charisma => 14;
    }
}
