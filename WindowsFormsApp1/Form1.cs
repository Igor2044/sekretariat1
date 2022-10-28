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
using System.Web;

namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        List<Bitmap> listImg = new List<Bitmap>()
        {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4,
            Properties.Resources._5,
            Properties.Resources._6,
            Properties.Resources._7
        };

        List<string> listImgPsw = new List<string>()
        {
            "mxyxw","b5nmm","74853","cg5dd","x3deb","befdb","c7gb3"
        };

        private void randPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random rnd = new Random();
            int imgN = rnd.Next(0, 6);
            randPicBox.Image = listImg[imgN];
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string name = "admin";
            string password = "Qwerty1@34";
            string imgPassword = listImgPsw[];
        }
    }
}
