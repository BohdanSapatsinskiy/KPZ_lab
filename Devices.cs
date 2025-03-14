namespace KPZ_lab2
{
    public abstract class Devices
    {
        protected string Brand;
        protected string Type;

        public Devices(string brand, string type)
        {
            Brand = brand;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Type} від {Brand}";
        }
    }
    public class Laptop : Devices
    {
        public Laptop(string brand) : base(brand, "Ноутбук") { }
    }

    public class Smartphone : Devices
    {
        public Smartphone(string brand) : base(brand, "Смартфон") { }
    }
    public class Tablet : Devices
    {
        public Tablet(string brand) : base(brand, "Планшет") { }
    }

    // Інтерфейс фабрики
    public interface IDeviceFactory
    {
        Laptop CreateLaptop();
        Smartphone CreateSmartphone();
        Tablet CreateTablet();
    }

    // Різновиди фабрик
    public class IProneFactory : IDeviceFactory
    {
        public Laptop CreateLaptop()
        {
            return new Laptop("IProne");
        }
        public Smartphone CreateSmartphone()
        {
            return new Smartphone("IProne");
        }
        public Tablet CreateTablet()
        {
            return new Tablet("IProne");
        }
    }

    public class KiaomiFactory : IDeviceFactory
    {
        public Laptop CreateLaptop()
        {
            return new Laptop("Kiaomi");
        }
        public Smartphone CreateSmartphone()
        {
            return new Smartphone("Kiaomi");
        } 
        public Tablet CreateTablet()
        {
            return new Tablet("Kiaomi");
        }
    }

    public class BalaxyFactory : IDeviceFactory
    {
        public Laptop CreateLaptop()
        {
            return new Laptop("Balaxy");
        }
        public Smartphone CreateSmartphone()
        {
            return new Smartphone("Balaxy");
        }
        public Tablet CreateTablet()
        {
            return new Tablet("Balaxy");
        }
    }    
}
