using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab3._2Decorator
{
    public abstract class HeroDecorator : IHero
    {
        protected IHero _hero;

        public HeroDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual string GetDescription()
        {
            return _hero.GetDescription();
        }

        public virtual int Strength => _hero.Strength;
        public virtual int Agility => _hero.Agility;
        public virtual int Wisdom => _hero.Wisdom;
        public virtual int Charisma => _hero.Charisma;
    }

}
