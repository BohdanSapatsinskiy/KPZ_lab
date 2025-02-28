namespace KPZ_lab1
{
    public class Enclosure
    {
        private int size;
        private string type;

        public int Size
        {
            get => size;
            set
            {
                if (value > 0)
                {
                    size = value;
                    Type = GetEnclosureType(size);
                }
                else
                {
                    Console.WriteLine("Розмір вольєра повинен бути більше нуля.");
                }
            }
        }

        public string Type
        {
            get => type;
            private set => type = value;
        }

        private string GetEnclosureType(int size)
        {
            switch (size)
            {
                case int n when (n >= 1 && n <= 20):
                    return "Малий";
                case int n when (n >= 21 && n <= 50):
                    return "Середній";
                case int n when (n >= 51 && n <= 100):
                    return "Великий";
                default:
                    return "Не визначено";
            }
        }
    }


}
