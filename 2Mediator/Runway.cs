using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._2Mediator
{
    public class Runway
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Aircraft? IsBusyWithAircraft { get; set; }

        public bool IsActive()
        {
            return IsBusyWithAircraft != null && IsBusyWithAircraft.IsTakingOff;
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}

