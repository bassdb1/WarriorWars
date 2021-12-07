using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor
    {
        // Armor Fields
        private int goodGuyArmor;
        private int badGuyArmor;
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
                    armorPoints = goodGuyArmor;
                    break;
                case Faction.BadGuy:
                    armorPoints = badGuyArmor;
                    break;
                default:
                    break;
            }

        }
    }
}
