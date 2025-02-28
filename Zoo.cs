namespace KPZ_lab1
{
    public class Zoo
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Enclosure> Enclosures { get; set; } = new List<Enclosure>();
        public List<Food> Foods { get; set; } = new List<Food>();

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);
        }

        public void AddFood(Food food)
        {
            Foods.Add(food);
        }

        public void DisplayInfo()
        {

            Console.WriteLine("Тварини:");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"- {animal.Name}, {animal.Age} років, {animal.Gender}, {animal.CountryOfOrigin}, Тип: {animal.Type}");
            }


            Console.WriteLine("\nПрацівники:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"- {employee.Name}, {employee.Age} років, {employee.Gender}, Посада: {employee.Position}, Телефон: {employee.Phone}, Зарплата: {employee.GetSalary()}");
            }


            Console.WriteLine("\nВольєри:");
            foreach (var enclosure in Enclosures)
            {
                Console.WriteLine($"- {enclosure.Type}, Розмір: {enclosure.Size} м²");
            }


            Console.WriteLine("\nЇжа:");
            foreach (var food in Foods)
            {
                Console.WriteLine($"- {food.Name}, Виробник: {food.Manufacturer}, Кількість: {food.Quantity}, Термін зберігання: {food.ExpirationDate}");
            }
        }
    }
}
