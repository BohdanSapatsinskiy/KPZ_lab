using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._2Mediator
{
    public class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        private IAirTrafficMediator mediator;

        public Aircraft(string name, IAirTrafficMediator mediator)
        {
            Name = name;
            this.mediator = mediator;
        }

        public void RequestLanding()
        {
            Console.WriteLine($"\nAircraft {Name} requests landing.");
            mediator.RequestLanding(this);
        }

        public void RequestTakeOff()
        {
            Console.WriteLine($"\nAircraft {Name} requests takeoff.");
            mediator.NotifyTakeOff(this);
        }
    }
}

