using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._9._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string[] name = new string[10];
            name[0] = "Arafat";
            name[1] = "Ananna";
            name[2] = "Rezwana";
            name[3] = "Srobona";

            int[] age = new int[] { 12,13,14,15};

            string message = "";
            for(int i=0;i<4; i++)

            {
                message += "Name : " + name[i] + "  Age : " + age[i] + "\n";
            }

            MessageBox.Show(message);
        }
    }
}
