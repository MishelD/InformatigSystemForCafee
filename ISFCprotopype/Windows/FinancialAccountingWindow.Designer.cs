
namespace ISFCprotopype
{
    partial class FinancialAccountingWindow
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
            this.exitButton = new ISFCprotopype.CustomElements.RoundButton();
            this.listButton = new ISFCprotopype.CustomElements.RoundButton();
            this.ReceiptWrap = new System.Windows.Forms.Panel();
            this.addIngredientsButton = new ISFCprotopype.CustomElements.RoundButton();
            this.orderList = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.roundButton1 = new ISFCprotopype.CustomElements.RoundButton();
            this.roundButton2 = new ISFCprotopype.CustomElements.RoundButton();
            this.roundButton3 = new ISFCprotopype.CustomElements.RoundButton();
            this.roundButton6 = new ISFCprotopype.CustomElements.RoundButton();
            this.roundButton7 = new ISFCprotopype.CustomElements.RoundButton();
            this.roundButton8 = new ISFCprotopype.CustomElements.RoundButton();
            this.roundButton9 = new ISFCprotopype.CustomElements.RoundButton();
            this.roundButton10 = new ISFCprotopype.CustomElements.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.BarPanel.Controls.Add(this.listButton);
            this.BarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarPanel.Location = new System.Drawing.Point(0, 0);
            this.BarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BarPanel.Name = "BarPanel";
            this.BarPanel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.BarPanel.Size = new System.Drawing.Size(58, 681);
            this.BarPanel.TabIndex = 0;
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
            // listButton
            // 
            this.listButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.listButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.listButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.listButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.listButton.BorderRadius = 10;
            this.listButton.BorderSize = 0;
            this.listButton.FlatAppearance.BorderSize = 0;
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listButton.ForeColor = System.Drawing.Color.White;
            this.listButton.Image = global::ISFCprotopype.Properties.Resources.listLightSmall;
            this.listButton.Location = new System.Drawing.Point(9, 10);
            this.listButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(40, 40);
            this.listButton.TabIndex = 3;
            this.listButton.TextColor = System.Drawing.Color.White;
            this.listButton.UseVisualStyleBackColor = false;
            // 
            // ReceiptWrap
            // 
            this.ReceiptWrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ReceiptWrap.Controls.Add(this.addIngredientsButton);
            this.ReceiptWrap.Controls.Add(this.orderList);
            this.ReceiptWrap.Controls.Add(this.tableLayoutPanel1);
            this.ReceiptWrap.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReceiptWrap.Location = new System.Drawing.Point(58, 0);
            this.ReceiptWrap.Margin = new System.Windows.Forms.Padding(0);
            this.ReceiptWrap.Name = "ReceiptWrap";
            this.ReceiptWrap.Size = new System.Drawing.Size(356, 681);
            this.ReceiptWrap.TabIndex = 1;
            this.ReceiptWrap.Visible = false;
            // 
            // addIngredientsButton
            // 
            this.addIngredientsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addIngredientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.addIngredientsButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.addIngredientsButton.BorderColor = System.Drawing.Color.Transparent;
            this.addIngredientsButton.BorderRadius = 22;
            this.addIngredientsButton.BorderSize = 0;
            this.addIngredientsButton.FlatAppearance.BorderSize = 0;
            this.addIngredientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIngredientsButton.Font = new System.Drawing.Font("Inter", 16.56443F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addIngredientsButton.ForeColor = System.Drawing.Color.White;
            this.addIngredientsButton.Location = new System.Drawing.Point(9, 624);
            this.addIngredientsButton.Margin = new System.Windows.Forms.Padding(10);
            this.addIngredientsButton.Name = "addIngredientsButton";
            this.addIngredientsButton.Size = new System.Drawing.Size(337, 47);
            this.addIngredientsButton.TabIndex = 0;
            this.addIngredientsButton.Text = "Добавить";
            this.addIngredientsButton.TextColor = System.Drawing.Color.White;
            this.addIngredientsButton.UseVisualStyleBackColor = false;
            this.addIngredientsButton.EnabledChanged += new System.EventHandler(this.orderButton_EnabledChanged);
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
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.10543F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.10543F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.menuFlowLayoutPanel.Controls.Add(this.roundButton6);
            this.menuFlowLayoutPanel.Controls.Add(this.roundButton7);
            this.menuFlowLayoutPanel.Controls.Add(this.roundButton8);
            this.menuFlowLayoutPanel.Controls.Add(this.roundButton9);
            this.menuFlowLayoutPanel.Controls.Add(this.roundButton10);
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
            this.roundButton1.Font = new System.Drawing.Font("Inter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.roundButton2.Font = new System.Drawing.Font("Inter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.roundButton3.Font = new System.Drawing.Font("Inter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton6.BorderRadius = 20;
            this.roundButton6.BorderSize = 0;
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.Font = new System.Drawing.Font("Inter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton6.ForeColor = System.Drawing.Color.Black;
            this.roundButton6.Location = new System.Drawing.Point(640, 20);
            this.roundButton6.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(168, 168);
            this.roundButton6.TabIndex = 24;
            this.roundButton6.Text = "Наименование блюда";
            this.roundButton6.TextColor = System.Drawing.Color.Black;
            this.roundButton6.UseVisualStyleBackColor = false;
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton7.BorderRadius = 20;
            this.roundButton7.BorderSize = 0;
            this.roundButton7.FlatAppearance.BorderSize = 0;
            this.roundButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton7.Font = new System.Drawing.Font("Inter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton7.ForeColor = System.Drawing.Color.Black;
            this.roundButton7.Location = new System.Drawing.Point(28, 208);
            this.roundButton7.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(168, 168);
            this.roundButton7.TabIndex = 25;
            this.roundButton7.Text = "Наименование блюда";
            this.roundButton7.TextColor = System.Drawing.Color.Black;
            this.roundButton7.UseVisualStyleBackColor = false;
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton8.BorderRadius = 20;
            this.roundButton8.BorderSize = 0;
            this.roundButton8.FlatAppearance.BorderSize = 0;
            this.roundButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton8.Font = new System.Drawing.Font("Inter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton8.ForeColor = System.Drawing.Color.Black;
            this.roundButton8.Location = new System.Drawing.Point(232, 208);
            this.roundButton8.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(168, 168);
            this.roundButton8.TabIndex = 26;
            this.roundButton8.Text = "Наименование блюда";
            this.roundButton8.TextColor = System.Drawing.Color.Black;
            this.roundButton8.UseVisualStyleBackColor = false;
            // 
            // roundButton9
            // 
            this.roundButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton9.BorderRadius = 20;
            this.roundButton9.BorderSize = 0;
            this.roundButton9.FlatAppearance.BorderSize = 0;
            this.roundButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton9.Font = new System.Drawing.Font("Inter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton9.ForeColor = System.Drawing.Color.Black;
            this.roundButton9.Location = new System.Drawing.Point(436, 208);
            this.roundButton9.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundButton9.Name = "roundButton9";
            this.roundButton9.Size = new System.Drawing.Size(168, 168);
            this.roundButton9.TabIndex = 27;
            this.roundButton9.Text = "Наименование блюда";
            this.roundButton9.TextColor = System.Drawing.Color.Black;
            this.roundButton9.UseVisualStyleBackColor = false;
            // 
            // roundButton10
            // 
            this.roundButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.roundButton10.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton10.BorderRadius = 20;
            this.roundButton10.BorderSize = 0;
            this.roundButton10.FlatAppearance.BorderSize = 0;
            this.roundButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton10.Font = new System.Drawing.Font("Inter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton10.ForeColor = System.Drawing.Color.Black;
            this.roundButton10.Location = new System.Drawing.Point(640, 208);
            this.roundButton10.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.Size = new System.Drawing.Size(168, 168);
            this.roundButton10.TabIndex = 28;
            this.roundButton10.Text = "Наименование блюда";
            this.roundButton10.TextColor = System.Drawing.Color.Black;
            this.roundButton10.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuFlowLayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(414, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 681);
            this.panel1.TabIndex = 3;
            // 
            // MenuEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReceiptWrap);
            this.Controls.Add(this.BarPanel);
            this.Name = "MenuEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад ингредиентов";
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
        private CustomElements.RoundButton addIngredientsButton;
        private CustomElements.RoundButton listButton;
        private CustomElements.RoundButton exitButton;
        private System.Windows.Forms.Panel panel1;
        private CustomElements.RoundButton roundButton1;
        private CustomElements.RoundButton roundButton2;
        private CustomElements.RoundButton roundButton3;
        private CustomElements.RoundButton roundButton6;
        private CustomElements.RoundButton roundButton7;
        private CustomElements.RoundButton roundButton8;
        private CustomElements.RoundButton roundButton9;
        private CustomElements.RoundButton roundButton10;
    }
}

