namespace KPZ_lab2
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }
        public ICharacterBuilder SetType(string type)
        {
            _character.Type = type;
            return this;
        }
        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            _character.Inventory = inventory;
            return this;
        }
        public ICharacterBuilder SetReligion(string religion)
        {
            _character.Religion = religion;
            return this;
        }
        public ICharacterBuilder SetArmor(string armor)
        {
            _character.Armor = armor;
            return this;
        }
        public ICharacterBuilder SetWeapon(string weapon)
        {
            _character.Weapon = weapon;
            return this;
        }

        public ICharacterBuilder SetAttributes(CharacterAttributes attributes)
        {
            _character.Attributes = attributes;
            return this;
        }
        public Character Build()
        {
            return _character;
        }
    }


    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }
        public ICharacterBuilder SetType(string type)
        {
            _character.Type = type;
            return this;
        }
        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            _character.Inventory = inventory;
            return this;
        }
        public ICharacterBuilder SetReligion(string religion)
        {
            _character.Religion = religion;
            return this;
        }
        public ICharacterBuilder SetArmor(string armor)
        {
            _character.Armor = armor;
            return this;
        }
        public ICharacterBuilder SetWeapon(string weapon)
        {
            _character.Weapon = weapon;
            return this;
        }
        public ICharacterBuilder SetAttributes(CharacterAttributes attributes)
        {
            _character.Attributes = attributes;
            return this;
        }
        public Character Build()
        {
            return _character;
        }
    }

    public class CharacterDirector
    {
        public Character CreateHero(HeroBuilder builder)
        {
            return builder.SetName("Ловчий Ночі")
                          .SetType("Стервятник")
                          .SetInventory(new List<string> { "Парні клинки", "Легка броня" })
                          .SetReligion("Нічна богиня")
                          .SetArmor("Легка броня зі шкіри")
                          .SetWeapon("Парні клинки")
                          .SetAttributes(new CharacterAttributes { Height = 1.75f, Strength = 65, Agility = 90, Stealth = 100 })
                          .Build();
        }

        public Character CreateEnemy(EnemyBuilder builder)
        {
            return builder.SetName("Драконячий Маг")
                          .SetType("Темний маг")
                          .SetInventory(new List<string> { "Драконячий посох", "Темна мантія" })
                          .SetReligion("Древня магія драконів")
                          .SetArmor("Темна мантія")
                          .SetWeapon("Драконячий посох")
                          .SetAttributes(new CharacterAttributes { Height = 2.0f, Strength = 70, Agility = 50, MagicPower = 120 })
                          .Build();
        }
    }
}
