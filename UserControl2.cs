using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_App
{
    public partial class orderUserControl: UserControl
    {
        public orderUserControl()
        {
            InitializeComponent();
          
        }
        // Public property for item name
        public string ItemName
{
    get => guna2HtmlLabel1.Text;
    set => guna2HtmlLabel1.Text = value;
}

public string ItemPrice
{
    get => guna2HtmlLabel2.Text;
    set => guna2HtmlLabel2.Text = value;
}


        private void orderUserControl_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
