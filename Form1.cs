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
    public partial class Form1 : Form
    {
        public static string username { get; set; }
        List<string> passwords = new List<string>();

        string path = "users.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            username = tbusername.Text;
            string password = textBox2.Text;

            using (StreamReader ws = new StreamReader(path))
            {
                while (!ws.EndOfStream)
                {
                    
                    string fileUsername = ws.ReadLine();
                    string filePassword = ws.ReadLine();

                    Registar.usernames.Add(fileUsername);
                    passwords.Add(filePassword);
                }
            }

            for (int i = 0; i < Registar.usernames.Count; i++)
            {
                if (Registar.usernames[i] == username && passwords[i] == password)
                {
                    this.Hide();
                    Profil n = new Profil();
                    n.Show();
                }
                


            }

        }



        private void btnRegistar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registar x = new Registar();
            x.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}