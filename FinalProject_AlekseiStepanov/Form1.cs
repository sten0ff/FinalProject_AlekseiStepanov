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

namespace FinalProject_AlekseiStepanov
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> country = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog1.FileName);
                    string line;
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        string[] parts = line.Split('-');
                        country[parts[0].Trim()] = int.Parse(parts[1].Trim());
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Country coun = new Country(name,0);
            label2.Text = coun.country(country);
            Age a = new Age(name,coun.Year);
            if (label2.Text == "Not found!")
            {
                ;
            }
            else
            {
                label2.Text += "\n" + a.age_of_country(coun.Year);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
