using System.Collections;
using System.Diagnostics;
using System.Text;


namespace CafeApp
{
    public partial class Form1 : Form
    {
        ArrayList prices = new ArrayList();
        ArrayList orderedItems = new ArrayList();
        StringBuilder s = new StringBuilder();
        string selectedItem;
        int itemAmount;
        double total = 0;

        double burger = 25;
        double pizza = 10;
        double icedCoffee = 12;
        double tea = 7;
        double chocolate = 9;

        public Form1()
        {
            InitializeComponent();       
        }

        private void items_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = items.SelectedItem.ToString();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            int itemAmount;
            if (selectedItem != null && quantity.Text.Length > 0)
            {
                if (selectedItem != "Select an item")
                {
                    itemAmount = Convert.ToInt32(quantity.Text);
                    for (int i = 0; i < itemAmount; i++)
                    {
                        orderedItems.Add(selectedItem);           
                    }
                    populatePriceArray(selectedItem, itemAmount);
                }
            } else
            {
                MessageBox.Show("Please ensure you have entered the item you wish to purchase as well as the quantity");
            }       
            items.SelectedIndex = 0;
            quantity.Clear();
        }

        private void displayReceipt_Click(object sender, EventArgs e)
        {
            if (orderedItems.Count == 0)
            {
                MessageBox.Show("You haven't bought anything yet. \nPlease select an item from the dropdown menu.");
            } else
            {
                generateReceipt();
            }
            
            
        }

        public void generateReceipt()
        {
            s.Clear();
            s.AppendLine("RECEIPT");
            s.AppendLine("-----------------------------------");
            s.AppendLine("");
            var query =
            from string i in orderedItems
            group i by i into g
            select new { Item = g.Key, ItemCount = g.Count() };

            int index = 0;
            foreach (var item in query)
            {
                s.AppendLine($"- {item.Item}  x{item.ItemCount}  -  R{prices[index]}");
                s.AppendLine($" Price per {item.Item}:  R{pricePerItem(item.Item)}");
                s.AppendLine();
                index++;
            }
            s.AppendLine();
            s.AppendLine("-----------------------------------");
            s.AppendLine($"Total: R{total}");
            s.AppendLine("-----------------------------------");

            MessageBox.Show(s.ToString());
           
        }

        public void populatePriceArray(string item, int quantity)
        {
            switch (item)
            {
                case "Burger":
                    prices.Add(burger * quantity);
                    total += (burger * quantity);
                    break;
                case "Pizza":
                    prices.Add(pizza * quantity);
                    total += (pizza * quantity);
                    break;
                case "Iced Coffee":
                    prices.Add(icedCoffee * quantity);
                    total += (icedCoffee * quantity);
                    break;
                case "Tea":
                    prices.Add(tea * quantity);
                    total += (tea * quantity);
                    break;
                case "Chocolate":
                    prices.Add(chocolate * quantity);
                    total += (chocolate * quantity);
                    break;

            }
        }

        public double pricePerItem(string item)
        {
            switch(item)
            {
                case "Burger":
                    return burger;
                case "Pizza":
                    return pizza;
                case "Iced Coffee":
                    return icedCoffee;
                case "Tea":
                    return tea;
                case "Chocolate":
                    return chocolate;
                default:
                    return 1;
            }
        }
    }
}
