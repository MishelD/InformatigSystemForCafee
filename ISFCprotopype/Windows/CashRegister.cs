using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISFCprotopype.CustomElements;
using ISFCprotopype.CustomElements.CashRegister;
using ISFCprotopype.databaseCafeDataSetTableAdapters;

namespace ISFCprotopype
{
    public partial class CashRegisterWindow : Form
    {
        private Color darkViolet = Color.FromArgb(73, 62, 194);
        private Color violet = Color.FromArgb(93, 95, 239);
        private Color lightViolet = Color.FromArgb(120, 121, 241);
        private Color greyWhite = Color.FromArgb(238, 238, 238);

        public CashRegisterWindow()
        {
            InitializeComponent();
            SetBGColor();
            UpdateAmountLabel();
        }

        private void SetBGColor()
        {
            BarPanel.BackColor = violet;
            ReceiptWrap.BackColor = greyWhite;
            orderButton.BackgroundColor = violet;
        }
        public void UpdateAmountLabel()
        {
            float amountCost = 0;

            foreach (ReceiptItem item in orderList.Controls)
            {
                amountCost += item.AmountCost;
            }

            amountLabel.Text = string.Format("{0} ₽", amountCost);

            if (amountCost == 0)
            {
                orderButton.Enabled = false;
            }
            else
            {
                orderButton.Enabled = true;
            }
        }

        private void orderList_ControlAdded(object sender, ControlEventArgs e)
        {
            foreach (ReceiptItem item in orderList.Controls)
            {
                item.AmountValueChanged += (s, args) =>
                {
                    UpdateAmountLabel();
                };
            }

            UpdateAmountLabel();
        }

        private void orderList_ControlRemoved(object sender, ControlEventArgs e)
        {
            UpdateAmountLabel();
        }

        private void orderButton_EnabledChanged(object sender, EventArgs e)
        {
            RoundButton button = (RoundButton)sender;
            if (!button.Enabled)
            {
                button.BackgroundColor = greyWhite;
                button.ForeColor = Color.Gray;
                button.BorderSize = 1;
                button.BorderColor = Color.Gray;
            }
            else
            {
                button.BackgroundColor = violet;
                button.ForeColor = Color.White;
                button.BorderSize = 0;
            }
        }

        private void CashRegister_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet1.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter1.Fill(this.databaseCafeDataSet1.Блюда);
            
            // Добавление списка блюд в меню из базы данных
            foreach (DataRow row in databaseCafeDataSet1.Блюда)
            {
                MenuListItem menuItem = new MenuListItem();
                menuItem.ItemDishId = (int)row["dish_id"];
                menuItem.ItemName = (string)row["dish_name"];
                menuItem.ItemCost = (float)Convert.ToSingle(row["price"]);
                menuItem.ItemWeight = (float)Convert.ToSingle(row["mass"]);
                menuItem.ItemUnitOfMeasure = (string)row["unit_of_measure"];
                menuFlowLayoutPanel.Controls.Add(menuItem);
                
                // Подписка на клик одного из блюд в виде вызова функции добавления позиции в список заказа
                menuItem.ClickItem += (s, args) =>
                {
                    MenuListItem clickedMenuItem = (MenuListItem)s;
                    bool isDuplicate = false;

                    // Проверка на дубликат позиции в списке заказа
                    foreach (ReceiptItem item in orderList.Controls)
                    {
                        if (menuItem.ItemDishId == item.ItemDishId)
                        {
                            isDuplicate = true;
                            item.ItemCount++;
                            break;
                        }
                    }
                    // Если дубликат не найден
                    if (!isDuplicate)
                    {
                        // Создание позиции в списке заказа
                        ReceiptItem receiptItem = new ReceiptItem();
                        receiptItem.ItemDishId = clickedMenuItem.ItemDishId;
                        receiptItem.ItemName = clickedMenuItem.ItemName;
                        receiptItem.ItemCost = clickedMenuItem.ItemCost;
                        receiptItem.ItemWeight = clickedMenuItem.ItemWeight;
                        receiptItem.ItemUnitOfMeasure = clickedMenuItem.ItemUnitOfMeasure;
                        receiptItem.UpdateAmountCost();
                        orderList.Controls.Add(receiptItem);
                    }
                };
            }
            //for (int i = 0; i < databaseCafeDataSet.Блюда.Count; i++)
            //{
            //    MenuListItem menuItem = new MenuListItem();
            //    menuItem.NameItem = (string)databaseCafeDataSet.Блюда.Rows["dish_name"];
            //    menuItem.NameItem = (string)databaseCafeDataSet.Блюда.Rows[i][1];
            //    menuItem.MassItem = (float)databaseCafeDataSet.Блюда.Rows[i][5];
            //    menuFlowLayoutPanel.Controls.Add(menuItem);
            //}

        }

        private void блюдаBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.блюдаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCafeDataSet);

        }

        private void блюдаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.блюдаBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.databaseCafeDataSet1);

        }

        private void блюдаBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.блюдаBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.databaseCafeDataSet1);

        }
    }
}
