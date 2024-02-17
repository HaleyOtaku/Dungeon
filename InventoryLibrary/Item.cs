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

        public int ID { get; set; }

        //COLLECT/CATCH/CONSTRUCTORS
        public Item(string name, int qty, string description, string objectType, int id)
        {
            Name = name;
            Qty = qty;
            Description = description;
            ObjectType = objectType;
            ID = id;
        }


        //METHODS

        public override string ToString()
        {
            return $"************* {Name} *************\n\n" +
                $"Object Type: {ObjectType}\n" +
                $"Description: {Description}\n";
        }
       

        public static Item GetItems()
        {
            List<Item> items = new List<Item>() {
            new Potion("Lesser Healing Potion", 1, "Lesser Healing Potion", "Potion", 1,"Lesser"),
            new Potion("Healing Potion", 1, "Basic Healing Potion", "Potion", 2, "Basic"),
            new Potion("Greater Healing Potion", 1, "Greater Healing Potion", "Potion", 3, "Greater")



            };
        
            int randomIndex = new Random().Next(items.Count);
            Item item = items[randomIndex];
            
            return item;
        }


        //To print

        //Item item = Item.GetItem();
        //Console.WriteLine(item.Name);

        //Ask if add item
        //if yes,
        //player.AddItem(item)
        //if no, console writeline if I want to
    }


}

