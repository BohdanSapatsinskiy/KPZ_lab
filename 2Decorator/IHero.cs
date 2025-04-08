using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab3._2Decorator
{
    public interface IHero
    {
        string GetDescription();
        int Strength { get; }
        int Agility { get; }
        int Wisdom { get; }
        int Charisma { get; }
    }

}
