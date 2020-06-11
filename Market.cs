using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WellStreet
{
    public partial class Market : Form
    {

        public int cash;
        private ListBox.SelectedObjectCollection selectedItems;
        private int quanty;
        

        public Market()
        {
           
            InitializeComponent();
            textBoxCash.Text = "5000";
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            
            cash = Convert.ToInt32(textBoxCash.Text);
            int buy = Convert.ToInt32(tbTotal.Text);

            { 
                //tbwarehouse.Text = Convert.ToString(quanty);
                if ((cash >= buy))
                {
                    cash -= buy;
                    textBoxCash.Text = Convert.ToString(cash);
                    

                    selectedItems = listBoxBuy.SelectedItems;
                    for (int j = 0; j < selectedItems.Count; j++)
                    {
                        listBoxSell.Items.Add(selectedItems[j]);
                        listBoxBuy.Items.Add(selectedItems[j]);
                        tbwarehouse.Text = Convert.ToString(quanty);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Not enough money!");
                }
                
            }
         }
        
                        

        private void listBoxBuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxBuy.SelectedIndex)
            {
                case 0:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.adidas;
                    tbPrice.Text = "3000";
                    
                    break;
                case 1:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.puma_logo_1;
                    tbPrice.Text = "3200";
                    break;
                case 2:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.NIKE_logo;
                    tbPrice.Text = "3500";
                    break;
                case 3:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.audi;
                    tbPrice.Text = "7000";
                    break;
                case 4:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.bmw;
                    tbPrice.Text = "6000";
                    break;
                case 5:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.Mercedes_Benz_logo_3;
                    tbPrice.Text = "10000";
                    break;
                case 6:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.Skoda_logo_2;
                    tbPrice.Text = "5000";
                    break;
                case 7:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.volvo;
                    tbPrice.Text = "6000";
                    break;
                case 8:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.vw;
                    tbPrice.Text = "10000";
                    break;
                case 9:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.subway;
                    tbPrice.Text = "4000";
                    break;
                case 10:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.kfcc;
                    tbPrice.Text = "4200";
                    break;
                case 11:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.mc;
                    tbPrice.Text = "4500";
                    break;
                case 12:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.barsa;
                    tbPrice.Text = "7000";
                    break;
                case 13:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.bayern;
                    tbPrice.Text = "8000";
                    break;
                case 14:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.bvb;
                    tbPrice.Text = "6000";
                    break;
                case 15:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.Chelsea_FC_logo;
                    tbPrice.Text = "6500";
                    break;
                case 16:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.liverpoool;
                    tbPrice.Text = "6200";
                    break;
                case 17:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.man_city;
                    tbPrice.Text = "5000";
                    break;
                case 18:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.man_und;
                    tbPrice.Text = "10000";
                    break;
                case 19:
                    pictureBoxActions.Image = WellStreet.Properties.Resources.Real_Madrid_C_6;
                    tbPrice.Text = "9500";
                    break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            var price = Convert.ToInt32(tbPrice.Text);
            quanty = int.Parse(tbQuantity.Text);
            
            quanty = Convert.ToInt32(tbQuantity.Text);
            
            int total = quanty * price;
            tbTotal.Text = Convert.ToString(total);
        }

        public static void textBoxCash_TextChanged(object sender, EventArgs e) 
        {
            
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            int Sale = int.Parse(textBox2.Text);
            if (Sale > 0)
            {
                cash = Convert.ToInt32(textBoxCash.Text);

                cash = cash + Sale;
                textBoxCash.Text = Convert.ToString(cash);
                for (int j = 0; j < selectedItems.Count; j++)
                {
                    listBoxSell.Items.Remove(listBoxSell.SelectedItem);
                    tbwarehouse.Text = Convert.ToString(j);

                }

            }
            else
            {
                MessageBox.Show("Please enter a positive number!");
            }
            
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            textBoxCash.Text = "5000";
            tbwarehouse.Text = Convert.ToString(0);
            
                listBoxSell.Items.Clear();
            



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void Market_Load(object sender, EventArgs e)
        {

            
            }
    }
}

