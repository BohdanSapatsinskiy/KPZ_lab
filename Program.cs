using KPZ_lab3._1Adapter;
using KPZ_lab3._2Decorator;
using KPZ_lab3._3Bridge;
using KPZ_lab3._4Proxy;
using KPZ_lab3.Composit;
using KPZ_lab3.Flyweight;

namespace KPZ_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Завдання 1
            Console.WriteLine("Завдання 1");
            Logger cLogger = new Logger();
            cLogger.Log("Повідомлення");
            cLogger.Error("Помилка");
            cLogger.Warn("Попередження");

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\log.txt");
            path = Path.GetFullPath(path);

            FileWriter writer = new FileWriter(path);
            ILogger fLogger = new FileLoggerAdapter(writer);
            fLogger.Log("Повідомлення");
            fLogger.Error("Помилка");
            fLogger.Warn("Попередження");


            Console.WriteLine();
            Console.WriteLine();
            //Завдання 2
            Console.WriteLine("Завдання 2");

            static void PrintStats(IHero hero)
            {
                Console.WriteLine($"Hero: {hero.GetDescription()}");
                Console.WriteLine($"  Strength: {hero.Strength}");
                Console.WriteLine($"  Agility: {hero.Agility}");
                Console.WriteLine($"  Wisdom: {hero.Wisdom}");
                Console.WriteLine($"  Charisma: {hero.Charisma}");
            }
            IHero palladin = new Palladin();
            palladin = new Sword(palladin);
            palladin = new Armor(palladin);
            PrintStats(palladin);

            IHero mage = new Mage();
            mage = new Armor(mage);
            mage = new Artifact(mage);
            PrintStats(mage);


            Console.WriteLine();
            Console.WriteLine();
            //Завдання 3
            Console.WriteLine("Завдання 3");

            IRenderer vector = new VectorRenderer();
            IRenderer raster = new RasterRenderer();

            Shape circle = new Circle(vector);
            Shape square = new Square(raster);
            Shape triangle = new Triangle(vector);

            circle.Draw(); 
            square.Draw();  
            triangle.Draw();


            Console.WriteLine();
            Console.WriteLine();
            //Завдання 4
            Console.WriteLine("Завдання 4");

            string logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\log_1.txt");
            string readFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\read.txt");

            Console.WriteLine("Перевірка роботи Checker-а");
            ITextReader checker = new SmartTextChecker();
            var text1 = checker.ReadFile(readFile);

            Console.WriteLine("Перевірка Locker-a для заблокованого файлу log");
            ITextReader lockerLogBlocked = new SmartTextReaderLocker(@"^log.*\.txt$");
            var text3 = lockerLogBlocked.ReadFile(logFile);

            Console.WriteLine("Перевірка Locker-a для дозволеного файлу");
            var text4 = lockerLogBlocked.ReadFile(readFile);


            Console.WriteLine();
            Console.WriteLine();
            //Завдання 5
            Console.WriteLine("Завдання 5");

            var h1Node = new LightElementNode("h1", false, false);
            h1Node.AddClass("tittle");
            var h1Text = new LightTextNode("Купити:");
            h1Node.AddChild(h1Text);

            var divNode = new LightElementNode("div", true, false);
            divNode.AddClass("block");

            List<string> products = new List<string> { "Молоко", "М'ясо", "Сир" };

            foreach (var product in products)
            {
                var productNode = new LightElementNode("p", false, false);
                productNode.AddClass("item");
                var productText = new LightTextNode(product);
                productNode.AddChild(productText);

                divNode.AddChild(productNode);
            }

            Console.WriteLine(h1Node.OuterHTML());
            Console.WriteLine(divNode.OuterHTML());


            Console.WriteLine();
            Console.WriteLine();
            //Завдання 6
            Console.WriteLine("Завдання 6");


            string[] lines = new string[]
            {
                "Фрагмент історії",
                "Розділ 2",
                "Новеллен завмер, не зводячи очей з чудовиська.",
                "Геральт повільно рушив убік, напружено вичікуючи.",
                "  Істота зникла, розчинившись у напівтемряві.  ",
                "Удар з-за спини — він встиг ухилитись в останню мить.",
                "Піруетом відскочив убік, зберігаючи дистанцію.",
                "Меч просвистів у повітрі, ледь торкнувшись шкіри монстра."
            };

            LightHTMLConverter converter = new LightHTMLConverter();

            long memoryBefore = GC.GetTotalMemory(true);
            Console.WriteLine($"Використана памя'ть до створення елементів: {memoryBefore / 1024} KB");

            var htmlNodes = converter.ConvertTextToHTML(lines);

            long memoryAfter = GC.GetTotalMemory(true);
            Console.WriteLine($"Використана пам'ять після створення елементів: {memoryAfter / 1024} KB");

            foreach (var node in htmlNodes)
            {
                Console.WriteLine(node.OuterHTML());
            }

            long memoryUsed = memoryAfter - memoryBefore;
            Console.WriteLine($"Використана пам'ять: {memoryUsed / 1024} KB");

            Console.WriteLine($"Кількість елементів: {htmlNodes.Count}");
        }
    }
}
