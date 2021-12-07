using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        //fields 
        private int goodGuyDamage;
        private int badGuyDamage;
        private int damage;

        // Damage 'Property'
        public int Damage 
        {
            get
            {
                return damage;
            }
                  
        }

        // Weapon Constructor
               
        public Weapon(Faction faction) // depending on 'GoodGuy' 'BadGuy'
                                       // .. will determine the weapon
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = goodGuyDamage;
                    break;
                case Faction.BadGuy:
                    damage = badGuyDamage;
                    break;
                default:
                    break;
            }

        }
    }
}
