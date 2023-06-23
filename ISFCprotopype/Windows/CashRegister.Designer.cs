
namespace ISFCprotopype
{
    partial class CashRegister
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarPanel = new System.Windows.Forms.Panel();
            this.ReceiptWrap = new System.Windows.Forms.Panel();
            this.orderButton = new ISFCprotopype.CustomElements.RoundButton();
            this.orderList = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.roundButton1 = new ISFCprotopype.CustomElements.RoundButton();
            this.roundButton2 = new ISFCprotopype.CustomElements.RoundButton();
            this.roundButton3 = new ISFCprotopype.CustomElements.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new ISFCprotopype.CustomElements.RoundButton();
            this.userButton = new ISFCprotopype.CustomElements.RoundButton();
            this.BarPanel.SuspendLayout();
            this.ReceiptWrap.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarPanel
            // 
            this.BarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.BarPanel.Controls.Add(this.exitButton);
            this.BarPanel.Controls.Add(this.userButton);
            this.BarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarPanel.Location = new System.Drawing.Point(0, 0);
            this.BarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BarPanel.Name = "BarPanel";
            this.BarPanel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.BarPanel.Size = new System.Drawing.Size(58, 681);
            this.BarPanel.TabIndex = 0;
            // 
            // ReceiptWrap
            // 
            this.ReceiptWrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ReceiptWrap.Controls.Add(this.orderButton);
            this.ReceiptWrap.Controls.Add(this.orderList);
            this.ReceiptWrap.Controls.Add(this.tableLayoutPanel1);
            this.ReceiptWrap.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReceiptWrap.Location = new System.Drawing.Point(58, 0);
            this.ReceiptWrap.Margin = new System.Windows.Forms.Padding(0);
            this.ReceiptWrap.Name = "ReceiptWrap";
            this.ReceiptWrap.Size = new System.Drawing.Size(356, 681);
            this.ReceiptWrap.TabIndex = 1;
            // 
            // orderButton
            // 
            this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.orderButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.orderButton.BorderColor = System.Drawing.Color.Transparent;
            this.orderButton.BorderRadius = 22;
            this.orderButton.BorderSize = 0;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Inter", 16.56443F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Location = new System.Drawing.Point(9, 624);
            this.orderButton.Margin = new System.Windows.Forms.Padding(10);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(337, 47);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Заказать";
            this.orderButton.TextColor = System.Drawing.Color.White;
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.EnabledChanged += new System.EventHandler(this.orderButton_EnabledChanged);
            // 
            // orderList
            // 
            this.orderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderList.AutoScroll = true;
            this.orderList.BackColor = System.Drawing.Color.Transparent;
            this.orderList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.orderList.Location = new System.Drawing.Point(9, 10);
            this.orderList.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(337, 536);
            this.orderList.TabIndex = 2;
            this.orderList.WrapContents = false;
            this.orderList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.orderList_ControlAdded);
            this.orderList.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.orderList_ControlRemoved);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.59544F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.40456F));
            this.tableLayoutPanel1.Controls.Add(this.amountLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 570);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 44);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.BackColor = System.Drawing.Color.Transparent;
            this.amountLabel.Font = new System.Drawing.Font("Inter Medium", 27.10543F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(151, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(202, 44);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "0 ₽";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 27.10543F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Итого:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.AutoScroll = true;
            this.menuFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuFlowLayoutPanel.Controls.Add(this.roundButton1);
            this.menuFlowLayoutPanel.Controls.Add(this.roundButton2);
            this.menuFlowLayoutPanel.Controls.Add(this.roundButton3);
            this.menuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.menuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(850, 681);
            this.menuFlowLayoutPanel.TabIndex = 2;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Inter", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(28, 20);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(168, 168);
            this.roundButton1.TabIndex = 21;
            this.roundButton1.Text = "Наименование блюда";
            this.roundButton1.TextColor = System.Drawing.Color.Black;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton2.BorderRadius = 20;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Inter", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Location = new System.Drawing.Point(232, 20);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(168, 168);
            this.roundButton2.TabIndex = 22;
            this.roundButton2.Text = "Наименование блюда";
            this.roundButton2.TextColor = System.Drawing.Color.Black;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton3.BorderRadius = 20;
            this.roundButton3.BorderSize = 0;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Inter", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton3.ForeColor = System.Drawing.Color.Black;
            this.roundButton3.Location = new System.Drawing.Point(436, 20);
            this.roundButton3.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(168, 168);
            this.roundButton3.TabIndex = 23;
            this.roundButton3.Text = "Наименование блюда";
            this.roundButton3.TextColor = System.Drawing.Color.Black;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuFlowLayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(414, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 681);
            this.panel1.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.exitButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exitButton.BorderRadius = 10;
            this.exitButton.BorderSize = 0;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::ISFCprotopype.Properties.Resources.logoutLightSmall;
            this.exitButton.Location = new System.Drawing.Point(9, 631);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.TextColor = System.Drawing.Color.White;
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.userButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.userButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.userButton.BorderRadius = 10;
            this.userButton.BorderSize = 0;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.Image = global::ISFCprotopype.Properties.Resources.userLightSmall;
            this.userButton.Location = new System.Drawing.Point(9, 10);
            this.userButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(40, 40);
            this.userButton.TabIndex = 3;
            this.userButton.TextColor = System.Drawing.Color.White;
            this.userButton.UseVisualStyleBackColor = false;
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReceiptWrap);
            this.Controls.Add(this.BarPanel);
            this.Name = "CashRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Касса";
            this.BarPanel.ResumeLayout(false);
            this.ReceiptWrap.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarPanel;
        private System.Windows.Forms.Panel ReceiptWrap;
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel orderList;
        private CustomElements.RoundButton orderButton;
        private CustomElements.RoundButton userButton;
        private CustomElements.RoundButton exitButton;
        private System.Windows.Forms.Panel panel1;
        private CustomElements.RoundButton roundButton1;
        private CustomElements.RoundButton roundButton2;
        private CustomElements.RoundButton roundButton3;
    }
}

