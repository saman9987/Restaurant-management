namespace Restaurant_Management_App
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.contactPanel = new System.Windows.Forms.Panel();
            this.contactlbl = new System.Windows.Forms.Label();
            this.orderLbl = new System.Windows.Forms.Label();
            this.menuLbl = new System.Windows.Forms.Label();
            this.contactUsLbl = new System.Windows.Forms.Label();
            this.specialsLbl = new System.Windows.Forms.Label();
            this.titlelbl = new System.Windows.Forms.Label();
            this.subtitlelbl = new System.Windows.Forms.Label();
            this.guna2menubtn = new Guna.UI2.WinForms.Guna2Button();
            this.gradient = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.menuBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.homeLbl = new System.Windows.Forms.Label();
            this.contactPanel.SuspendLayout();
            this.gradient.SuspendLayout();
            this.menuBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contactPanel
            // 
            this.contactPanel.BackColor = System.Drawing.Color.Black;
            this.contactPanel.Controls.Add(this.contactlbl);
            this.contactPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactPanel.Location = new System.Drawing.Point(0, 0);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(1250, 40);
            this.contactPanel.TabIndex = 1;
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlbl.ForeColor = System.Drawing.Color.White;
            this.contactlbl.Location = new System.Drawing.Point(37, 9);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(221, 15);
            this.contactlbl.TabIndex = 0;
            this.contactlbl.Text = "Contact@Saman.com | +1 5589 55488 55";
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.orderLbl.Location = new System.Drawing.Point(1116, 25);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(84, 21);
            this.orderLbl.TabIndex = 11;
            this.orderLbl.Text = "Our Chefs";
            this.orderLbl.Click += new System.EventHandler(this.orderLbl_Click);
            this.orderLbl.MouseEnter += new System.EventHandler(this.orderLbl_MouseEnter);
            this.orderLbl.MouseLeave += new System.EventHandler(this.orderLbl_MouseLeave);
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.BackColor = System.Drawing.Color.Transparent;
            this.menuLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuLbl.Location = new System.Drawing.Point(752, 25);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(54, 21);
            this.menuLbl.TabIndex = 13;
            this.menuLbl.Text = "Menu";
            this.menuLbl.MouseEnter += new System.EventHandler(this.menuLbl_MouseEnter);
            this.menuLbl.MouseLeave += new System.EventHandler(this.menuLbl_MouseLeave);
            // 
            // contactUsLbl
            // 
            this.contactUsLbl.AutoSize = true;
            this.contactUsLbl.BackColor = System.Drawing.Color.Transparent;
            this.contactUsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactUsLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.contactUsLbl.Location = new System.Drawing.Point(959, 25);
            this.contactUsLbl.Name = "contactUsLbl";
            this.contactUsLbl.Size = new System.Drawing.Size(92, 21);
            this.contactUsLbl.TabIndex = 10;
            this.contactUsLbl.Text = "Contact Us";
            this.contactUsLbl.MouseEnter += new System.EventHandler(this.contactUsLbl_MouseEnter);
            this.contactUsLbl.MouseLeave += new System.EventHandler(this.contactUsLbl_MouseLeave);
            // 
            // specialsLbl
            // 
            this.specialsLbl.AutoSize = true;
            this.specialsLbl.BackColor = System.Drawing.Color.Transparent;
            this.specialsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialsLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.specialsLbl.Location = new System.Drawing.Point(848, 25);
            this.specialsLbl.Name = "specialsLbl";
            this.specialsLbl.Size = new System.Drawing.Size(72, 21);
            this.specialsLbl.TabIndex = 12;
            this.specialsLbl.Text = "Specials";
            this.specialsLbl.Click += new System.EventHandler(this.specialsLbl_Click);
            this.specialsLbl.MouseEnter += new System.EventHandler(this.specialsLbl_MouseEnter);
            this.specialsLbl.MouseLeave += new System.EventHandler(this.specialsLbl_MouseLeave);
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.BackColor = System.Drawing.Color.Black;
            this.titlelbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.White;
            this.titlelbl.Location = new System.Drawing.Point(200, 280);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(330, 50);
            this.titlelbl.TabIndex = 2;
            this.titlelbl.Text = "Welcome to Tasty";
            // 
            // subtitlelbl
            // 
            this.subtitlelbl.AutoSize = true;
            this.subtitlelbl.BackColor = System.Drawing.Color.Black;
            this.subtitlelbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitlelbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.subtitlelbl.Location = new System.Drawing.Point(200, 350);
            this.subtitlelbl.Name = "subtitlelbl";
            this.subtitlelbl.Size = new System.Drawing.Size(536, 32);
            this.subtitlelbl.TabIndex = 3;
            this.subtitlelbl.Text = "Delivering great food for more than 18 years!";
            // 
            // guna2menubtn
            // 
            this.guna2menubtn.AutoRoundedCorners = true;
            this.guna2menubtn.BorderColor = System.Drawing.Color.OrangeRed;
            this.guna2menubtn.BorderRadius = 21;
            this.guna2menubtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2menubtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2menubtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2menubtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2menubtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2menubtn.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2menubtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2menubtn.ForeColor = System.Drawing.Color.White;
            this.guna2menubtn.Location = new System.Drawing.Point(200, 400);
            this.guna2menubtn.Name = "guna2menubtn";
            this.guna2menubtn.Size = new System.Drawing.Size(140, 45);
            this.guna2menubtn.TabIndex = 5;
            this.guna2menubtn.Text = "Our Menu";
            this.guna2menubtn.Click += new System.EventHandler(this.guna2menubtn_Click);
            // 
            // gradient
            // 
            this.gradient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gradient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradient.BackgroundImage")));
            this.gradient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradient.Controls.Add(this.menuBarPanel);
            this.gradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient.Location = new System.Drawing.Point(0, 40);
            this.gradient.Name = "gradient";
            this.gradient.Size = new System.Drawing.Size(1250, 660);
            this.gradient.TabIndex = 6;
            // 
            // menuBarPanel
            // 
            this.menuBarPanel.BackColor = System.Drawing.SystemColors.Control;
            this.menuBarPanel.Controls.Add(this.orderLbl);
            this.menuBarPanel.Controls.Add(this.contactUsLbl);
            this.menuBarPanel.Controls.Add(this.specialsLbl);
            this.menuBarPanel.Controls.Add(this.menuLbl);
            this.menuBarPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.menuBarPanel.Controls.Add(this.homeLbl);
            this.menuBarPanel.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuBarPanel.Location = new System.Drawing.Point(0, 0);
            this.menuBarPanel.Name = "menuBarPanel";
            this.menuBarPanel.Size = new System.Drawing.Size(1250, 60);
            this.menuBarPanel.TabIndex = 0;
            this.menuBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuBarPanel_Paint);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(53, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(56, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            this.guna2CirclePictureBox1.MouseEnter += new System.EventHandler(this.guna2CirclePictureBox1_MouseEnter);
            this.guna2CirclePictureBox1.MouseLeave += new System.EventHandler(this.guna2CirclePictureBox1_MouseLeave);
            // 
            // homeLbl
            // 
            this.homeLbl.AutoSize = true;
            this.homeLbl.BackColor = System.Drawing.Color.Transparent;
            this.homeLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.homeLbl.Location = new System.Drawing.Point(649, 25);
            this.homeLbl.Name = "homeLbl";
            this.homeLbl.Size = new System.Drawing.Size(56, 21);
            this.homeLbl.TabIndex = 9;
            this.homeLbl.Text = "Home";
            this.homeLbl.MouseEnter += new System.EventHandler(this.homeLbl_MouseEnter);
            this.homeLbl.MouseLeave += new System.EventHandler(this.homeLbl_MouseLeave);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.gradient);
            this.Controls.Add(this.guna2menubtn);
            this.Controls.Add(this.subtitlelbl);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.contactPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.contactPanel.ResumeLayout(false);
            this.contactPanel.PerformLayout();
            this.gradient.ResumeLayout(false);
            this.menuBarPanel.ResumeLayout(false);
            this.menuBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel contactPanel;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label subtitlelbl;
        private Guna.UI2.WinForms.Guna2Button guna2menubtn;
        private Guna.UI2.WinForms.Guna2GradientPanel gradient;
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.Label menuLbl;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label contactUsLbl;
        private System.Windows.Forms.Label specialsLbl;
        private Guna.UI2.WinForms.Guna2Panel menuBarPanel;
        private System.Windows.Forms.Label homeLbl;
    }
}