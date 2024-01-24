using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Restaurant_Ordering_System
{
    public partial class MainForm : Form
    {
        #region Menu

        private MenuItem[] starters = new MenuItem[]
        {
            new MenuItem()
            {
                Name = "Spicy Mixed Olives",
                Price = 3.75
            },
        };

        private MenuItem[] mains = new MenuItem[]
        {
            new MenuItem()
            {
                Name = "Grilled Chicken Wrap",
                Price = 7.75
            }
        };

        private MenuItem[] sides = new MenuItem[]
        {
            new MenuItem()
            {
                Name = "Chips",
                Price = 1.00
            }
        };

        private MenuItem[] drinks = new MenuItem[]
        {
            new MenuItem()
            {
                Name = "Coca-Cola",
                Price = 3.70
            }
        };

        #endregion

        private List<MenuItem> orderList;

        public MainForm()
        {
            InitializeComponent();
            orderList = new List<MenuItem>();

            PopulateComboBoxes();
        }

        private void calculateTotalButton_Click(object sender, System.EventArgs e)
            => CalculateTotal();

        private void resetOrderButton_Click(object sender, System.EventArgs e)
            => Reset();

        private void quitButton_Click(object sender, System.EventArgs e)
            => Application.Exit();

        private void PopulateComboBoxes()
        {
            PopulateStartersComboBox();
            PopulateMainsComboBox();
            PopulateSidesComboBox();
            PopulateDrinksComboBox();
        }

        private void PopulateStartersComboBox()
        {
            foreach (MenuItem item in starters)
            {
                selectStarterComboBox.Items.Add(item);
            }
            selectStarterComboBox.DisplayMember = "Name";
        }

        private void PopulateMainsComboBox()
        {
            foreach (MenuItem menuItem in mains)
            {
                selectMainComboBox.Items.Add(menuItem);
            }
            selectMainComboBox.DisplayMember = "Name";
        }

        private void PopulateSidesComboBox()
        {
            foreach (MenuItem menuItem in sides)
            {
                selectSideComboBox.Items.Add(menuItem);
            }
            selectSideComboBox.DisplayMember = "Name";
        }

        private void PopulateDrinksComboBox()
        {
            foreach (MenuItem menuItem in drinks)
            {
                selectDrinkComboBox.Items.Add(menuItem);
            }
            selectDrinkComboBox.DisplayMember = "Name";
        }

        private void AddOrderItem(MenuItem menuItem)
            => orderList.Add(menuItem);

        private void Reset()
        {
            orderList.Clear();

            starterQuantityNumericUpDown.Value = 0;
            mainQuantityNumericUpDown.Value = 0;
            sideQuantityNumericUpDown.Value = 0;
            drinkQuantityNumericUpDown.Value = 0;
        }

        private void CalculateTotal()
        {
            AddItemsToOrder();

            double total = 0;
            for (int i = 0; i < orderList.Count; i++)
            {
                total += orderList[i].Price;
            }
            MessageBox.Show($"Total: {total.ToString("C2")}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddItemsToOrder()
        {
            for (int i = 0; i < starterQuantityNumericUpDown.Value; i++)
            {
                AddOrderItem(starters[selectStarterComboBox.SelectedIndex]);
            }

            for (int i = 0; i < mainQuantityNumericUpDown.Value; i++)
            {
                AddOrderItem(mains[selectMainComboBox.SelectedIndex]);
            }

            for (int i = 0; i < sideQuantityNumericUpDown.Value; i++)
            {
                AddOrderItem(sides[selectSideComboBox.SelectedIndex]);
            }

            for (int i = 0; i < drinkQuantityNumericUpDown.Value; i++)
            {
                AddOrderItem(drinks[selectDrinkComboBox.SelectedIndex]);
            }
        }
    }
}