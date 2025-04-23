using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._1ChainOfResponsibility
{
    class AdvancedSupport : SupportHandler
    {
        protected override bool ProcessRequest()
        {
            Console.WriteLine("Вам потрібна допомога з нестандартним або критичним запитом? (1 - Так, 2 - Ні)");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Вас з'єднано з фахівцем високого рівня.");
                return true;
            }
            return false;
        }
    }
}
