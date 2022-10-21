using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using System.Threading;

namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();

        }

        private void randPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Random rnd = new Random();
            int randNum = rnd.Next(1, 7);

            if (randNum == 1)
            {
                randPicBox.Image = Resources._1;
            }
            if (randNum == 2)
            {
                randPicBox.Image = Resources._2;
            }
            if (randNum == 3)
            {
                randPicBox.Image = Resources._3;
            }
            if (randNum == 4)
            {
                randPicBox.Image = Resources._4;
            }
            if (randNum == 5)
            {
                randPicBox.Image = Resources._5;
            }
            if (randNum == 6)
            {
                randPicBox.Image = Resources._6;
            }
            if (randNum == 7)
            {
                randPicBox.Image = Resources._7;
            }
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string haslo = "Qwerty1@34";
            string picHaslo;
            if (randPicBox.Image == Resources._1)
            {
                picHaslo = "mxyxw";
                if (passwordBox.Text == picHaslo)
                {
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    Error.ForeColor = Color.Red;
                    Error.Text = "Wprowadzono błędną nazwę użytkownika lub/i hasło";
                }
            }
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form2());
        }
    }
}
