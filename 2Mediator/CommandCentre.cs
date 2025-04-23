using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._2Mediator
{
    public class CommandCentre : IAirTrafficMediator
    {
        private List<Runway> runways;

        public CommandCentre(IEnumerable<Runway> runways)
        {
            this.runways = runways.ToList();
        }

        public void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in runways)
            {
                if (runway.IsBusyWithAircraft == null)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed on Runway {runway.Id}.");
                    runway.IsBusyWithAircraft = aircraft;
                    runway.HighLightRed();
                    return;
                }
            }

            Console.WriteLine($"No runways available for Aircraft {aircraft.Name} to land.");
        }

        public void NotifyTakeOff(Aircraft aircraft)
        {
            var runway = runways.FirstOrDefault(r => r.IsBusyWithAircraft == aircraft);

            if (runway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off from Runway {runway.Id}.");
                aircraft.IsTakingOff = true;
                runway.IsBusyWithAircraft = null;
                runway.HighLightGreen();
                Console.WriteLine($"Aircraft {aircraft.Name} has taken off.");
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}
