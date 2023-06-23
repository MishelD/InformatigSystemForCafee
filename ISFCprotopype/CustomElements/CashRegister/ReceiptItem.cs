using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ISFCprotopype.CustomElements
{
    class ReceiptItem : RoundPanel
    {
        //private Panel _itemWrap;
        private TableLayoutPanel _itemLayoutPanel;
        private Label _itemNameLabel;
        private Panel _itemNumericUpDownWrap;
        private RoundNumericUpDown _itemNumericUpDown;
        private TableLayoutPanel _itemCharacteristicLayoutPanel;
        private Label _itemWeightLabel;
        private Label _itemCostLabel;
        private TableLayoutPanel _itemAmountLayoutPanel;
        private Label _itemAmountLabel;
        private Label _itemAmountCostLabel;

        private EventHandler onAmountValueChanged;

        private float _itemCost;

        public float AmountCost
        {
            get { return _itemCost * _itemNumericUpDown.Value; }
        }

        private Color darkViolet = Color.FromArgb(73, 62, 194);
        private Color violet = Color.FromArgb(93, 95, 239);
        private Color lightViolet = Color.FromArgb(120, 121, 241);
        private Color greyWhite = Color.FromArgb(238, 238, 238);

        public ReceiptItem()
        {
            this.Width = 316;
            this.Height = 125;
            this.Margin = new Padding(0, 10, 0, 0);
            this.BackColor = Color.White;
            this.BorderRadius = 10;
            this.Name = "itemWrap";
            _itemCost = 300f;
            InitializeComponent();
            _itemNumericUpDown.ValueChanged += (s, e) =>
            {
                if (_itemNumericUpDown.Value == 0)
                {
                    this.Dispose();
                }
                else
                {
                    _itemAmountCostLabel.Text = string.Format("{0} {1}", AmountCost, "₽");
                    onAmountValueChanged.Invoke(this, EventArgs.Empty);
                }
            };
        }

        private void InitializeComponent()
        {
            _itemLayoutPanel = new TableLayoutPanel();
            _itemLayoutPanel.ColumnCount = 2;
            _itemLayoutPanel.RowCount = 2;
            _itemLayoutPanel.Margin = new Padding(0);
            _itemLayoutPanel.Width = 316;
            _itemLayoutPanel.Height = 125;
            _itemLayoutPanel.Parent = this;
            _itemLayoutPanel.Name = "itemLayoutPanel";

            _itemNameLabel = new Label();
            _itemNameLabel.Text = "Наименование блюда";
            _itemNameLabel.Font = new Font(new FontFamily("Inter Medium"), 16.56442859476548f);
            _itemNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            _itemNameLabel.AutoSize = false;
            _itemNameLabel.Width = (_itemLayoutPanel.Width / 2) - 8;
            _itemNameLabel.Anchor = (AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right);
            //_itemNameLabel.BorderStyle = BorderStyle.FixedSingle;
            _itemLayoutPanel.Controls.Add(_itemNameLabel, 0, 0);

            _itemNumericUpDownWrap = new Panel();
            _itemLayoutPanel.Controls.Add(_itemNumericUpDownWrap, 1, 0);
            _itemNumericUpDownWrap.Anchor = (AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right);
            _itemNumericUpDownWrap.Width = (_itemLayoutPanel.Width / 2) - 8;
            _itemNumericUpDownWrap.Height = 85;

            _itemNumericUpDown = new RoundNumericUpDown();
            _itemNumericUpDown.Parent = _itemNumericUpDownWrap;
            _itemNumericUpDown.maxValue = 99;
            _itemNumericUpDown.minValue = 0;
            _itemNumericUpDown.Value = 1;
            _itemNumericUpDown.Location = new Point((_itemNumericUpDownWrap.Width / 2) - 45, _itemNumericUpDownWrap.Height / 2);

            _itemCharacteristicLayoutPanel = new TableLayoutPanel();
            _itemCharacteristicLayoutPanel.AutoSize = false;
            _itemCharacteristicLayoutPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            _itemCharacteristicLayoutPanel.Width = (_itemLayoutPanel.Width / 2) - 8;
            _itemCharacteristicLayoutPanel.Height = (_itemLayoutPanel.Height - _itemNameLabel.Height);
            _itemCharacteristicLayoutPanel.ColumnCount = 2;
            _itemCharacteristicLayoutPanel.RowCount = 1;
            _itemLayoutPanel.Controls.Add(_itemCharacteristicLayoutPanel, 0, 1);

            _itemWeightLabel = new Label();
            _itemWeightLabel.Text = string.Format("{0} {1}", 1000, "гр.");
            _itemWeightLabel.Font = new Font(new FontFamily("Inter"), 7.5292857248934f);
            _itemWeightLabel.TextAlign = ContentAlignment.MiddleLeft;
            _itemWeightLabel.AutoSize = false;
            _itemWeightLabel.MaximumSize = new Size(100, 44);
            _itemWeightLabel.Width = (_itemCharacteristicLayoutPanel.Width / 2) - 8;
            _itemWeightLabel.Height = _itemCharacteristicLayoutPanel.Height - 8;
            //_itemWeightLabel.BorderStyle = BorderStyle.FixedSingle;
            _itemWeightLabel.Anchor = (AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right);
            _itemCharacteristicLayoutPanel.Controls.Add(_itemWeightLabel, 0, 0);

            _itemCostLabel = new Label();
            _itemCostLabel = new Label();
            _itemCostLabel.Text = string.Format("{0} {1}", _itemCost, "₽");
            _itemCostLabel.Font = new Font(new FontFamily("Inter"), 7.5292857248934f);
            _itemCostLabel.TextAlign = ContentAlignment.MiddleRight;
            _itemCostLabel.AutoSize = false;
            _itemCostLabel.MaximumSize = new Size(100, 44);
            _itemCostLabel.Width = (_itemCharacteristicLayoutPanel.Width / 2) - 8;
            _itemCostLabel.Height = _itemCharacteristicLayoutPanel.Height - 8;
            //_itemCostLabel.BorderStyle = BorderStyle.FixedSingle;
            _itemCostLabel.Anchor = (AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right);
            _itemCharacteristicLayoutPanel.Controls.Add(_itemCostLabel, 1, 0);

            _itemAmountLayoutPanel = new TableLayoutPanel();
            _itemAmountLayoutPanel = new TableLayoutPanel();
            _itemAmountLayoutPanel.AutoSize = false;
            _itemAmountLayoutPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            _itemAmountLayoutPanel.Width = (_itemLayoutPanel.Width / 2) - 8;
            _itemAmountLayoutPanel.Height = (_itemLayoutPanel.Height - _itemNameLabel.Height);
            _itemAmountLayoutPanel.ColumnCount = 2;
            _itemAmountLayoutPanel.RowCount = 1;
            _itemLayoutPanel.Controls.Add(_itemAmountLayoutPanel, 1, 1);

            _itemAmountLabel = new Label();
            _itemAmountLabel = new Label();
            _itemAmountLabel.Text = "Сумма:";
            _itemAmountLabel.Font = new Font(new FontFamily("Inter"), 7.5292857248934f);
            _itemAmountLabel.TextAlign = ContentAlignment.MiddleRight;
            _itemAmountLabel.AutoSize = false;
            _itemAmountLabel.MaximumSize = new Size(100, 44);
            _itemAmountLabel.Width = (_itemAmountLayoutPanel.Width / 2) - 8;
            _itemAmountLabel.Height = _itemAmountLayoutPanel.Height - 8;
            //_itemAmountLabel.BorderStyle = BorderStyle.FixedSingle;
            _itemAmountLabel.Anchor = (AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right);
            _itemAmountLayoutPanel.Controls.Add(_itemAmountLabel, 0, 0);

            _itemAmountCostLabel = new Label();
            _itemAmountCostLabel = new Label();
            _itemAmountCostLabel = new Label();
            _itemAmountCostLabel.Text = string.Format("{0} {1}", (float)_itemNumericUpDown.Value * _itemCost, "₽");
            _itemAmountCostLabel.Font = new Font(new FontFamily("Inter"), 7.5292857248934f);
            _itemAmountCostLabel.TextAlign = ContentAlignment.MiddleLeft;
            _itemAmountCostLabel.AutoSize = false;
            _itemAmountCostLabel.MaximumSize = new Size(100, 44);
            _itemAmountCostLabel.Width = (_itemAmountLayoutPanel.Width / 2) - 8;
            _itemAmountCostLabel.Height = _itemAmountLayoutPanel.Height - 8;
            //_itemAmountCostLabel.BorderStyle = BorderStyle.FixedSingle;
            _itemAmountCostLabel.Anchor = (AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right);
            _itemAmountLayoutPanel.Controls.Add(_itemAmountCostLabel, 1, 0);
        }

        public event EventHandler AmountValueChanged
        {
            add
            {
                onAmountValueChanged = (EventHandler)Delegate.Combine(onAmountValueChanged, value);
            }
            remove
            {
                onAmountValueChanged = (EventHandler)Delegate.Remove(onAmountValueChanged, value);
            }
        }
        protected virtual void OnAmountValueChanged(EventArgs e)
        {
            if (onAmountValueChanged != null)
            {
                onAmountValueChanged(this, e);
            }
        }
    }
}
