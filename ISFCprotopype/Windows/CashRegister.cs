﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISFCprotopype.CustomElements;
using ISFCprotopype.CustomElements.CashRegister;
using ISFCprotopype.databaseCafeDataSetTableAdapters;
using ISFCprotopype.Windows;
using ISFCprotopype.Windows.DialogWindows;

namespace ISFCprotopype
{
    public partial class CashRegisterWindow : Form
    {
        private Color darkViolet = Color.FromArgb(73, 62, 194);
        private Color violet = Color.FromArgb(93, 95, 239);
        private Color lightViolet = Color.FromArgb(120, 121, 241);
        private Color greyWhite = Color.FromArgb(238, 238, 238);

        private bool cashierIsAutorize = false;

        private float _amountCost;
        public float AmountCost
        {
            get
            {
                return _amountCost;
            }
            set
            {
                _amountCost = value;
            }
        }

        public CashRegisterWindow()
        {
            InitializeComponent();
            SetBGColor();
            UpdateAmountLabel();
            CashierIsAutorize();
        }

        private void SetBGColor()
        {
            BarPanel.BackColor = violet;
            ReceiptWrap.BackColor = greyWhite;
            orderButton.BackgroundColor = violet;
        }

        public void UpdateAmountLabel()
        {
            float amount = 0;

            foreach (ReceiptItem item in orderList.Controls)
            {
                amount += item.AmountCost;
            }

            AmountCost = amount;
            amountLabel.Text = string.Format("{0} ₽", AmountCost);

            if (AmountCost == 0)
            {
                orderButton.Enabled = false;
            }
            else
            {
                orderButton.Enabled = true;
            }
        }

        private void CashierIsAutorize()
        {
            if (!cashierIsAutorize)
            {
                menuFlowLayoutPanel.Visible = false;
                amountLabel.Visible = false;
                amountTextLabel.Visible = false;
                orderButton.Enabled = false;
            }
            else
            {
                menuFlowLayoutPanel.Visible = true;
                amountLabel.Visible = true;
                amountTextLabel.Visible = true;
                orderButton.Enabled = true;
            }
        }

        private void orderList_ControlAdded(object sender, ControlEventArgs e)
        {
            foreach (ReceiptItem item in orderList.Controls)
            {
                item.AmountValueChanged += (s, args) =>
                {
                    UpdateAmountLabel();
                };
            }

            UpdateAmountLabel();
        }

        private void orderList_ControlRemoved(object sender, ControlEventArgs e)
        {
            UpdateAmountLabel();
        }

        private void orderButton_EnabledChanged(object sender, EventArgs e)
        {
            RoundButton button = (RoundButton)sender;
            if (!button.Enabled)
            {
                button.BackgroundColor = greyWhite;
                button.ForeColor = Color.Gray;
                button.BorderSize = 1;
                button.BorderColor = Color.Gray;
            }
            else
            {
                button.BackgroundColor = violet;
                button.ForeColor = Color.White;
                button.BorderSize = 0;
            }
        }

        private void CashRegister_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet1.Состав_заказа". При необходимости она может быть перемещена или удалена.
            this.состав_заказаTableAdapter.Fill(this.databaseCafeDataSet1.Состав_заказа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet1.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.databaseCafeDataSet1.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet1.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.databaseCafeDataSet1.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet1.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter1.Fill(this.databaseCafeDataSet1.Блюда);
            
            // Добавление списка блюд в меню из базы данных
            foreach (DataRow row in databaseCafeDataSet1.Блюда)
            {
                MenuListItem menuItem = new MenuListItem();
                menuItem.ItemDishId = (int)row["dish_id"];
                menuItem.ItemName = (string)row["dish_name"];
                menuItem.ItemCost = (float)Convert.ToSingle(row["price"]);
                menuItem.ItemWeight = (float)Convert.ToSingle(row["mass"]);
                menuItem.ItemUnitOfMeasure = (string)row["unit_of_measure"];
                menuFlowLayoutPanel.Controls.Add(menuItem);
                
                // Подписка на клик одного из блюд в виде вызова функции добавления позиции в список заказа
                menuItem.ClickItem += (s, args) =>
                {
                    MenuListItem clickedMenuItem = (MenuListItem)s;
                    bool isDuplicate = false;

                    // Проверка на дубликат позиции в списке заказа
                    foreach (ReceiptItem item in orderList.Controls)
                    {
                        if (menuItem.ItemDishId == item.ItemDishId)
                        {
                            isDuplicate = true;
                            item.ItemCount++;
                            break;
                        }
                    }
                    // Если дубликат не найден
                    if (!isDuplicate)
                    {
                        // Создание позиции в списке заказа
                        ReceiptItem receiptItem = new ReceiptItem();
                        receiptItem.ItemDishId = clickedMenuItem.ItemDishId;
                        receiptItem.ItemName = clickedMenuItem.ItemName;
                        receiptItem.ItemCost = clickedMenuItem.ItemCost;
                        receiptItem.ItemWeight = clickedMenuItem.ItemWeight;
                        receiptItem.ItemUnitOfMeasure = clickedMenuItem.ItemUnitOfMeasure;
                        receiptItem.UpdateAmountCost();
                        orderList.Controls.Add(receiptItem);
                    }
                };
            }
            //for (int i = 0; i < databaseCafeDataSet.Блюда.Count; i++)
            //{
            //    MenuListItem menuItem = new MenuListItem();
            //    menuItem.NameItem = (string)databaseCafeDataSet.Блюда.Rows["dish_name"];
            //    menuItem.NameItem = (string)databaseCafeDataSet.Блюда.Rows[i][1];
            //    menuItem.MassItem = (float)databaseCafeDataSet.Блюда.Rows[i][5];
            //    menuFlowLayoutPanel.Controls.Add(menuItem);
            //}

        }

