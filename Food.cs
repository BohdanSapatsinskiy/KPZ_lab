namespace KPZ_lab1
{
    public abstract class Food
    {
        private string name;
        private string manufacturer;
        private DateTime expirationDate;
        private double quantity;

        public string Name
        {
            get => name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Назва корму не може бути порожньою.");
            }
        }

        public string Manufacturer
        {
            get => manufacturer;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    manufacturer = value;
                else
                    Console.WriteLine("Виробник не може бути порожнім.");
            }
        }

        public DateTime ExpirationDate
        {
            get => expirationDate;
            set
            {
                if (value >= DateTime.Now)
                    expirationDate = value;
                else
                    Console.WriteLine("Термін зберігання не може бути в минулому.");
            }
        }

        public double Quantity
        {
            get => quantity;
            set
            {
                if (value > 0)
                    quantity = value;
                else
                    Console.WriteLine("Кількість повинна бути більше нуля.");
            }
        }
    }


    public class Meat : Food
    {
        public Meat()
        {
            this.Name = "М'ясо";
        }
    }

    public class Vegetables : Food
    {
        public Vegetables()
        {
            this.Name = "Овочі";
        }
    }

    public class Feed : Food
    {
        public Feed()
        {
            this.Name = "Корм";
        }
    }

}
