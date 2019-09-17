using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice2
{
    public partial class Form1 : Form
    {
        string n = " ";



        public Form1()
        {
            InitializeComponent();
        }

        private void sizeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The values store into the array are: " + n);

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            string num = " ";
            
            num = numberTextBox.Text;
            int[] number = new int[3];
         
            for(int i=0;i<1;i++)
            {
                number[i] = Convert.ToInt32(num);
                n += " " + number[i];
            }
            for (int i = 0; i < 0; i++)
            {
                number[i] = Convert.ToInt32(num);
                n += " " + number[i];
            }
        }

       
    }
}
