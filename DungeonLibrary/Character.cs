namespace DungeonLibrary
{
    public class Character
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

        //FIELDS
        private string _name = null!;
        // (null!) allows us to make something null while promising to pass a
        //value to it later, and removes green warning
        private int _maxLife;
        private int _life;
        private int _hitChance;
        private int _dodge;


        //PROPERTIES
        private string Name
        {
            get { return _name; }
            set { _name = value; }
        
        }
        private int MaxLife //independent
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        private int Life //dependant on MaxLife
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

        private int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        private int Dodge
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

        public int CalcDodge() 
        {
            return Dodge;
        }

        public int CalcHitChance() 
        { 
            return HitChance;
        }

        public int CalcDamage()
        {
            return 0;
        }
    }
} 
