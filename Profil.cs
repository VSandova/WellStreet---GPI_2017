using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WellStreet
{
    public partial class Profil : Form
    {

        //List<string> usernames = new List<string>();
        //string path = "users.txt";
        public static string username { get; set; }
        string name;

        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            lbUserFull.Text = Form1.username;
            lbCashFull.Text = "5000";
            lbStockFull.Text = "0";
            //playerMoney = username.Dollar;
            //currentPrice = (decimal)price;

        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Market market = new Market();
            market.Show();

        }

        private void tbStock_TextChanged(object sender, EventArgs e)
        {

        }
        public void ReloadContent()
        {

        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbUserFull_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPEG files|*.jpg|PNG files|*.png|BMP files|*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {

                Bitmap bmp = new Bitmap(open.FileName);
                bmp.Save(open.SafeFileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                File.Move(open.SafeFileName, "Pictures\\" + open.SafeFileName);

                pbPicProfil.ImageLocation = "Pictures\\" + open.SafeFileName;
                name = open.SafeFileName;
               

                
            }
        }

        private void lbCashFull_Click(object sender, EventArgs e)
        {
           
        }

        private void lbStockFull_Click(object sender, EventArgs e)
        {
        }
    }
}
