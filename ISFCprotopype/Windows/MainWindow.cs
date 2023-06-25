using ISFCprotopype.CustomElements;
using ISFCprotopype.Windows.DialogWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISFCprotopype.Windows
{
    public partial class MainWindow : Form
    {
        private Color darkViolet = Color.FromArgb(73, 62, 194);
        private Color violet = Color.FromArgb(93, 95, 239);
        private Color lightViolet = Color.FromArgb(120, 121, 241);
        private Color greyWhite = Color.FromArgb(238, 238, 238);

        public bool adminIsAutorize = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CashRegisterButton_Click(object sender, EventArgs e)
        {
            CashRegisterWindow cashRegister = new CashRegisterWindow();
            this.Hide();
            cashRegister.Closed += (s, args) => this.Show();
            cashRegister.Show();
        }

        private void ingredientWarehouseButton_Click(object sender, EventArgs e)
        {
            IngredientWarehouseWindow ingredientWarehouse = new IngredientWarehouseWindow();
            this.Hide();
            ingredientWarehouse.Closed += (s, args) => this.Show();
            ingredientWarehouse.Show();
        }

        private void financialAccountingButton_Click(object sender, EventArgs e)
        {
            FinancialAccountingWindow financialAccounting = new FinancialAccountingWindow();
            this.Hide();
            financialAccounting.Closed += (s, args) => this.Show();
            financialAccounting.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

            MenuEditor menuEditor = new MenuEditor();
            this.Hide();
            menuEditor.Closed += (s, args) => this.Show();
            menuEditor.Show();
        }

        private void peopleManagementButton_Click(object sender, EventArgs e)
        {

            PeopleManagementWindow peopleManagement = new PeopleManagementWindow();
            this.Hide();
            peopleManagement.Closed += (s, args) => this.Show();
            peopleManagement.Show();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            AutorizeWindow autorizeWindow = new AutorizeWindow();
            autorizeWindow.cancelButton.Text = "Выход";

            /// Статус авторизации
            // Значение равно -1: выход из программы
            // Значение равно 1: успешная авторизация
            int autorizeStatus = 0;

            while (autorizeStatus == 0 && !adminIsAutorize)
            {
                DialogResult result = autorizeWindow.ShowDialog();
                if (result == DialogResult.OK && autorizeWindow.passwordTextBox.Texts == "admin")
                {
                    autorizeStatus = 1;
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
                    SystemSounds.Exclamation.Play();

                    AutorizeWindow exitWindow = new AutorizeWindow();

                    exitWindow.headlineLabel.Text = "Выйти?";
                    exitWindow.descriptionLabel.Text = "Если не авторизоваться то программа закроется";
                    exitWindow.passwordTextBox.Visible = false;
                    exitWindow.autorizeButton.Text = "Выход";
                    exitWindow.cancelButton.Text = "Отмена";

                    DialogResult exitResult = exitWindow.ShowDialog();

                    if (exitResult == DialogResult.OK)
                    {
                        autorizeStatus = -1;
                    }
                }
            }

            if (autorizeStatus == -1)
            {
                this.Close();
            }
        }
    }
}
