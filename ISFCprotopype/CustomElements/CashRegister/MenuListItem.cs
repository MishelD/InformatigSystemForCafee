using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISFCprotopype.CustomElements.CashRegister
{
    internal class MenuListItem : UserControl
    {
        private TableLayoutPanel _tableLayoutPanel1;
        private TableLayoutPanel _tableLayoutPanel2;
        private Label _itemWeightLabel;
        private Label _itemCostLabel;
        private Label _itemNameLabel;
        private RoundPanel _roundPanel1;

        private int _itemDishId;
        public int ItemDishId
        {
            get { return _itemDishId; }
            set { _itemDishId = value; }
        }

        private string _itemName;
        [DefaultValue("Наименование блюда")]
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                _itemName = value;
                _itemNameLabel.Text = _itemName;
            }
        }

        private float _itemWeight;
        [DefaultValue(0f)]
        public float ItemWeight
        {
            get { return _itemWeight; }
            set
            {
                _itemWeight = value;
                _itemWeightLabel.Text = string.Format("{0} {1}", _itemWeight, _itemUnitOfMeasure);
            }
        }

        private string _itemUnitOfMeasure;
        [DefaultValue("гр.")]
        public string ItemUnitOfMeasure
        {
            get { return _itemUnitOfMeasure; }
            set
            {
                _itemUnitOfMeasure = value;
                _itemWeightLabel.Text = string.Format("{0} {1}", _itemWeight, _itemUnitOfMeasure);
            }
        }

        private float _itemCost;
        [DefaultValue(0f)]
        public float ItemCost
        {
            get { return _itemCost; }
            set
            {
                _itemCost = value;
                _itemCostLabel.Text = string.Format("{0} ₽", _itemCost);
            }
        }

        private Image _imageItem = global::ISFCprotopype.Properties.Resources.SquareImageNotFound;
        public Image ImageItem
        {
            get { return _imageItem; }
            set
            {
                _imageItem = value;
                if (value != null)
                {
                    this._roundPanel1.BackgroundImage = _imageItem;
                }
                else
                {
                    this._roundPanel1.BackgroundImage = global::ISFCprotopype.Properties.Resources.SquareImageNotFound;
                }
            }
        }

        private EventHandler onClickItem;

        public MenuListItem()
        {
            InitializeComponent();
            this._roundPanel1.Click += (s, e) =>
            {
                onClickItem.Invoke(this, new EventArgs());
            };
            _tableLayoutPanel1.Click += (s, e) =>
            {
                onClickItem.Invoke(this, new EventArgs());
            };
            _tableLayoutPanel2.Click += (s, e) =>
            {
                onClickItem.Invoke(this, new EventArgs());
            };
            _itemWeightLabel.Click += (s, e) =>
            {
                onClickItem.Invoke(this, new EventArgs());
            };
            _itemCostLabel.Click += (s, e) =>
            {
                onClickItem.Invoke(this, new EventArgs());
            };
            _itemNameLabel.Click += (s, e) =>
            {
                onClickItem.Invoke(this, new EventArgs());
            };
        }

        private void InitializeComponent()
        {
            this._roundPanel1 = new ISFCprotopype.CustomElements.RoundPanel();
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._itemWeightLabel = new System.Windows.Forms.Label();
            this._itemCostLabel = new System.Windows.Forms.Label();
            this._itemNameLabel = new System.Windows.Forms.Label();
            this._roundPanel1.SuspendLayout();
            this._tableLayoutPanel1.SuspendLayout();
            this._tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this._roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this._roundPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this._roundPanel1.BackgroundImage = global::ISFCprotopype.Properties.Resources.SquareImageNotFound;
            this._roundPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._roundPanel1.BorderColor = System.Drawing.Color.Gray;
            this._roundPanel1.BorderRadius = 20;
            this._roundPanel1.BorderSize = 0;
            this._roundPanel1.Controls.Add(this._tableLayoutPanel1);
            this._roundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._roundPanel1.ForeColor = System.Drawing.Color.Black;
            this._roundPanel1.Location = new System.Drawing.Point(0, 0);
            this._roundPanel1.Margin = new System.Windows.Forms.Padding(0);
            this._roundPanel1.Name = "roundPanel1";
            this._roundPanel1.Size = new System.Drawing.Size(168, 168);
            this._roundPanel1.TabIndex = 0;
            this._roundPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // tableLayoutPanel1
            // 
            this._tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._tableLayoutPanel1.ColumnCount = 1;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel1.Controls.Add(this._tableLayoutPanel2, 0, 1);
            this._tableLayoutPanel1.Controls.Add(this._itemNameLabel, 0, 0);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 117);
            this._tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanel1.Name = "tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 2;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(168, 51);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this._tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this._tableLayoutPanel2.ColumnCount = 2;
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel2.Controls.Add(this._itemWeightLabel, 0, 0);
            this._tableLayoutPanel2.Controls.Add(this._itemCostLabel, 1, 0);
            this._tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel2.Location = new System.Drawing.Point(0, 34);
            this._tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanel2.Name = "tableLayoutPanel2";
            this._tableLayoutPanel2.RowCount = 1;
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel2.Size = new System.Drawing.Size(168, 17);
            this._tableLayoutPanel2.TabIndex = 0;
            // 
            // massItemLabel
            // 
            this._itemWeightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._itemWeightLabel.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._itemWeightLabel.ForeColor = System.Drawing.Color.White;
            this._itemWeightLabel.Location = new System.Drawing.Point(0, 0);
            this._itemWeightLabel.Margin = new System.Windows.Forms.Padding(0);
            this._itemWeightLabel.Name = "massItemLabel";
            this._itemWeightLabel.Size = new System.Drawing.Size(84, 17);
            this._itemWeightLabel.TabIndex = 0;
            this._itemWeightLabel.Text = "200 гр.";
            this._itemWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costItemLabel
            // 
            this._itemCostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._itemCostLabel.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._itemCostLabel.ForeColor = System.Drawing.Color.White;
            this._itemCostLabel.Location = new System.Drawing.Point(84, 0);
            this._itemCostLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this._itemCostLabel.Name = "costItemLabel";
            this._itemCostLabel.Size = new System.Drawing.Size(84, 17);
            this._itemCostLabel.TabIndex = 1;
            this._itemCostLabel.Text = "200 ₽";
            this._itemCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemNameLabel
            // 
            this._itemNameLabel.BackColor = System.Drawing.Color.Transparent;
            this._itemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._itemNameLabel.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._itemNameLabel.ForeColor = System.Drawing.Color.White;
            this._itemNameLabel.Location = new System.Drawing.Point(0, 0);
            this._itemNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this._itemNameLabel.Name = "itemNameLabel";
            this._itemNameLabel.Size = new System.Drawing.Size(168, 34);
            this._itemNameLabel.TabIndex = 1;
            this._itemNameLabel.Text = "Наименование блюда";
            this._itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuListItem
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this._roundPanel1);
            this.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.Name = "MenuListItem";
            this.Size = new System.Drawing.Size(168, 168);
            this._roundPanel1.ResumeLayout(false);
            this._tableLayoutPanel1.ResumeLayout(false);
            this._tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public event EventHandler ClickItem
        {
            add
            {
                onClickItem = (EventHandler)Delegate.Combine(onClickItem, value);
            }
            remove
            {
                onClickItem = (EventHandler)Delegate.Remove(onClickItem, value);
            }
        }
        protected virtual void OnClickItem(EventArgs e)
        {
            if (onClickItem != null)
            {
                onClickItem(this, e);
            }
        }
    }
}
