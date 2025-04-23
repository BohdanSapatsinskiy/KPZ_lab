using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._2Mediator
{
    public interface IAirTrafficMediator
    {
        void RequestLanding(Aircraft aircraft);
        void NotifyTakeOff(Aircraft aircraft);
    }
}
