using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Restaurant_Management_App
{
    public partial class login: Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        public void SetRoundedPanel(Panel panel, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            SetRoundedPanel(panel1, 50);
        }

        private void login_Load(object sender, EventArgs e)


        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;




            // Apply rounded corners to the panel
            SetRoundedPanel(panel1, 50);

            // Create and add custom rounded button
            roundedbtn loginbtn = new roundedbtn();
            loginbtn.Text = "Login";
            loginbtn.Size = new Size(100, 40);
            loginbtn.Location = new Point(130, 350);
            loginbtn.BorderRadius = 20;
         

            loginbtn.BackColor = Color.Orange;
            loginbtn.ForeColor = Color.White;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.FlatAppearance.BorderSize = 0;

            panel1.Controls.Add(loginbtn);
            loginbtn.BringToFront();





            emailtxtbox.Text = "Enter email";
            emailtxtbox.ForeColor = Color.Gray;



            passwrd.Text = "Enter password";
            passwrd.ForeColor = Color.Gray;
            passwrd.UseSystemPasswordChar = false;

        }

        private void emailtxtbox_Enter(object sender, EventArgs e)
        {
            
                if (emailtxtbox.Text == "Enter email")
                {
                    emailtxtbox.Text = "";
                    emailtxtbox.ForeColor = Color.Black;
                }
            
        }

        private void emailtxtbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailtxtbox.Text))
            {
                emailtxtbox.Text = "Enter email";
                emailtxtbox.ForeColor = Color.Gray;
            }
        }

        private void passwrd_Enter(object sender, EventArgs e)
        {
            if (passwrd.Text == "Enter password")
            {
                passwrd.Text = "";
                passwrd.ForeColor = Color.Black;
                passwrd.UseSystemPasswordChar = true;
            }
        }

        private void passwrd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwrd.Text))
            {
                passwrd.Text = "Enter password";
                passwrd.ForeColor = Color.Gray;
                passwrd.UseSystemPasswordChar = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string passward = passwrd.Text.Trim();
            if (string.IsNullOrWhiteSpace(passward)){
                MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string connectionString = "server=localhost;user=root;password=Saman;database=restaurant_management_app;port=3306;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE email = @Email AND password = @Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", emailtxtbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", passward);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        // User exists, proceed to the next form
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        dashboard mainForm = new dashboard();
                        mainForm.Show();
                    }
                    else
                    {
                        // User does not exist
                        MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
