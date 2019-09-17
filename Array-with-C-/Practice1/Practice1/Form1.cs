using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int[] number = new int[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string message = " ";

            for(int i=0;i<10;i++)
            {
                message += " " + number[i];
            }
            MessageBox.Show("Element in array are:" + message);
        }
    }
}
