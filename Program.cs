using KPZ_lab4._1ChainOfResponsibility;
using KPZ_lab4._2Mediator;
using KPZ_lab4._5Memento;

namespace KPZ_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            
            //Завдання 1
            Console.WriteLine("Вітаємо в системі підтримки користувачів!");
            SupportSystem.StartSupport();

            
            //Завдання 2
            var runway1 = new Runway();
            var runway2 = new Runway();

            var commandCentre = new CommandCentre(new[] { runway1, runway2 });

            var aircraft1 = new Aircraft("FlyingPegasus", commandCentre);
            var aircraft2 = new Aircraft("Hydra", commandCentre);

            aircraft1.RequestLanding();
            aircraft2.RequestLanding();

            aircraft1.RequestTakeOff();
            aircraft2.RequestTakeOff();


            //Завдання 5
            var doc = new TextDocument();
            var editor = new TextEditor(doc);

            editor.Type("Hello world!\n");
            editor.ShowDocument();

            editor.Type("How are you?\n");
            editor.ShowDocument();

            editor.Type("What are you doing?\n");
            editor.ShowDocument();

            Console.WriteLine("\nСкасування останньої зміни.");
            editor.Undo();
            editor.ShowDocument();

            Console.WriteLine("\nСкасування ще одної зміни.");
            editor.Undo();
            editor.ShowDocument();
        }
    }
}
