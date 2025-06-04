using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Mysqlx.Expect.Open.Types.Condition.Types;


namespace Restaurant_Management_App
{
    public partial class Specials: Form
    {
        private Size originalSizeImage;
        private Point originalImageLocation;
      
        private Padding originalImagePadding;
        public event EventHandler ItemClicked;
        public Specials()

        {

            InitializeComponent();
            originalSizeImage = userControl11.Size;
            originalImageLocation = userControl11.Location;

            originalImagePadding = this.Padding;
        }
        private void LoadMenuItemsFromDatabase()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT name, price FROM menu_items";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                cardsPanel.Controls.Clear(); // Optional: clear existing cards

                while (reader.Read())
                {
                    string name = reader.GetString("name");
                    string price = "Rs " + reader.GetDecimal("price").ToString("F0");

                    UserControl1 item = new UserControl1();
                    item.ItemName = name;
                    item.ItemPrice = price;

                    cardsPanel.Controls.Add(item);
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_MouseEnter(object sender, EventArgs e)
        {
           
        }
        
        

        private void burger_image1_MouseLeave(object sender, EventArgs e)
        {
            userControl11.Size = originalSizeImage;
            userControl11.Location = originalImageLocation;

            this.Padding = originalImagePadding;



        }

        private void burger_image1_MouseHover(object sender, EventArgs e)
        {
            userControl11.Size = new Size(userControl11.Width + 10, userControl11.Height + 10);
            userControl11.Location = new Point(userControl11.Location.X - 5, userControl11.Location.Y - 5);

            this.Padding = new Padding(2);
        

    }

        private void orderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderUserControl4_Load(object sender, EventArgs e)
        {

        }

        private void Specials_Load(object sender, EventArgs e)
        {
            LoadMenuItemsFromDatabase();  // ✅ This is all you need!
            LoadMenuItemsIntoFixedControls();

            cardsPanel.Controls.AddRange(new Control[]
{
       
            //userControl11, userControl12, userControl13,
            //userControl14, userControl15, userControl16,
            //userControl17, userControl18, userControl19,
            //userControl110, userControl111, userControl112
        });


        }
        private void LoadMenuItemsIntoFixedControls()

             {
      

            List<UserControl1> userControls = new List<UserControl1>()
    {
        userControl11, userControl12, userControl13, userControl14,
        userControl15, userControl16, userControl17, userControl18,
        userControl19, userControl110, userControl111, userControl112
    };









            Dictionary<string, Image> itemImages = new Dictionary<string, Image>()
{
    { "hamburger", Properties.Resources.hamburger },
    { "fish", Properties.Resources.Fish },
    { "pasta", Properties.Resources.Pasta },
    { "sandwich", Properties.Resources.Sandwich },
    { "chicken pieces", Properties.Resources.ChickenPieces },
    { "chicken kabab", Properties.Resources.ChickenKabab },
    { "pizza", Properties.Resources.Pizza },
    { "orange juice", Properties.Resources.OrangeJuice },
    { "smoothies", Properties.Resources.Smoothies },
    { "cheesy fries", Properties.Resources.CheeszyFries },
    { "burrito", Properties.Resources.Burrito }
};

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT name, price FROM menu_items LIMIT 12";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                int index = 0;

                while (reader.Read() && index < userControls.Count)
                {
                    string name = reader.GetString("name");
                    decimal price = reader.GetDecimal("price");
                    string key = name.ToLower().Trim(); // normalize

                    UserControl1 item = new UserControl1();
                    item.ItemName = name;
                    item.ItemPrice = "Rs " + price.ToString("F0");
                    item.ItemClicked += UserControl_ItemClicked; // 
                    cardsPanel.Controls.Add(item);

               

                    {
                        AddToOrder(name, "Rs " + price.ToString("F0"));
                    };


                    if (itemImages.ContainsKey(key))
                    {
                        item.BackgroundImage = itemImages[key];
                        item.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        item.BackgroundImage = Properties.Resources.hamburger; // fallback
                    }

                    index++;
                }
            }

            }

        private void AddToOrder(string name, string price)
        {
            orderUserControl order = new orderUserControl();
            order.ItemName = name;
            order.ItemPrice = price;
            orderPanel.Controls.Add(order);
        }

//usercontrol
        private void UserControl_ItemClicked(object sender, EventArgs e)
        {
            if (sender is UserControl1 item)
            {
                AddToOrder(item.ItemName, item.ItemPrice);
            }
        }

        private void coffeebtn_Click(object sender, EventArgs e)
        {

        }

        private void cardsPanel_Paint(object sender, PaintEventArgs e)
        {
            cardsPanel.AutoScroll = true;

        }

        private void userControl11_Load(object sender, EventArgs e)
        {


        }
    }
}
