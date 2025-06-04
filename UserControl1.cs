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
    public partial class UserControl1: UserControl

    {
        public event EventHandler ItemClicked;


        public UserControl1()
        {
            InitializeComponent();
            this.Click += (s, e) => ItemClicked?.Invoke(this, EventArgs.Empty);

            // Optional: make inner labels also clickable
            guna2HtmlLabel1.Click += (s, e) => ItemClicked?.Invoke(this, EventArgs.Empty);
            priceLbl.Click += (s, e) => ItemClicked?.Invoke(this, EventArgs.Empty); // <-- also add this if not present
            this.Click += TriggerClick;
            guna2HtmlLabel1.Click += TriggerClick;
            priceLbl.Click += TriggerClick;
            this.BackgroundImageLayout = ImageLayout.Stretch;




        }
        [Browsable(true)]
        [Category("Custom Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ItemName
        {
            get => guna2HtmlLabel1.Text;
            set => guna2HtmlLabel1.Text = value;
        }

        [Browsable(true)]
        [Category("Custom Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ItemPrice
        {
            get => priceLbl.Text;
            set => priceLbl.Text = value;
        }
        [Browsable(true)]
        public string DummyRefreshProperty { get; set; }



        private void TriggerClick(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, EventArgs.Empty); // 🔥 Fires click to Specials.cs
        }
        private void UserControl1_MouseEnter(object sender, EventArgs e)
        {
        
            
        }

        private void UserControl1_MouseHover(object sender, EventArgs e)
        {
          
        }
        private void HandleClick(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
