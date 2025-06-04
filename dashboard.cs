using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Restaurant_Management_App
{
    public partial class dashboard: Form
    {
        public dashboard()
        {
            InitializeComponent();

            gradient.FillColor = Color.FromArgb(180, 0, 0, 0); // 70% opacity black
            gradient.FillColor2 = Color.Transparent;
            gradient.UseTransparentBackground = true;
            gradient.BackColor = Color.Transparent;

            // Ensure the overlay is on top of background but below other controls
            gradient.BringToFront();
            menuBarPanel.BringToFront();

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            //heroimage.SendToBack();
            contactPanel.BringToFront();
            //guna2Panel1.BringToFront();
            SetupMenuBar();
            PositionMenuBar();


        }
        private void dashboard_Resize(object sender, EventArgs e)
        {
            PositionMenuBar();
        }
        private void SetupMenuBar()
        {
            //60% opacity
            menuBarPanel.FillColor = Color.FromArgb(153, 0, 0, 0);
            //menuBarPanel.BorderRadius = 0;
            menuBarPanel.BackColor = Color.Transparent;
            menuBarPanel.ShadowDecoration.Enabled = true;
            menuBarPanel.ShadowDecoration.Depth = 5;
            menuBarPanel.ShadowDecoration.Color = Color.Black;
            menuBarPanel.Height = 60;

        }

        private void heroimage_Click(object sender, EventArgs e)
        {

        }

        private void guna2menubtn_Click(object sender, EventArgs e)
        {
            guna2menubtn.Text = "OUR MENU";
            guna2menubtn.FillColor = Color.Transparent;
            guna2menubtn.ForeColor = Color.Goldenrod;
            guna2menubtn.BorderRadius = 20;
            guna2menubtn.BorderThickness = 2;
            guna2menubtn.BorderColor = Color.Goldenrod;
            guna2menubtn.Cursor = Cursors.Hand;
            guna2menubtn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            guna2menubtn.Size = new Size(140, 40);





        }

        private void menupanel_Paint(object sender, PaintEventArgs e)
        {
            //Location = new Point(0, contactPanel.Height);



        }

        private void homeLbl_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Orange;  // Hover color
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        }

        private void homeLbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.White;  // Default color
            lbl.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        }

        private void contactUsLbl_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Orange;  // Hover color
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        }

        private void contactUsLbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.White;  // Default color
            lbl.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        }

      
      

      

       

        private void orderLbl_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Orange;  // Hover color
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        }

        private void orderLbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.White;  // Default color
            lbl.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        }

        private void menuLbl_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Orange;  // Hover color
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        }

        private void menuLbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.White;  // Default color
            lbl.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        }

        private void specialsLbl_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Orange;  // Hover color
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        }

        private void specialsLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Specials specialsForm = new Specials();
            specialsForm.Show();
        }

        private void specialsLbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.White;  // Default color
            lbl.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        }

        private void guna2CirclePictureBox1_MouseEnter(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.ShadowDecoration.Enabled = true;
            guna2CirclePictureBox1.ShadowDecoration.Color = Color.Orange;
            guna2CirclePictureBox1.Size = new Size(80, 80);
        }

        private void guna2CirclePictureBox1_MouseLeave(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.ShadowDecoration.Enabled = false;
            guna2CirclePictureBox1.Size = new Size(70, 70);
        }

        private void menuBarPanel_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void PositionMenuBar()
        {
            menuBarPanel.Width = this.Width;
            menuBarPanel.Height = 60;
            menuBarPanel.Location = new Point(0,contactPanel.Top + contactPanel.Height);


        }

        private void orderLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef ChefForm = new Chef();
            ChefForm.Show();
        }
    }
}
