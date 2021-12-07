using WarriorWars.Equipment; // Modified namespace, new 'Equipment Folder'
using WarriorWars.Enum; // Modified namespace, new 'Enum Folder'

namespace WarriorWars
{
    class Warrior
    {
        // Starting Health Values for Warriors;
        private int goodGuyStartingHealth;
        private int badGuyStartingHealth;

        //Faction - A good guy or a bad guy - using enumeratrion
        private Faction faction;

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
            this.faction = faction;
            isAlive = true;

            //Switch Case
            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon();
                    armor = new Armor();
                    health = goodGuyStartingHealth;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon();
                    armor = new Armor();
                    health = badGuyStartingHealth;
                    break;
                default:
                    break;
            }

        }
    }
}
