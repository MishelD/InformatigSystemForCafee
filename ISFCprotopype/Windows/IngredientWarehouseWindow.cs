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
using ISFCprotopype.CustomElements;
using ISFCprotopype.Windows.DialogWindows;

namespace ISFCprotopype
{
    public partial class IngredientWarehouseWindow : Form
    {
        private Color darkViolet = Color.FromArgb(73, 62, 194);
        private Color violet = Color.FromArgb(93, 95, 239);
        private Color lightViolet = Color.FromArgb(120, 121, 241);
        private Color greyWhite = Color.FromArgb(238, 238, 238);

        public IngredientWarehouseWindow()
        {
            InitializeComponent();
            SetBGColor();
        }

        private void SetBGColor()
        {
            BarPanel.BackColor = violet;
        }

        private void ингредиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ингредиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCafeDataSet);

        }

        private void IngredientWarehouseWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this.databaseCafeDataSet.Ингредиенты);

        }

        private void IngredientWarehouseWindow_FormClosing(object sender, FormClosingEventArgs e)
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
