using ISFCprotopype.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public MainWindow()
        {
            InitializeComponent();

            //ingredientWarehouseButton.BackgroundColor = greyWhite;
            //ingredientWarehouseButton.ForeColor = Color.Gray;
            //ingredientWarehouseButton.BorderSize = 1;
            //ingredientWarehouseButton.BorderColor = Color.Gray;

            financialAccountingButton.BackgroundColor = greyWhite;
            financialAccountingButton.ForeColor = Color.Gray;
            financialAccountingButton.BorderSize = 1;
            financialAccountingButton.BorderColor = Color.Gray;

            menuButton.BackgroundColor = greyWhite;
            menuButton.ForeColor = Color.Gray;
            menuButton.BorderSize = 1;
            menuButton.BorderColor = Color.Gray;

            peopleManagementButton.BackgroundColor = greyWhite;
            peopleManagementButton.ForeColor = Color.Gray;
            peopleManagementButton.BorderSize = 1;
            peopleManagementButton.BorderColor = Color.Gray;
        }

        private void CashRegisterButton_Click(object sender, EventArgs e)
        {
            CashRegister cashRegister = new CashRegister();
            this.Hide();
            cashRegister.Closed += (s, args) => this.Close();
            cashRegister.Show();
        }

        private void ingredientWarehouseButton_Click(object sender, EventArgs e)
        {
            IngredientWarehouse ingredientWarehouse = new IngredientWarehouse();
            this.Hide();
            ingredientWarehouse.Closed += (s, args) => this.Close();
            ingredientWarehouse.Show();
        }
    }
}
