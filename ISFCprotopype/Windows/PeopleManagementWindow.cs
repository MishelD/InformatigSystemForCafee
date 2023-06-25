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

namespace ISFCprotopype
{
    public partial class PeopleManagementWindow : Form
    {
        private Color darkViolet = Color.FromArgb(73, 62, 194);
        private Color violet = Color.FromArgb(93, 95, 239);
        private Color lightViolet = Color.FromArgb(120, 121, 241);
        private Color greyWhite = Color.FromArgb(238, 238, 238);

        public PeopleManagementWindow()
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
            foreach (RoundButton button in menuFlowLayoutPanel.Controls)
            {
                button.Click += (s, e) =>
                {
                    orderList.Controls.Add(new ReceiptItem());
                };
            }
        }

        private void SetBGColor()
        {
            BarPanel.BackColor = violet;
            ReceiptWrap.BackColor = greyWhite;
            addIngredientsButton.BackgroundColor = violet;
        }

        private void receiptItem1_Paint(object sender, PaintEventArgs e)
        {

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
                addIngredientsButton.Enabled = false;
            }
            else
            {
                addIngredientsButton.Enabled = true;
            }
        }

        private void orderList_ControlAdded(object sender, ControlEventArgs e)
        {
            foreach (ReceiptItem item in orderList.Controls)
            {
                item.AmountValueChanged += (s, eventA) =>
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
    }
}
