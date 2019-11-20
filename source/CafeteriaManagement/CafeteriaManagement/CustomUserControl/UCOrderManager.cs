﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using CM.DTO;
using System.Globalization;
using CM.DAL;

namespace CafeteriaManagement
{
    public partial class UCOrderManager : UserControl
    {
        public static event EventHandler<IEnumerable<string>> ItemChosen;



        public UCOrderManager()
        {
            InitializeComponent();
            LoadDataFromDatabase();
            FormTopping.ToppingsSelected += FormTopping_ToppingsSelectedHandler;
        }

        private void LoadDataFromDatabase()
        {
            comboBoxCatetory.DataSource = DataProvider.RetrieveCategory();
        }

        private void FormTopping_ToppingsSelectedHandler(object sender, List<string> e)
        {
            var selectedItemIndex = dataGridViewSelectedItems.SelectedRows[0].Index;
            foreach (var topping in e)
            {
                var item = DataProvider.RetrieveProductFrom(topping);
                SelectedList.AddTopping(item, selectedItemIndex);
                UpdateSelectedItemsDataGrid(item);
            }
        }

        private void TextBoxSearchMenu_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchMenu.Text == "Search")
            {
                textBoxSearchMenu.Text = "";
                textBoxSearchMenu.ForeColor = Color.Black;
            }
        }

        private void TextBoxSearchMenu_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchMenu.Text.Length == 0)
            {
                textBoxSearchMenu.Text = Properties.Resources.textBoxSearchMenuText;
                textBoxSearchMenu.ForeColor = Color.Gray;
            }
        }

        private void ComboBoxCatetory_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuListView.Clear();
            foreach (var item in DataProvider.RetrieveMenuFrom(comboBoxCatetory.SelectedItem as string))
            {
                menuListView.Items.Add(item);
            }
        }

        private void MenuListView_DoubleClick(object sender, EventArgs e)
        {
            if (menuListView.SelectedItems.Count == 1)
            {
                var selectedItem = DataProvider.RetrieveProductFrom(menuListView.SelectedItems[0].Text);
                SelectedList.Add(selectedItem);
                UpdateSelectedItemsDataGrid(selectedItem);
            }
        }

        private void UpdateSelectedItemsDataGrid(Product selectedItem)
        {
            dataGridViewSelectedItems.DataSource = null;
            dataGridViewSelectedItems.DataSource = SelectedList.GetSelectedItems();

            CalculateBill(selectedItem.Price);
        }

        private void CalculateBill(int itemPrice)
        {
            var currentPrice = Convert.ToInt32(labelSum.Text, CultureInfo.InvariantCulture);
            currentPrice += itemPrice;
            labelSum.Text = currentPrice.ToString(CultureInfo.InvariantCulture);
        }

        private void DataGridViewSelectedItems_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (var formTopping = new FormTopping())
            {
                var menuTopping = DataProcess.RetrieveMenuToppingFrom(SelectedList.GetSelectedItems()[e.RowIndex].Name);
                if (menuTopping != null)
                {
                    OnItemChoosing(menuTopping);
                    formTopping.ShowDialog();
                }
            };
        }

        private void OnItemChoosing(IEnumerable<string> menuTopping) => (ItemChosen as EventHandler<IEnumerable<string>>)?.Invoke(this, menuTopping);

        private void LabelRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewSelectedItems.DataSource = null;
            labelSum.Text = Properties.Resources.initialPrice;
            SelectedList.ClearList();
            LoadDataFromDatabase();
        }

        private void ButtonBill_Click(object sender, EventArgs e) => DataProcess.InsertBill(SelectedList.GetSelectedItems(), labelSum.Text);
    }
}
