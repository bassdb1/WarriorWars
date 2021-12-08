using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        //fields 
        private const int GOOD_GUY_DAMAGE = 5 ;
        private int BAD_GUY_DAMAGE = 5;
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
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
                default:
                    break;
            }

        }
    }
}
