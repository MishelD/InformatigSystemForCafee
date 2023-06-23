using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISFCprotopype.CustomElements.CashRegister
{
    internal class MenuListItem : UserControl
    {
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label massItemLabel;
        private Label costItemLabel;
        private Label itemNameLabel;
        private RoundPanel roundPanel1;

        private string _nameItem;
        public string NameItem
        {
            get { _nameItem = "Null"; return _nameItem; }
            set
            {
                _nameItem = value;
                itemNameLabel.Text = _nameItem;
            }
        }

        private float _massItem;
        public float MassItem
        {
            get { _massItem = 0; return _massItem; }
            set
            {
                _massItem = value;
                massItemLabel.Text = string.Format("{0} гр.", _massItem);
            }
        }

        private float _costItem;
        public float CostItem
        {
            get { _costItem = 0; return _costItem; }
            set
            {
                _costItem = value;
                costItemLabel.Text = string.Format("{0} ₽", _costItem);
            }
        }

        private Image _imageItem;
        public Image ImageItem
        {
            get { _imageItem = null; return _imageItem; }
            set
            {
                _imageItem = value;
                if (value != null)
                {
                    this.roundPanel1.BackgroundImage = _imageItem;
                }
                else
                {
                    this.roundPanel1.BackgroundImage = global::ISFCprotopype.Properties.Resources.SquareImageNotFound;
                }
            }
        }

        public MenuListItem()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.roundPanel1 = new ISFCprotopype.CustomElements.RoundPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.massItemLabel = new System.Windows.Forms.Label();
            this.costItemLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.roundPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel1.BackgroundImage = global::ISFCprotopype.Properties.Resources.SquareImageNotFound;
            this.roundPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundPanel1.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.BorderSize = 0;
            this.roundPanel1.Controls.Add(this.tableLayoutPanel1);
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(168, 168);
            this.roundPanel1.TabIndex = 0;
            this.roundPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.itemNameLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 117);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 51);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.massItemLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.costItemLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(168, 17);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // massItemLabel
            // 
            this.massItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.massItemLabel.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massItemLabel.ForeColor = System.Drawing.Color.White;
            this.massItemLabel.Location = new System.Drawing.Point(0, 0);
            this.massItemLabel.Margin = new System.Windows.Forms.Padding(0);
            this.massItemLabel.Name = "massItemLabel";
            this.massItemLabel.Size = new System.Drawing.Size(84, 17);
            this.massItemLabel.TabIndex = 0;
            this.massItemLabel.Text = "200 гр.";
            this.massItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costItemLabel
            // 
            this.costItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costItemLabel.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costItemLabel.ForeColor = System.Drawing.Color.White;
            this.costItemLabel.Location = new System.Drawing.Point(84, 0);
            this.costItemLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.costItemLabel.Name = "costItemLabel";
            this.costItemLabel.Size = new System.Drawing.Size(84, 17);
            this.costItemLabel.TabIndex = 1;
            this.costItemLabel.Text = "200 ₽";
            this.costItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameLabel.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemNameLabel.ForeColor = System.Drawing.Color.White;
            this.itemNameLabel.Location = new System.Drawing.Point(0, 0);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(168, 34);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "Наименование блюда";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuListItem
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundPanel1);
            this.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.Name = "MenuListItem";
            this.Size = new System.Drawing.Size(168, 168);
            this.roundPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
