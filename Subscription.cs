namespace KPZ_lab2
{
    public abstract class Subscription
    {
        protected string name;
        protected decimal monthlyFee;
        protected int minSubscriptionPeriod;
        protected List<string> channels;

        public string Name
        {
            get { return name; }
        }
        public decimal MonthlyFee
        {
            get { return monthlyFee; }
        }
        public int MinSubscriptionPeriod
        {
            get{ return minSubscriptionPeriod; }
        }
        public List<string> Channels
        {
            get { return channels; }
        }
        public override string ToString()
        {
            return $"{Name}: {MonthlyFee} грн/міс, Мін. період: {MinSubscriptionPeriod} міс, Канали: {string.Join(", ", Channels)}";
        }
    }
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            name = "Домашня підписка";
            monthlyFee = 150;
            minSubscriptionPeriod = 3;
            channels = new() { "Новини", "Розваги", "Кухня","Кіно" };
        }
    }

    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            name = "Освітня підписка";
            monthlyFee = 100;
            minSubscriptionPeriod = 6;
            channels = new() { "Наука", "Документальні", "Історія","Подорожі","Пригоди" };
        }
    }
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            name = "Преміум підписка";
            monthlyFee = 300;
            minSubscriptionPeriod = 1;
            channels = new() { "Кіно HD", "Спорт HD", "Новини HD", "Розваги HD", "Наука HD", "Документальні HD", "Історія HD", "Подорожі HD", "Пригоди HD" };
        }
    }

    //Фабрика
    public abstract class SubscriptionFabric
    {
        public abstract Subscription CreateSubscription();
    }

    //Елементи фабриком
    public class WebSite : SubscriptionFabric
    {
        public override Subscription CreateSubscription()
        {
            Console.WriteLine("Створення підписки через вебсайт.");
            return new DomesticSubscription();
        }
    }
    public class MobileApp : SubscriptionFabric
    {
        public override Subscription CreateSubscription()
        {
            Console.WriteLine("Створення підписки через мобільний додаток.");
            return new EducationalSubscription();
        }
    }
    public class ManagerCall : SubscriptionFabric
    {
        public override Subscription CreateSubscription()
        {
            Console.WriteLine("Створення підписки через дзвінок менеджера.");
            return new PremiumSubscription();
        }
    }
}
