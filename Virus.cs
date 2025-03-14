namespace KPZ_lab2
{
    public class Virus: ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }


        public Virus(string name, int age, double weight, string type)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Type = type;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Virus clonedVirus = (Virus)this.MemberwiseClone();
            clonedVirus.Children = new List<Virus>();

            foreach (var child in Children)
            {
                clonedVirus.Children.Add((Virus)child.Clone());
            }

            return clonedVirus;
        }

        public void DisplayInfo(int level = 0)
        {
            Console.WriteLine(new string(' ', level * 2) + $"Ім'я: {Name}, Вік: {Age}, Вага: {Weight} кг, Тип: {Type}");

            foreach (var child in Children)
            {
                child.DisplayInfo(level + 1);
            }
        }

    }
}
