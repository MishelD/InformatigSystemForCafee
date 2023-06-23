﻿using System;
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
    public partial class CashRegister : Form
    {
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
            Color darkViolet = Color.FromArgb(73, 62, 194);
            Color violet = Color.FromArgb(93, 95, 239);
            Color lightViolet = Color.FromArgb(120, 121, 241);
            Color greyWhite = Color.FromArgb(238, 238, 238);

            BarPanel.BackColor = violet;
            ReceiptWrap.BackColor = greyWhite;
            orderButton.BackgroundColor = violet;
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
    }
}
