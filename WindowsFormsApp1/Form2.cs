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
            foreach (string line in File.ReadLines(path))
            {
                lstudents.Add(line);
            }
        }

        List<string> lstudents = new List<string>();        
        string path = @"C:\Users\TEMP\Desktop\uczen.txt";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && txtKlass.Text != "") {
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string klass = txtKlass.Text;
                string student = name + " " + surname + " " + klass;
                lstudents.Add(student);
                File.WriteAllLines(path, lstudents);
            }
        }

        

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<string> lwords = File.ReadAllText(path).Split(' ','\n').ToList();
            showResult.Items.Clear();
            foreach (string line in File.ReadLines(path))
            {
                showResult.Items.Add(line);                
            }
            if (chooseParameter.SelectedIndex == 0)
            {
                if (chooseOption.SelectedIndex == 0)
                {
                    showResult.Items.Clear();
                    for(int i = 0; i < lwords.Count; i+=3)
                    {
                        if (string.Equals(lwords[i],(txtFind.Text)))
                        {
                            showResult.Items.Add(lwords[i] + " " + lwords[i + 1] + " " + lwords[i + 2]);
                        }
                    }
                }
                else if (chooseOption.SelectedIndex == 1)
                {
                    showResult.Items.Clear();
                    for (int i = 0; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].Contains(txtFind.Text))
                        {
                            showResult.Items.Add(lwords[i] + " " + lwords[i + 1] + " " + lwords[i + 2]);
                        }
                    }
                }
                else if (chooseOption.SelectedIndex == 2)
                {
                    showResult.Items.Clear();
                    for (int i = 0; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].StartsWith(txtFind.Text))
                        {
                            showResult.Items.Add(lwords[i] + " " + lwords[i + 1] + " " + lwords[i + 2]);
                        }
                    }
                }
            }
            else if (chooseParameter.SelectedIndex == 1)
            {
                if (chooseOption.SelectedIndex == 0)
                {
                    showResult.Items.Clear();
                    for (int i = 1; i < lwords.Count; i += 3)
                    {
                        if (string.Equals(lwords[i], (txtFind.Text)))
                        {
                            showResult.Items.Add(lwords[i - 1] + " " + lwords[i] + " " + lwords[i + 1]);
                        }
                    }
                }
                else if (chooseOption.SelectedIndex == 1)
                {
                    showResult.Items.Clear();
                    for (int i = 1; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].Contains(txtFind.Text))
                        {
                            showResult.Items.Add(lwords[i - 1] + " " + lwords[i] + " " + lwords[i + 1]);
                        }
                    }
                }
                else if (chooseOption.SelectedIndex == 2)
                {
                    showResult.Items.Clear();
                    for (int i = 1; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].StartsWith(txtFind.Text))
                        {
                            showResult.Items.Add(lwords[i - 1] + " " + lwords[i] + " " + lwords[i + 1]);
                        }
                    }
                }
            }
            else if (chooseParameter.SelectedIndex == 2)
            {
                if (chooseOption.SelectedIndex == 0)
                {
                    showResult.Items.Clear();
                    for (int i = 2; i < lwords.Count; i += 3)
                    {
                        if (string.Equals(lwords[i], (txtFind.Text)))
                        {
                            showResult.Items.Add(lwords[i - 2] + " " + lwords[i - 1] + " " + lwords[i]);
                        }
                    }
                }
                else if (chooseOption.SelectedIndex == 1)
                {
                    showResult.Items.Clear();
                    for (int i = 2; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].Contains(txtFind.Text))
                        {
                            showResult.Items.Add(lwords[i - 2] + " " + lwords[i - 1] + " " + lwords[i]);
                        }
                    }
                }
                else if (chooseOption.SelectedIndex == 2)
                {
                    showResult.Items.Clear();
                    for (int i = 2; i < lwords.Count; i += 3)
                    {
                        if (lwords[i].StartsWith(txtFind.Text))
                        {
                            showResult.Items.Add(lwords[i - 2] + " " + lwords[i - 1] + " " + lwords[i]);
                        }
                    }
                }
            }            
        }
    }
}
