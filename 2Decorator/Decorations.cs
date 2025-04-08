using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab3._2Decorator
{
    public class Sword : HeroDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sword";
        }

        public override int Strength => base.Strength + 5;
    }
    public class Armor : HeroDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Armor";
        }

        public override int Strength => base.Strength + 2;
        public override int Agility => base.Agility + 3;
    }
    public class Artifact : HeroDecorator
    {
        public Artifact(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Magic Artifact";
        }

        public override int Wisdom => base.Wisdom + 5;
        public override int Charisma => base.Charisma + 4;
    }
}
