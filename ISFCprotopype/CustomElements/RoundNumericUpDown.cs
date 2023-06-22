using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISFCprotopype.CustomElements
{
    internal class RoundNumericUpDown : UserControl
    {
        private Label valueLabel;
        private RoundButton numericDownButton;
        private RoundButton numericUpButton;

        private EventHandler onValueChanged;

        private int _value = 1;

        public int minValue = 0;
        public int maxValue = 99;
        public int Value
        {
            get { return _value; }
            set
            {
                if (value >= minValue && value <= maxValue)
                {
                    _value = value;
                    this.valueLabel.Text = _value.ToString();
                    this.Invalidate();
                    onValueChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private Color greyWhite = Color.FromArgb(238, 238, 238);

        public RoundNumericUpDown()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.valueLabel = new System.Windows.Forms.Label();
            this.numericDownButton = new ISFCprotopype.CustomElements.RoundButton();
            this.numericUpButton = new ISFCprotopype.CustomElements.RoundButton();
            this.SuspendLayout();
            // 
            // valueLabel
            // 
            this.valueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.valueLabel.Font = new System.Drawing.Font("Inter Medium", 16.56443F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel.Location = new System.Drawing.Point(17, 0);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(58, 28);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "1";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericDownButton
            // 
            this.numericDownButton.BackColor = System.Drawing.Color.Transparent;
            this.numericDownButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.numericDownButton.BackgroundImage = global::ISFCprotopype.Properties.Resources.minusCirlceViolet;
            this.numericDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.numericDownButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.numericDownButton.BorderRadius = 13;
            this.numericDownButton.BorderSize = 0;
            this.numericDownButton.FlatAppearance.BorderSize = 0;
            this.numericDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericDownButton.ForeColor = System.Drawing.Color.White;
            this.numericDownButton.Location = new System.Drawing.Point(0, 0);
            this.numericDownButton.Name = "numericDownButton";
            this.numericDownButton.Size = new System.Drawing.Size(28, 28);
            this.numericDownButton.TabIndex = 5;
            this.numericDownButton.TextColor = System.Drawing.Color.White;
            this.numericDownButton.UseVisualStyleBackColor = false;
            this.numericDownButton.Click += new System.EventHandler(this.numericDownButton_Click);
            // 
            // numericUpButton
            // 
            this.numericUpButton.BackColor = System.Drawing.Color.Transparent;
            this.numericUpButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.numericUpButton.BackgroundImage = global::ISFCprotopype.Properties.Resources.plusCirlceViolet;
            this.numericUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.numericUpButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.numericUpButton.BorderRadius = 13;
            this.numericUpButton.BorderSize = 0;
            this.numericUpButton.FlatAppearance.BorderSize = 0;
            this.numericUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericUpButton.ForeColor = System.Drawing.Color.White;
            this.numericUpButton.Location = new System.Drawing.Point(62, 0);
            this.numericUpButton.Name = "numericUpButton";
            this.numericUpButton.Size = new System.Drawing.Size(28, 28);
            this.numericUpButton.TabIndex = 6;
            this.numericUpButton.TextColor = System.Drawing.Color.White;
            this.numericUpButton.UseVisualStyleBackColor = false;
            this.numericUpButton.Click += new System.EventHandler(this.numericUpButton_Click);
            // 
            // RoundNumericUpDown
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.numericUpButton);
            this.Controls.Add(this.numericDownButton);
            this.Controls.Add(this.valueLabel);
            this.Name = "RoundNumericUpDown";
            this.Size = new System.Drawing.Size(90, 28);
            this.ResumeLayout(false);

        }

        private void numericDownButton_Click(object sender, EventArgs e)
        {
            this.Value--;
            this.valueLabel.Text = this.Value.ToString();
        }

        private void numericUpButton_Click(object sender, EventArgs e)
        {
            this.Value++;
            this.valueLabel.Text = this.Value.ToString();
        }

        public event EventHandler ValueChanged
        {
            add
            {
                onValueChanged = (EventHandler)Delegate.Combine(onValueChanged, value);
            }
            remove
            {
                onValueChanged = (EventHandler)Delegate.Remove(onValueChanged, value);
            }
        }
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (onValueChanged != null)
            {
                onValueChanged(this, e);
            }
        }

    }
}
