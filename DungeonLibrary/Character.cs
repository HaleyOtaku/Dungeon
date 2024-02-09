namespace DungeonLibrary
{
    //"abstract" indicates that this structure is "incomplete"
    //This is an inheritance-only class
    public abstract class Character
    {
        //name - string
        //max life - int
        //current life - int
        //equippedweapon - weapon - passed on to another class
        //inventory - collection - array
        //dodge/block/evade chance - int - (1-100)
        //hit chance - int - (1-100)

        //weapon
        //name - string
        //min damage - int
        //max damage - int
        //istwohanded - bool
        //bonus hit chance - can be added onto players base hit chance

        //If we want to make a Character, we have to use one of its subtypes (Player/Monster)

        //FIELDS
        private string _name = null!;
        // (null!) allows us to make something null while promising to pass a
        //value to it later, and removes green warning
        private int _maxLife;
        private int _life;
        private int _hitChance;
        private int _dodge;


        //PROPERTIES
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        
        }
        public int MaxLife //independent
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life //dependant on MaxLife
        {
            get { return _life; }
            set {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else {
                    _life = MaxLife;                
                }
            }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int Dodge
        {
            get { return _dodge; }
            set { _dodge = value; }
        }


        //COLLECT/CATCH/CONSTRUCTORS
        public Character(string name, int hitChance, int dodge, int maxLife)
        {
            //we did not account for Life in the parameter list because we're going to assign it manually.
            //Property = parameter
            //White = blue
            Name = name;
            HitChance = hitChance;
            Dodge = dodge;
            MaxLife = maxLife;
            Life = maxLife;//start all characters at max health.
        }

        public Character()
        {
            //added so we can have default ctors in our monster classes later.
        }



        //METHODS
        public override string ToString()
        {
            //return base.ToString();//Namespace.ClassName -> DungeonLibrary.Character
            return $"---------------{Name}--------------\n" +
                   $"Life: {Life}/{MaxLife}\n" +
                   $"Hit Chance: {HitChance}%\n" +
                   $"Dodge: {Dodge}%\n";
        }

        //Because we intend to use Character as a base class for other, more specific types,
        //we want those classes to have their own version of the below code.
        public virtual int CalcDodge() 
        {
            return Dodge;//Return DOdge for Player class, overriden for the monster subtypes
        }

        public virtual int CalcHitChance() 
        { 
            return HitChance;
        }
        //We don't really have ANY functionality defined here, so, we can make this method abstract.
        //Abstract methods cannot have a {body}.
        //Abstract methods create a contract. Any child class MUST complete (implement this method to be considered a type of
        //"Character"

        //Abstract members can only be created in abstract classes.
        public abstract int CalcDamage();
    }
} 
