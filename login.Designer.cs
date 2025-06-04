namespace Restaurant_Management_App
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.passwrd = new System.Windows.Forms.TextBox();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.loginlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.passwrd);
            this.panel1.Controls.Add(this.emailtxtbox);
            this.panel1.Controls.Add(this.loginlbl);
            this.panel1.Location = new System.Drawing.Point(456, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(240, 24);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(95, 25);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Sign Up";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // passwrd
            // 
            this.passwrd.BackColor = System.Drawing.Color.White;
            this.passwrd.Location = new System.Drawing.Point(84, 281);
            this.passwrd.Name = "passwrd";
            this.passwrd.Size = new System.Drawing.Size(200, 20);
            this.passwrd.TabIndex = 2;
            this.passwrd.Enter += new System.EventHandler(this.passwrd_Enter);
            this.passwrd.Leave += new System.EventHandler(this.passwrd_Leave);
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.BackColor = System.Drawing.Color.White;
            this.emailtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxtbox.Location = new System.Drawing.Point(84, 212);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(200, 17);
            this.emailtxtbox.TabIndex = 1;
            this.emailtxtbox.Enter += new System.EventHandler(this.emailtxtbox_Enter);
            this.emailtxtbox.Leave += new System.EventHandler(this.emailtxtbox_Leave);
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlbl.Location = new System.Drawing.Point(138, 145);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(76, 31);
            this.loginlbl.TabIndex = 0;
            this.loginlbl.Text = "login";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 621);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "login";
            this.Text = "loginform";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.TextBox passwrd;
        private System.Windows.Forms.TextBox emailtxtbox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

