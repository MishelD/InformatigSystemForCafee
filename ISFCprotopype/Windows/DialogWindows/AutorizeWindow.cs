using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ISFCprotopype.Windows.DialogWindows
{
    internal class AutorizeWindow : Form
    {
        public CustomElements.RoundButton roundButton1;
        public CustomElements.RoundButton roundButton2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;

        public AutorizeWindow()
        {
            InitializeComponent();
        }

    private void InitializeComponent()
        {
            this.roundButton1 = new ISFCprotopype.CustomElements.RoundButton();
            this.roundButton2 = new ISFCprotopype.CustomElements.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(153, 243);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(150, 40);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Lavender;
            this.roundButton2.BackgroundColor = System.Drawing.Color.Lavender;
            this.roundButton2.BorderColor = System.Drawing.Color.Gray;
            this.roundButton2.BorderRadius = 20;
            this.roundButton2.BorderSize = 1;
            this.roundButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Location = new System.Drawing.Point(344, 243);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(150, 40);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "roundButton2";
            this.roundButton2.TextColor = System.Drawing.Color.Black;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(228, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "Для дальнейшего пользования введите логин и пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutorizeWindow
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutorizeWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
