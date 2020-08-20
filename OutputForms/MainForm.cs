using PracticeAkr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OutputForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
                      

        }

        Task1 task1 = new Task1();

        private void fillButton_Click(object sender, EventArgs e)
        {
            int k = (int)numericUpDown1.Value;
            double[] myArray = new double[k];
            myArray = task1.CreateArray(myArray.Length);

            for (int i = 0; i < myArray.Length; i++)
            {
                textBox1.Text += $"{myArray[i]:f3}\t";
            }

            double max = task1.Max(myArray);
            maxTextBox.Text = $"{max:f3}";           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
