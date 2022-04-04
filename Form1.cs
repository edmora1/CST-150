using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone2InventoryClass
{
    struct Inventory
    {
        public string name;
        public double cost;
        public int qty; 
    }
    public partial class Form1 : Form
    {
        private List<Inventory> itemList = new List<Inventory>();
        public Form1()
        {
            InitializeComponent();
        }

        private void getData(ref Inventory inventoryItem)
        {
            try
            {
                inventoryItem.name = nameTxtBx.Text;
                inventoryItem.cost = double.Parse(costTxtBx.Text); 
                inventoryItem.qty = int.Parse(qtyTxtBx.Text);            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
        private void addItemBtn_Click(object sender, EventArgs e)
        { 
            Inventory product = new Inventory();
            getData(ref product);

            itemList.Add(product);

            nameTxtBx.Clear();
            costTxtBx.Clear();
            qtyTxtBx.Clear(); 

            nameTxtBx.Focus();            
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string outputList;

            inventoryList.Items.Clear();

            foreach (Inventory item in itemList)
            {
                outputList = item.name + " " + item.cost + " " + item.qty;

                inventoryList.Items.Add(outputList);
            }
        }
    }
}
