using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WellStreet
{
    public partial class Registar : Form
    {
        string path = "users.txt";
        public static List<string> usernames = new List<string>();
        List<string> passwords = new List<string>();
        private bool flag;

        public Registar()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();

            string password = tbpassword.Text.Trim();

            if (username != string.Empty && password != string.Empty)
            {
                {
                    using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                string[] splitted = line.Split(',');
                                usernames.Add(splitted[0]);

                            }
                            for (int i = 0; i < usernames.Count; i++)
                            {
                                if (usernames[i] != username)
                                {
                                    flag = true;

                                }
                                else
                                {
                                    flag = false;
                                    break;

                                }


                            }

                        }
                    }


                    if (flag == true)
                    {
                        using (FileStream ffs = new FileStream(path, FileMode.Append))
                        {
                            using (StreamWriter sw = new StreamWriter(ffs))
                            {
                                sw.WriteLine(username);
                                sw.WriteLine(password);
                                MessageBox.Show("You have successfully signed up. Restart and log into your profile!");
                            }
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username taken!");
                    }





                }

            }
        }



        private void Registar_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 l = new Form1();
            l.Show();
        }
    }
}

