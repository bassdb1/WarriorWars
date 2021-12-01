using WarriorWars.Enum;

namespace WarriorWars
{
    class Warrior
    {
        // Starting Health Values for Warriors
        private int goodGuyStartingHealth;
        private int badGUyStartingHealth;

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
    }
}
