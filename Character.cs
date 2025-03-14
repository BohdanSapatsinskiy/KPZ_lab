namespace KPZ_lab2
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetType(string type);
        ICharacterBuilder SetInventory(List<string> inventory);
        ICharacterBuilder SetReligion(string religion);
        ICharacterBuilder SetArmor(string armor);
        ICharacterBuilder SetWeapon(string weapon);
        ICharacterBuilder SetAttributes(CharacterAttributes attributes);
        Character Build();
    }
    public class CharacterAttributes
    {
        public float Height { get; set; }
        public float Strength { get; set; }
        public float Agility { get; set; }
        public float Stealth { get; set; }
        public float MagicPower { get; set; }
    }
    public class Character
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<string> Inventory { get; set; }
        public string Religion { get; set; }
        public string Armor { get; set; }
        public string Weapon { get; set; }
        public CharacterAttributes Attributes { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Religion: {Religion}");
            Console.WriteLine($"Armor: {Armor}, Weapon: {Weapon}");
            Console.WriteLine($"Attributes: Height: {Attributes.Height}, Strength: {Attributes.Strength}, Agility: {Attributes.Agility}, Stealth: {Attributes.Stealth}, MagicPower: {Attributes.MagicPower}");
            Console.WriteLine($"Inventory: {string.Join(", ", Inventory)}");
        }
    }
}
