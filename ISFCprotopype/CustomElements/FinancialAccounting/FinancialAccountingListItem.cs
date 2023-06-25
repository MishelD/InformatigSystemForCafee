using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISFCprotopype.CustomElements.FinancialAccounting
{
    internal class FinancialAccountingListItem : UserControl
    {
        private TableLayoutPanel tableLayoutPanel1;
        public Label totalAmountLabel;
        public Label totalAmountNameLabel;
        private RoundPanel roundPanel1;

        public FinancialAccountingListItem()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.roundPanel1 = new ISFCprotopype.CustomElements.RoundPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.totalAmountNameLabel = new System.Windows.Forms.Label();
            this.roundPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel1.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel1.BorderRadius = 25;
            this.roundPanel1.BorderSize = 0;
            this.roundPanel1.Controls.Add(this.tableLayoutPanel1);
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(1133, 50);
            this.roundPanel1.TabIndex = 0;
            this.roundPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.totalAmountLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalAmountNameLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalAmountLabel.Font = new System.Drawing.Font("Inter Medium", 18.07029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalAmountLabel.Location = new System.Drawing.Point(3, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Padding = new System.Windows.Forms.Padding(25, 10, 0, 10);
            this.totalAmountLabel.Size = new System.Drawing.Size(287, 50);
            this.totalAmountLabel.TabIndex = 0;
            this.totalAmountLabel.Text = "+ 1000 ₽";
            this.totalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalAmountNameLabel
            // 
            this.totalAmountNameLabel.AutoSize = true;
            this.totalAmountNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalAmountNameLabel.Font = new System.Drawing.Font("Inter Medium", 18.07029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalAmountNameLabel.Location = new System.Drawing.Point(296, 0);
            this.totalAmountNameLabel.Name = "totalAmountNameLabel";
            this.totalAmountNameLabel.Padding = new System.Windows.Forms.Padding(0, 10, 25, 10);
            this.totalAmountNameLabel.Size = new System.Drawing.Size(834, 50);
            this.totalAmountNameLabel.TabIndex = 1;
            this.totalAmountNameLabel.Text = "Произведена оплата заказа #1000";
            this.totalAmountNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FinancialAccountingListItem
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundPanel1);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "FinancialAccountingListItem";
            this.Size = new System.Drawing.Size(1133, 50);
            this.roundPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
