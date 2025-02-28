namespace KPZ_lab1
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;
        private string countryOfOrigin;

        public string Name
        {
            get => name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Ім'я не може бути порожнім.");
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Вік не може бути від'ємним.");
            }
        }

        public string Gender
        {
            get => gender;
            set
            {
                if (value == "Чоловіча" || value == "Жіноча")
                    gender = value;
                else
                    Console.WriteLine("Стать має бути або 'Чоловіча', або 'Жіноча'.");
            }
        }

        public string CountryOfOrigin
        {
            get => countryOfOrigin;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    countryOfOrigin = value;
                else
                    Console.WriteLine("Країна походження не може бути порожньою.");
            }
        }

        public abstract string Type { get; }
    }

    public class Carnivore : Animal
    {
        public override string Type => "М'ясоїдні";
    }

    public class Herbivore : Animal
    {
        public override string Type => "Травоїдні";
    }

    public class Omnivore : Animal
    {
        public override string Type => "Всеїдні";
    }
}
