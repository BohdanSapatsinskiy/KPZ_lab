namespace KPZ_lab2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Завдання 1: Фабричний метод");

            SubscriptionFabric website = new WebSite();
            SubscriptionFabric mobileApp = new MobileApp();
            SubscriptionFabric managerCall = new ManagerCall();

            Subscription mySub1 = website.CreateSubscription();
            Subscription mySub2 = mobileApp.CreateSubscription();
            Subscription mySub3 = managerCall.CreateSubscription();

            Console.WriteLine(mySub1);
            Console.WriteLine(mySub2);
            Console.WriteLine(mySub3);


            Console.WriteLine();
            Console.WriteLine("Завдання 2: Абстрактна фабрика");

            IDeviceFactory iproneFactory = new IProneFactory();
            IDeviceFactory kiaomiFactory = new KiaomiFactory();
            IDeviceFactory balaxyFactory = new BalaxyFactory();

            Devices laptop1 = iproneFactory.CreateLaptop();
            Devices smartphone1 = kiaomiFactory.CreateSmartphone();
            Devices ebook1 = balaxyFactory.CreateTablet();

            Console.WriteLine(laptop1);
            Console.WriteLine(smartphone1);
            Console.WriteLine(ebook1);


            Console.WriteLine();
            Console.WriteLine("Завдання 3: Одинак");
            var authenticator1 = Authenticator.Instance;
            var authenticator2 = Authenticator.Instance;

            // Перевірка, що створено однакові обєкти
            Console.WriteLine(ReferenceEquals(authenticator1, authenticator2));
            authenticator1.Authenticate();


            Console.WriteLine();
            Console.WriteLine("Завдання 4: Прототип");
            Virus virus1 = new Virus("Virus A", 2, 1.0, "ГРВІ");

            Virus child1 = new Virus("Virus AA", 3, 1.2, "ГРВІ");

            Virus childChild1 = new Virus("Virus AAA", 4, 1.6, "ГРВІ");

            child1.AddChild(childChild1);
            virus1.AddChild(child1);

            Console.WriteLine("Початковий вірус:");
            virus1.DisplayInfo();

            Virus clonedVirus1 = (Virus)virus1.Clone();
            Console.WriteLine("Клонований вірус:");
            clonedVirus1.DisplayInfo();



            Console.WriteLine();
            Console.WriteLine("Завдання 5: Будівельник");
            var director = new CharacterDirector();

            var hero = director.CreateHero(new HeroBuilder());
            hero.DisplayInfo();

            var enemy = director.CreateEnemy(new EnemyBuilder());
            enemy.DisplayInfo();
        }
    }
}
