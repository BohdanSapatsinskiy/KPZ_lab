using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._1ChainOfResponsibility
{
    class BasicSupport : SupportHandler
    {
        protected override bool ProcessRequest()
        {
            Console.WriteLine("Вас цікавить щось із загальних питань? (1 - Так, 2 - Ні)");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Вас з'єднано із базовою підтримкою.");
                return true;
            }
            return false;
        }
    }
}
