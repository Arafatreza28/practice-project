using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2_1
{
    public partial class Practice_2 : Form
    {
        int size = 0;
        int[] num = new int[100];
        string m = "";
        public Practice_2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addsizeButton_Click(object sender, EventArgs e)
        {
            string s = sizeTextBox.Text;
            size = Convert.ToInt32(s);
        }

        private void addelementButton_Click(object sender, EventArgs e)
        {
            
            string[] number = new string[100];
            number[size] = elementTextBox.Text;
           
            num[size] = Convert.ToInt32(number[size]);
            
           
                m += "num : " + num[size] + "\n";
            
            size--;

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(m);
        }
    }
}
