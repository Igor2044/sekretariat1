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
using System.Runtime.Remoting.Messaging;

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
        public class randNum
        {
            public int x = new Random().Next(0, 6);
        }

        private void randPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            randNum objrandNum = new randNum();
            randPicBox.Image = listImg[objrandNum.x];            
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            randNum objrandNum = new randNum();
            string name = "admin";
            string password = "Qwerty1@34";
            string passwordImg = listImgPsw[objrandNum.x];
            if(NameBox.Text == name && passwordBox.Text == password/*&& imgPassBox.Text == passwordImg*/)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }
    }
}
