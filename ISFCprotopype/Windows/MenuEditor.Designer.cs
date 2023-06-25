
namespace ISFCprotopype
{
    partial class MenuEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEditor));
            this.BarPanel = new System.Windows.Forms.Panel();
            this.exitButton = new ISFCprotopype.CustomElements.RoundButton();
            this.listButton = new ISFCprotopype.CustomElements.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.блюдаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.блюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseCafeDataSet = new ISFCprotopype.databaseCafeDataSet();
            this.блюдаTableAdapter = new ISFCprotopype.databaseCafeDataSetTableAdapters.БлюдаTableAdapter();
            this.tableAdapterManager = new ISFCprotopype.databaseCafeDataSetTableAdapters.TableAdapterManager();
            this.блюдаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.блюдаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.BarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingNavigator)).BeginInit();
            this.блюдаBindingNavigator.SuspendLayout();
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
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.блюдаDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(58, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 681);
            this.panel1.TabIndex = 3;
            // 
            // блюдаDataGridView
            // 
            this.блюдаDataGridView.AutoGenerateColumns = false;
            this.блюдаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.блюдаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.блюдаDataGridView.DataSource = this.блюдаBindingSource;
            this.блюдаDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.блюдаDataGridView.Location = new System.Drawing.Point(0, 28);
            this.блюдаDataGridView.Name = "блюдаDataGridView";
            this.блюдаDataGridView.Size = new System.Drawing.Size(1206, 653);
            this.блюдаDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dish_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "dish_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dish_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "dish_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mass";
            this.dataGridViewTextBoxColumn5.HeaderText = "mass";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "unit_of_measure";
            this.dataGridViewTextBoxColumn6.HeaderText = "unit_of_measure";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "image";
            this.dataGridViewImageColumn1.HeaderText = "image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // блюдаBindingSource
            // 
            this.блюдаBindingSource.DataMember = "Блюда";
            this.блюдаBindingSource.DataSource = this.databaseCafeDataSet;
            // 
            // databaseCafeDataSet
            // 
            this.databaseCafeDataSet.DataSetName = "databaseCafeDataSet";
            this.databaseCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // блюдаTableAdapter
            // 
            this.блюдаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ISFCprotopype.databaseCafeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БлюдаTableAdapter = this.блюдаTableAdapter;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.ИнгредиентыTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.Состав_блюдаTableAdapter = null;
            this.tableAdapterManager.Состав_заказаTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // блюдаBindingNavigator
            // 
            this.блюдаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.блюдаBindingNavigator.BindingSource = this.блюдаBindingSource;
            this.блюдаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.блюдаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.блюдаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.блюдаBindingNavigatorSaveItem});
            this.блюдаBindingNavigator.Location = new System.Drawing.Point(58, 0);
            this.блюдаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.блюдаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.блюдаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.блюдаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.блюдаBindingNavigator.Name = "блюдаBindingNavigator";
            this.блюдаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.блюдаBindingNavigator.Size = new System.Drawing.Size(1206, 25);
            this.блюдаBindingNavigator.TabIndex = 4;
            this.блюдаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // блюдаBindingNavigatorSaveItem
            // 
            this.блюдаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.блюдаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("блюдаBindingNavigatorSaveItem.Image")));
            this.блюдаBindingNavigatorSaveItem.Name = "блюдаBindingNavigatorSaveItem";
            this.блюдаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.блюдаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.блюдаBindingNavigatorSaveItem.Click += new System.EventHandler(this.блюдаBindingNavigatorSaveItem_Click);
            // 
            // MenuEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.блюдаBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarPanel);
            this.Name = "MenuEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuEditor_FormClosing);
            this.Load += new System.EventHandler(this.MenuEditor_Load);
            this.BarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.блюдаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingNavigator)).EndInit();
            this.блюдаBindingNavigator.ResumeLayout(false);
            this.блюдаBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarPanel;
        private CustomElements.RoundButton listButton;
        private CustomElements.RoundButton exitButton;
        private System.Windows.Forms.Panel panel1;
        private databaseCafeDataSet databaseCafeDataSet;
        private System.Windows.Forms.BindingSource блюдаBindingSource;
        private databaseCafeDataSetTableAdapters.БлюдаTableAdapter блюдаTableAdapter;
        private databaseCafeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator блюдаBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton блюдаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView блюдаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}

