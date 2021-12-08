using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor
    {
        // Armor Fields
        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;
        private int armorPoints;

        // ArmorPoints Property
        public int ArmorPoints 
        { 
            get
            {
                return armorPoints;
            }
          
        }
        // Armor Constructor
        public Armor(Faction faction) // depending on 'GoodGuy' 'BadGuy'
                                      // .. will determine the 'armor'
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }

        }
    }
}
