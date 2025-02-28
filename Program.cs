namespace KPZ_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            Animal lion = new Carnivore
            {
                Name = "Лев",
                Age = 5,
                Gender = "Чоловіча",
                CountryOfOrigin = "Африка"
            };
            Animal elephant = new Herbivore
            {
                Name = "Слон",
                Age = 10,
                Gender = "Жіноча",
                CountryOfOrigin = "Індія"
            };

            zoo.AddAnimal(lion);
            zoo.AddAnimal(elephant);


            Employee feeder = new Feeder("Іван", 30, "Чоловіча", "0671234567");
            Employee cleaner = new Cleaner("Марія", 28, "Жіноча", "0682345678");
            Employee supervisor = new Supervisor("Олександр", 35, "Чоловіча", "0953456789");

            zoo.AddEmployee(feeder);
            zoo.AddEmployee(cleaner);
            zoo.AddEmployee(supervisor);


            Enclosure smallEnclosure = new Enclosure { Size = 15 };
            Enclosure largeEnclosure = new Enclosure { Size = 80 };

            zoo.AddEnclosure(smallEnclosure);
            zoo.AddEnclosure(largeEnclosure);


            Food meat = new Meat
            {
                Manufacturer = "Виробник 1",
                ExpirationDate = DateTime.Now.AddMonths(2),
                Quantity = 50
            };
            Food vegetables = new Vegetables
            {
                Manufacturer = "Виробник 2",
                ExpirationDate = DateTime.Now.AddMonths(1),
                Quantity = 30
            };

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            zoo.AddFood(meat);
            zoo.AddFood(vegetables);

            zoo.DisplayInfo();
        }
    }
}
