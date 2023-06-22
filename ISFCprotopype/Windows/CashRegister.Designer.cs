
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
            this.orderList = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundPanel1 = new ISFCprotopype.CustomElements.RoundPanel();
            this.orderButton = new ISFCprotopype.CustomElements.RoundButton();
            this.receiptItem1 = new ISFCprotopype.CustomElements.ReceiptItem();
            this.exitButton = new ISFCprotopype.CustomElements.RoundButton();
            this.UserButton = new ISFCprotopype.CustomElements.RoundButton();
            this.roundPanel2 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel3 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel4 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel5 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel6 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel7 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel8 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel9 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel10 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel11 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel12 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel13 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel14 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel15 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel16 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel17 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel18 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel19 = new ISFCprotopype.CustomElements.RoundPanel();
            this.roundPanel20 = new ISFCprotopype.CustomElements.RoundPanel();
            this.BarPanel.SuspendLayout();
            this.ReceiptWrap.SuspendLayout();
            this.orderList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarPanel
            // 
            this.BarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BarPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.BarPanel.Controls.Add(this.exitButton);
            this.BarPanel.Controls.Add(this.UserButton);
            this.BarPanel.Location = new System.Drawing.Point(0, 0);
            this.BarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BarPanel.Name = "BarPanel";
            this.BarPanel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.BarPanel.Size = new System.Drawing.Size(58, 681);
            this.BarPanel.TabIndex = 0;
            // 
            // ReceiptWrap
            // 
            this.ReceiptWrap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ReceiptWrap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReceiptWrap.Controls.Add(this.orderButton);
            this.ReceiptWrap.Controls.Add(this.orderList);
            this.ReceiptWrap.Controls.Add(this.tableLayoutPanel1);
            this.ReceiptWrap.Location = new System.Drawing.Point(58, 0);
            this.ReceiptWrap.Margin = new System.Windows.Forms.Padding(0);
            this.ReceiptWrap.Name = "ReceiptWrap";
            this.ReceiptWrap.Size = new System.Drawing.Size(351, 681);
            this.ReceiptWrap.TabIndex = 1;
            // 
            // orderList
            // 
            this.orderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderList.AutoScroll = true;
            this.orderList.BackColor = System.Drawing.Color.Transparent;
            this.orderList.Controls.Add(this.receiptItem1);
            this.orderList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.orderList.Location = new System.Drawing.Point(9, 10);
            this.orderList.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(332, 536);
            this.orderList.TabIndex = 2;
            this.orderList.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.amountLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 570);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 44);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.BackColor = System.Drawing.Color.Transparent;
            this.amountLabel.Font = new System.Drawing.Font("Inter Medium", 27.10543F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(178, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(170, 44);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "2500 ₽";
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
            this.label1.Size = new System.Drawing.Size(169, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Итого:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.roundPanel1);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel2);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel3);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel4);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel5);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel6);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel7);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel8);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel9);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel10);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel11);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel12);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel13);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel14);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel15);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel16);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel17);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel18);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel19);
            this.flowLayoutPanel1.Controls.Add(this.roundPanel20);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(855, 681);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(409, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 681);
            this.panel1.TabIndex = 3;
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel1.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel1.BorderRadius = 10;
            this.roundPanel1.BorderSize = 0;
            this.roundPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundPanel1.Location = new System.Drawing.Point(28, 20);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(168, 168);
            this.roundPanel1.TabIndex = 0;
            this.roundPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // orderButton
            // 
            this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.orderButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.orderButton.BorderColor = System.Drawing.Color.Transparent;
            this.orderButton.BorderRadius = 22;
            this.orderButton.BorderSize = 0;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Inter Medium", 16.56443F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Location = new System.Drawing.Point(9, 624);
            this.orderButton.Margin = new System.Windows.Forms.Padding(10);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(332, 47);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Заказать";
            this.orderButton.TextColor = System.Drawing.Color.White;
            this.orderButton.UseVisualStyleBackColor = false;
            // 
            // receiptItem1
            // 
            this.receiptItem1.BackColor = System.Drawing.Color.White;
            this.receiptItem1.BackgroundColor = System.Drawing.Color.White;
            this.receiptItem1.BorderColor = System.Drawing.Color.Gray;
            this.receiptItem1.BorderRadius = 10;
            this.receiptItem1.BorderSize = 0;
            this.receiptItem1.ForeColor = System.Drawing.Color.Black;
            this.receiptItem1.Location = new System.Drawing.Point(0, 10);
            this.receiptItem1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.receiptItem1.Name = "receiptItem1";
            this.receiptItem1.Size = new System.Drawing.Size(316, 125);
            this.receiptItem1.TabIndex = 0;
            this.receiptItem1.TextColor = System.Drawing.Color.Black;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.exitButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.exitButton.BackgroundImage = global::ISFCprotopype.Properties.Resources.exitLight;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exitButton.BorderRadius = 10;
            this.exitButton.BorderSize = 0;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(9, 631);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.TextColor = System.Drawing.Color.White;
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // UserButton
            // 
            this.UserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.UserButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.UserButton.BackgroundImage = global::ISFCprotopype.Properties.Resources.userLight;
            this.UserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.UserButton.BorderRadius = 10;
            this.UserButton.BorderSize = 0;
            this.UserButton.FlatAppearance.BorderSize = 0;
            this.UserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButton.ForeColor = System.Drawing.Color.White;
            this.UserButton.Location = new System.Drawing.Point(9, 10);
            this.UserButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(40, 40);
            this.UserButton.TabIndex = 3;
            this.UserButton.TextColor = System.Drawing.Color.White;
            this.UserButton.UseVisualStyleBackColor = false;
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel2.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel2.BorderRadius = 10;
            this.roundPanel2.BorderSize = 0;
            this.roundPanel2.ForeColor = System.Drawing.Color.Black;
            this.roundPanel2.Location = new System.Drawing.Point(232, 20);
            this.roundPanel2.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(168, 168);
            this.roundPanel2.TabIndex = 1;
            this.roundPanel2.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel3
            // 
            this.roundPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel3.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel3.BorderRadius = 10;
            this.roundPanel3.BorderSize = 0;
            this.roundPanel3.ForeColor = System.Drawing.Color.Black;
            this.roundPanel3.Location = new System.Drawing.Point(436, 20);
            this.roundPanel3.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(168, 168);
            this.roundPanel3.TabIndex = 2;
            this.roundPanel3.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel4
            // 
            this.roundPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel4.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel4.BorderRadius = 10;
            this.roundPanel4.BorderSize = 0;
            this.roundPanel4.ForeColor = System.Drawing.Color.Black;
            this.roundPanel4.Location = new System.Drawing.Point(640, 20);
            this.roundPanel4.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel4.Name = "roundPanel4";
            this.roundPanel4.Size = new System.Drawing.Size(168, 168);
            this.roundPanel4.TabIndex = 3;
            this.roundPanel4.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel5
            // 
            this.roundPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel5.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel5.BorderRadius = 10;
            this.roundPanel5.BorderSize = 0;
            this.roundPanel5.ForeColor = System.Drawing.Color.Black;
            this.roundPanel5.Location = new System.Drawing.Point(28, 208);
            this.roundPanel5.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel5.Name = "roundPanel5";
            this.roundPanel5.Size = new System.Drawing.Size(168, 168);
            this.roundPanel5.TabIndex = 4;
            this.roundPanel5.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel6
            // 
            this.roundPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel6.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel6.BorderRadius = 10;
            this.roundPanel6.BorderSize = 0;
            this.roundPanel6.ForeColor = System.Drawing.Color.Black;
            this.roundPanel6.Location = new System.Drawing.Point(232, 208);
            this.roundPanel6.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel6.Name = "roundPanel6";
            this.roundPanel6.Size = new System.Drawing.Size(168, 168);
            this.roundPanel6.TabIndex = 5;
            this.roundPanel6.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel7
            // 
            this.roundPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel7.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel7.BorderRadius = 10;
            this.roundPanel7.BorderSize = 0;
            this.roundPanel7.ForeColor = System.Drawing.Color.Black;
            this.roundPanel7.Location = new System.Drawing.Point(436, 208);
            this.roundPanel7.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel7.Name = "roundPanel7";
            this.roundPanel7.Size = new System.Drawing.Size(168, 168);
            this.roundPanel7.TabIndex = 6;
            this.roundPanel7.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel8
            // 
            this.roundPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel8.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel8.BorderRadius = 10;
            this.roundPanel8.BorderSize = 0;
            this.roundPanel8.ForeColor = System.Drawing.Color.Black;
            this.roundPanel8.Location = new System.Drawing.Point(640, 208);
            this.roundPanel8.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel8.Name = "roundPanel8";
            this.roundPanel8.Size = new System.Drawing.Size(168, 168);
            this.roundPanel8.TabIndex = 7;
            this.roundPanel8.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel9
            // 
            this.roundPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel9.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel9.BorderRadius = 10;
            this.roundPanel9.BorderSize = 0;
            this.roundPanel9.ForeColor = System.Drawing.Color.Black;
            this.roundPanel9.Location = new System.Drawing.Point(28, 396);
            this.roundPanel9.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel9.Name = "roundPanel9";
            this.roundPanel9.Size = new System.Drawing.Size(168, 168);
            this.roundPanel9.TabIndex = 8;
            this.roundPanel9.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel10
            // 
            this.roundPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel10.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel10.BorderRadius = 10;
            this.roundPanel10.BorderSize = 0;
            this.roundPanel10.ForeColor = System.Drawing.Color.Black;
            this.roundPanel10.Location = new System.Drawing.Point(232, 396);
            this.roundPanel10.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel10.Name = "roundPanel10";
            this.roundPanel10.Size = new System.Drawing.Size(168, 168);
            this.roundPanel10.TabIndex = 9;
            this.roundPanel10.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel11
            // 
            this.roundPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel11.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel11.BorderRadius = 10;
            this.roundPanel11.BorderSize = 0;
            this.roundPanel11.ForeColor = System.Drawing.Color.Black;
            this.roundPanel11.Location = new System.Drawing.Point(436, 396);
            this.roundPanel11.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel11.Name = "roundPanel11";
            this.roundPanel11.Size = new System.Drawing.Size(168, 168);
            this.roundPanel11.TabIndex = 10;
            this.roundPanel11.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel12
            // 
            this.roundPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel12.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel12.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel12.BorderRadius = 10;
            this.roundPanel12.BorderSize = 0;
            this.roundPanel12.ForeColor = System.Drawing.Color.Black;
            this.roundPanel12.Location = new System.Drawing.Point(640, 396);
            this.roundPanel12.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel12.Name = "roundPanel12";
            this.roundPanel12.Size = new System.Drawing.Size(168, 168);
            this.roundPanel12.TabIndex = 11;
            this.roundPanel12.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel13
            // 
            this.roundPanel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel13.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel13.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel13.BorderRadius = 10;
            this.roundPanel13.BorderSize = 0;
            this.roundPanel13.ForeColor = System.Drawing.Color.Black;
            this.roundPanel13.Location = new System.Drawing.Point(28, 584);
            this.roundPanel13.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel13.Name = "roundPanel13";
            this.roundPanel13.Size = new System.Drawing.Size(168, 168);
            this.roundPanel13.TabIndex = 12;
            this.roundPanel13.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel14
            // 
            this.roundPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel14.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel14.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel14.BorderRadius = 10;
            this.roundPanel14.BorderSize = 0;
            this.roundPanel14.ForeColor = System.Drawing.Color.Black;
            this.roundPanel14.Location = new System.Drawing.Point(232, 584);
            this.roundPanel14.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel14.Name = "roundPanel14";
            this.roundPanel14.Size = new System.Drawing.Size(168, 168);
            this.roundPanel14.TabIndex = 13;
            this.roundPanel14.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel15
            // 
            this.roundPanel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel15.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel15.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel15.BorderRadius = 10;
            this.roundPanel15.BorderSize = 0;
            this.roundPanel15.ForeColor = System.Drawing.Color.Black;
            this.roundPanel15.Location = new System.Drawing.Point(436, 584);
            this.roundPanel15.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel15.Name = "roundPanel15";
            this.roundPanel15.Size = new System.Drawing.Size(168, 168);
            this.roundPanel15.TabIndex = 14;
            this.roundPanel15.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel16
            // 
            this.roundPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel16.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel16.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel16.BorderRadius = 10;
            this.roundPanel16.BorderSize = 0;
            this.roundPanel16.ForeColor = System.Drawing.Color.Black;
            this.roundPanel16.Location = new System.Drawing.Point(640, 584);
            this.roundPanel16.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel16.Name = "roundPanel16";
            this.roundPanel16.Size = new System.Drawing.Size(168, 168);
            this.roundPanel16.TabIndex = 15;
            this.roundPanel16.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel17
            // 
            this.roundPanel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel17.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel17.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel17.BorderRadius = 10;
            this.roundPanel17.BorderSize = 0;
            this.roundPanel17.ForeColor = System.Drawing.Color.Black;
            this.roundPanel17.Location = new System.Drawing.Point(28, 772);
            this.roundPanel17.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel17.Name = "roundPanel17";
            this.roundPanel17.Size = new System.Drawing.Size(168, 168);
            this.roundPanel17.TabIndex = 16;
            this.roundPanel17.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel18
            // 
            this.roundPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel18.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel18.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel18.BorderRadius = 10;
            this.roundPanel18.BorderSize = 0;
            this.roundPanel18.ForeColor = System.Drawing.Color.Black;
            this.roundPanel18.Location = new System.Drawing.Point(232, 772);
            this.roundPanel18.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel18.Name = "roundPanel18";
            this.roundPanel18.Size = new System.Drawing.Size(168, 168);
            this.roundPanel18.TabIndex = 17;
            this.roundPanel18.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel19
            // 
            this.roundPanel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel19.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel19.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel19.BorderRadius = 10;
            this.roundPanel19.BorderSize = 0;
            this.roundPanel19.ForeColor = System.Drawing.Color.Black;
            this.roundPanel19.Location = new System.Drawing.Point(436, 772);
            this.roundPanel19.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel19.Name = "roundPanel19";
            this.roundPanel19.Size = new System.Drawing.Size(168, 168);
            this.roundPanel19.TabIndex = 18;
            this.roundPanel19.TextColor = System.Drawing.Color.Black;
            // 
            // roundPanel20
            // 
            this.roundPanel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel20.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundPanel20.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel20.BorderRadius = 10;
            this.roundPanel20.BorderSize = 0;
            this.roundPanel20.ForeColor = System.Drawing.Color.Black;
            this.roundPanel20.Location = new System.Drawing.Point(640, 772);
            this.roundPanel20.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundPanel20.Name = "roundPanel20";
            this.roundPanel20.Size = new System.Drawing.Size(168, 168);
            this.roundPanel20.TabIndex = 19;
            this.roundPanel20.TextColor = System.Drawing.Color.Black;
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
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Касса";
            this.BarPanel.ResumeLayout(false);
            this.ReceiptWrap.ResumeLayout(false);
            this.orderList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarPanel;
        private System.Windows.Forms.Panel ReceiptWrap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel orderList;
        private CustomElements.RoundButton orderButton;
        private CustomElements.RoundButton UserButton;
        private CustomElements.RoundButton exitButton;
        private System.Windows.Forms.Panel panel1;
        private CustomElements.ReceiptItem receiptItem1;
        private CustomElements.RoundPanel roundPanel1;
        private CustomElements.RoundPanel roundPanel2;
        private CustomElements.RoundPanel roundPanel3;
        private CustomElements.RoundPanel roundPanel4;
        private CustomElements.RoundPanel roundPanel5;
        private CustomElements.RoundPanel roundPanel6;
        private CustomElements.RoundPanel roundPanel7;
        private CustomElements.RoundPanel roundPanel8;
        private CustomElements.RoundPanel roundPanel9;
        private CustomElements.RoundPanel roundPanel10;
        private CustomElements.RoundPanel roundPanel11;
        private CustomElements.RoundPanel roundPanel12;
        private CustomElements.RoundPanel roundPanel13;
        private CustomElements.RoundPanel roundPanel14;
        private CustomElements.RoundPanel roundPanel15;
        private CustomElements.RoundPanel roundPanel16;
        private CustomElements.RoundPanel roundPanel17;
        private CustomElements.RoundPanel roundPanel18;
        private CustomElements.RoundPanel roundPanel19;
        private CustomElements.RoundPanel roundPanel20;
    }
}

