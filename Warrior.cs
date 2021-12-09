using WarriorWars.Equipment; // Modified namespace, new 'Equipment Folder'
using WarriorWars.Enum; // Modified namespace, new 'Enum Folder'

namespace WarriorWars
{
    class Warrior
    {
        // Starting Health Values for Warriors;
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;

        //Faction - A good guy or a bad guy - using enumeratrion
        // .. readonly = a constant that is 'defined' at runtime'
        // .. this constant will be 'set' when we create a 'Warrior'
        private readonly Faction FACTION;

        // Fields
        private int health;
        private string name;
        private bool isAlive;

        // IsAlive Property
        public bool IsAlive
        {
            // I am only 'getting' value so I only need a 'get'
           
            get
            {
                return isAlive;
            }
        
        }

        // Going to use the class 'Weapon' to get the 'field' weapon
        private Weapon weapon;

        // Going to use the class 'Armor' to get the 'armor' weapon
        private Armor armor;

        // Warrior Constructor
        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;

            //Switch Case
            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }

        }
    }
}
