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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string path = @"C:\Users\student\Desktop\uczen.txt";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && txtKlass.Text != "") {
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string klass = txtKlass.Text;
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(name, " ", surname, " ", klass);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                var x = File.ReadAllLines(path).Count();
                for(int i = 0; i < x; i++)
                {
                    showResult.Items.Add(File.ReadAllLines(path + "/" + i));
                }
            }
        }
    }
}
