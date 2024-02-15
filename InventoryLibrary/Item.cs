using DungeonLibrary;


namespace InventoryLibrary
{
    public abstract class Item
    {

        //FIELDS

        //PROPERTIES
        public string Name { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public string ObjectType { get; set; }

        //COLLECT/CATCH/CONSTRUCTORS
        public Item(string name, int qty, string description, string objectType)
        {
            Name = name;
            Qty = qty;
            Description = description;
            ObjectType = objectType;
        }


        //METHODS

        public override string ToString()
        {
            return $"************* Name *************\n\n" +
                $"Object Type: {ObjectType}\n" +
                $"Description: {Description}\n";
        }

        public abstract int GetQty();


    }


}

