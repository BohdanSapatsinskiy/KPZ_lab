using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._1ChainOfResponsibility
{
    abstract class SupportHandler
    {
        protected SupportHandler next;

        public void SetNext(SupportHandler nextHandler)
        {
            next = nextHandler;
        }

        public void HandleRequest()
        {
            if (!ProcessRequest() && next != null)
            {
                next.HandleRequest();
            }
            else if (next == null)
            {
                Console.WriteLine("Не вдалося знайти відповідний рівень підтримки. Повторюємо меню...\n");
                SupportSystem.StartSupport();
            }
        }

        protected abstract bool ProcessRequest();
    }
}

