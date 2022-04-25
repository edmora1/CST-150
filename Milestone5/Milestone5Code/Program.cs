using System;
using System.Collections.Generic; 

namespace InventoryManager
{
    class Manager
    {
        static void Main(string[] args)
        {
            InventoryManager lbInventory = new InventoryManager();

            int numSelect;

            for (; ; )
            {

                Console.WriteLine("1 - Add Item");
                Console.WriteLine("2 - Show Items");
                Console.WriteLine("3 - Remove Item");
                Console.WriteLine("4 - Search Item by Name");
                Console.WriteLine("5 - Search Item by Price");
                Console.WriteLine("6 - Edit / Restock Item");
                Console.WriteLine("7 - Delete all inventory"); 
                Console.WriteLine("0 - Exit");

                Console.WriteLine("Select Option");
                numSelect = Convert.ToInt32(Console.ReadLine());

                switch (numSelect)
                {
                    case 1:
                        lbInventory.addItem();
                        break;
                    case 2:
                        lbInventory.showItem();
                        break;
                    case 3: lbInventory.removeItem();
                        break;
                    case 4: Console.WriteLine("Enter item name: "); 
                        string n = Console.ReadLine();
                        lbInventory.searchItemName(n);
                        break;
                    case 5: Console.WriteLine("Enter item price: "); 
                        double p  = Convert.ToDouble(Console.ReadLine());
                        lbInventory.searchItemPrice(p);
                        break;
                    case 6: Console.WriteLine("Enter item name to edit: "); 
                        string n2 = Console.ReadLine();
                        
                        lbInventory.editItem(n2);
                        break;

                    case 0: Environment.Exit(0);
                        break; 
                }
            }

        }
    }
    class Item
    {
        string itemName;
        double itemPrice;
        int itemQty;

        public Item(string n, double p, int q)
        {
            Name = n; Price = p; Qty = q;
        }
        public string Name { get => itemName; set => itemName = value; }
        public double Price { get => itemPrice; set => itemPrice = value; }
        public int Qty { get => itemQty; set => itemQty = value; }
    }
    class InventoryManager
    {
        List<Item> lbInventory = new List<Item>(); 
        public void addItem()
        {
            string n;
            double p;
            int q;

            Console.WriteLine("Enter Item Name: "); 
            n = Console.ReadLine();

            Console.WriteLine("Enter Item Price: "); 
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Item Quantity: "); 
            q = Convert.ToInt32(Console.ReadLine());

            Item item = new Item(n, p, q);

            lbInventory.Add(item);
        }
        public void showItem()
        {
            string s = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity"); 

            Console.WriteLine(s + "\n");

            foreach (Item item in lbInventory)
            {
                string s1 = String.Format("{0,10}{1,10}{2,10}", item.Name, item.Price, item.Qty);
                Console.WriteLine(s1 + "\n");
            }
        }
        public void removeItem()
        {
            Console.WriteLine("Enter Item to Remove: "); 
            string n = Console.ReadLine();

            int id = 0;

            for (int i = 0; i < lbInventory.Count; i++)
            {
                if (lbInventory[i].Name.Equals(n))
                {
                    lbInventory.RemoveAt(i);
                    Console.WriteLine("Item Removed from Inventory");
                    id++;
                }
            }
            if (id == 0)
            {
                Console.WriteLine("Item was not found"); 
            }
        }
        public void searchItemName(string n)
        {
            int id = 0;

            string s = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");

            Console.WriteLine(s + "\n");

            foreach (Item item in lbInventory)
            {
                if (item.Name.Equals(n))
                {
                    string str = String.Format("{0,10}{1,10}{2,10}", item.Name, item.Price, item.Qty);
                    Console.WriteLine(str + "\n");
                    id = 1;
                }
            }

            if (id == 0)
            {
                Console.WriteLine("Item was not found");
            }
        }
        public void searchItemPrice(double p)
        {
            int id = 0;
            string s = String.Format("{0,10}{1,10}{2,10}", "Name", "Price", "Quantity");

            Console.WriteLine(s + "\n");

            foreach (Item item in lbInventory)
            {
                if (item.Price.Equals(p))
                {
                    string str = String.Format("{0,10}{1,10}{2,10}", item.Name, item.Price, item.Qty);
                    Console.WriteLine(str + "\n");
                    id = 1;
                }
            }
            if (id == 0)
            {
                Console.WriteLine("Item was not found"); 
            }
        }
        public void editItem(string n)
        {
            Console.WriteLine("Enter new quantity for item: "); 
            string n2 = Console.ReadLine();

            int q = Convert.ToInt32(n2);

            foreach (Item item in lbInventory)
            {
                if (item.Name.Equals(n))
                {
                    item.Qty = q;
                    Console.WriteLine("Item restocked");
                }
            }
        }
    }
    
}
