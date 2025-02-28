namespace KPZ_lab1
{
    public abstract class Employee
    {
        private string name;
        private int age;
        private string gender;
        private string phone;
        private double salary;
        private string position;

        public Employee(string name, int age, string gender, string phone)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Phone = phone;
        }

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
                if (value >= 18)
                    age = value;
                else
                    Console.WriteLine("Вік працівника має бути більше або дорівнювати 18.");
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

        public string Phone
        {
            get => phone;
            set
            {
                if (value.Length <= 13 && value.Length >= 7)
                    phone = value;
                else
                    Console.WriteLine("Не вірна довжина номера телефону.");
            }
        }

        public double GetSalary() => salary;

        public string Position
        {
            get => position;
            protected set => position = value;
        }

        public void SetSalary(double rate)
        {
            if (rate > 0)
                this.salary = rate;
            else
                Console.WriteLine("Зарплата повинна бути більше нуля.");
        }
    }


    public class Feeder : Employee
    {
        public Feeder(string name, int age, string gender, string phone)
            : base(name, age, gender, phone) 
        {
            this.Position = "Годувальник";
            this.SetSalary(5000);
        }
    }

    public class Cleaner : Employee
    {
        public Cleaner(string name, int age, string gender, string phone)
            : base(name, age, gender, phone)  
        {
            this.Position = "Прибиральник";
            this.SetSalary(4000);
        }
    }


    public class Supervisor : Employee
    {
        public Supervisor(string name, int age, string gender, string phone)
            : base(name, age, gender, phone)
        {
            this.Position = "Наглядач";
            this.SetSalary(7000);
        }
    }
}
