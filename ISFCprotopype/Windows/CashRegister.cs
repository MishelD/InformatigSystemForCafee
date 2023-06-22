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
    public partial class CashRegister : Form
    {
        public CashRegister()
        {
            InitializeComponent();
            ReceiptItem[] receiptItem;
            receiptItem = new ReceiptItem[10];
            for (int i = 0; i < receiptItem.Length; i++)
            {
                receiptItem[i] = new ReceiptItem();
                //orderList.Controls.Add(receiptItem[i]);
            }
        }
    }
}
