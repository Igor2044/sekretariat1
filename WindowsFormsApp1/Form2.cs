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
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        List<string> students = new List<string>();
        string path = @"C:\Users\student\Desktop\uczen.txt";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && txtKlass.Text != "") {
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string klass = txtKlass.Text;
                string student = name + " " + surname + " " + klass;
                students.Add(student);
                File.Create(path).Close();
                File.WriteAllLines(path, students);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            showResult.Items.Clear();
            if (students.Count > 0)
            {
                if (chooseParameter.SelectedIndex == 0)
                {
                    if (chooseOption.SelectedIndex == 0)
                    {

                    }
                    else if (chooseOption.SelectedIndex == 1)
                    {

                    }
                    else if (chooseOption.SelectedIndex == 2)
                    {

                    }
                }
                else if (chooseParameter.SelectedIndex == 1)
                {
                    if (chooseOption.SelectedIndex == 0)
                    {

                    }
                    else if (chooseOption.SelectedIndex == 1)
                    {

                    }
                    else if (chooseOption.SelectedIndex == 2)
                    {

                    }
                }
                else if (chooseParameter.SelectedIndex == 2)
                {
                    if (chooseOption.SelectedIndex == 0)
                    {

                    }
                    else if (chooseOption.SelectedIndex == 1)
                    {

                    }
                    else if (chooseOption.SelectedIndex == 2)
                    {

                    }
                }
            }
        }
    }
}
