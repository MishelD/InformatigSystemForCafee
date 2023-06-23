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
    public partial class CashRegister : Form
    {
        private Color darkViolet = Color.FromArgb(73, 62, 194);
        private Color violet = Color.FromArgb(93, 95, 239);
        private Color lightViolet = Color.FromArgb(120, 121, 241);
        private Color greyWhite = Color.FromArgb(238, 238, 238);

        public CashRegister()
        {
            InitializeComponent();
            SetBGColor();
            ReceiptItem[] receiptItem;
            receiptItem = new ReceiptItem[3];
            for (int i = 0; i < receiptItem.Length; i++)
            {
                receiptItem[i] = new ReceiptItem();
                orderList.Controls.Add(receiptItem[i]);
            }
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
            foreach (DataRow row in databaseCafeDataSet1.Блюда)
            {
                MenuListItem menuItem = new MenuListItem();
                menuItem.NameItem = (string)row["dish_name"];
                menuItem.CostItem = (float)Convert.ToSingle(row["price"]);
                menuItem.MassItem = (float)Convert.ToSingle(row["mass"]);
                menuFlowLayoutPanel.Controls.Add(menuItem);
                
                menuItem.Click += (s, args) =>
                {
                    ReceiptItem receiptItem = new ReceiptItem();
                    orderList.Controls.Add(receiptItem);
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