        private void блюдаBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.блюдаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCafeDataSet);

        }

        private void блюдаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.блюдаBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.databaseCafeDataSet1);

        }

        private void блюдаBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.блюдаBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.databaseCafeDataSet1);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CashRegisterWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = AutorizeForExit(e);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private bool AutorizeForExit(FormClosingEventArgs e)
        {
            AutorizeWindow autorizeWindow = new AutorizeWindow();
            autorizeWindow.headlineLabel.Text = "Сменить режим?";
            autorizeWindow.descriptionLabel.Text = "Для смены режима требуется пароль администратора";
            autorizeWindow.autorizeButton.Text = "Выход";

            /// Статус авторизации
            // Значение равно -1: выход из режима
            // Значение равно 1: отмена выхода из режима
            int autorizeStatus = 0;

            while (autorizeStatus == 0)
            {
                DialogResult result = autorizeWindow.ShowDialog();
                if (result == DialogResult.OK && autorizeWindow.passwordTextBox.Texts == "admin")
                {
                    autorizeStatus = -1;
                    e.Cancel = false;
                    return e.Cancel;
                }
                else if (result == DialogResult.OK && autorizeWindow.passwordTextBox.Texts == "")
                {
                    SystemSounds.Exclamation.Play();

                    autorizeWindow.passwordTextBox.PlaceholderText = "Введите пароль";
                    autorizeWindow.passwordTextBox.PlaceholderColor = Color.FromArgb(240, 122, 117);
                    autorizeWindow.passwordTextBox.BorderColor = Color.FromArgb(240, 122, 117);
                }
                else if (result == DialogResult.OK && autorizeWindow.passwordTextBox.Texts != "" && autorizeWindow.passwordTextBox.Texts != "admin")
                {
                    SystemSounds.Exclamation.Play();

                    autorizeWindow.passwordTextBox.PlaceholderText = "Неверный пароль";
                    autorizeWindow.passwordTextBox.PlaceholderColor = Color.FromArgb(240, 122, 117);
                    autorizeWindow.passwordTextBox.BorderColor = Color.FromArgb(240, 122, 117);
                }
                else
                {
                    autorizeStatus = 1;
                    e.Cancel = true;
                    return e.Cancel;
                }
            }

            if (autorizeStatus == -1)
            {
                e.Cancel = false;
                return e.Cancel;
            }
            else
            {
                autorizeStatus = 1;
                e.Cancel = true;
                return e.Cancel;
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            CashRegisterAutorizeWindow autorizeWindow = new CashRegisterAutorizeWindow();
            DialogResult result = autorizeWindow.ShowDialog();
            if (result == DialogResult.OK)
            {
                cashierIsAutorize = true;
                CashierIsAutorize();
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            databaseCafeDataSet.ПользователиRow row = (databaseCafeDataSet.ПользователиRow)this.databaseCafeDataSet1.Пользователи.Rows[0];
            //databaseCafeDataSet1.ПользователиRow
            DataRow orderRow = this.databaseCafeDataSet1.Заказы.NewRow();
            int orderId = (int)this.databaseCafeDataSet1.Заказы.Rows[this.databaseCafeDataSet1.Заказы.Rows.Count - 1]["order_id"] + 1;
            orderRow["order_id"] = orderId;
            orderRow["order_date"] = DateTime.UtcNow;
            orderRow["status"] = "В процессе";
            orderRow["total_amount"] = AmountCost;
            orderRow["customer_id"] = 1;

            this.databaseCafeDataSet1.Заказы.AddЗаказыRow((databaseCafeDataSet.ЗаказыRow)orderRow);

            foreach (ReceiptItem item in orderList.Controls)
            {
                DataRow compositionOrderRow = this.databaseCafeDataSet1.Состав_заказа.NewRow();
                compositionOrderRow["quantity"] = item.ItemCount;
                compositionOrderRow["order_id"] = orderId;
                compositionOrderRow["dish_id"] = item.ItemDishId;
                this.databaseCafeDataSet1.Состав_заказа.AddСостав_заказаRow((databaseCafeDataSet.Состав_заказаRow)compositionOrderRow);
            }

            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.состав_заказаBindingSource.EndEdit();
            this.databaseCafeDataSet1.AcceptChanges();
            this.заказыTableAdapter.Update(databaseCafeDataSet1);
            this.состав_заказаTableAdapter.Update(databaseCafeDataSet1);

            orderList.Controls.Clear();
        }
    }
}
