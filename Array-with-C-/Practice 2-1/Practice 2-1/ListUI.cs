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
    public partial class ListUI : Form
    {
        .List<string> names = new List<string> { };
        public ListUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           names.Add(nameTextBox.Text);

            Show();

            MessageBox.Show("Add");


        }
        private void Show()
        {

            string message = "";
            foreach (string name in names)
            {
                message += "Name : " + name + "\n";
            }
            MessageBox.Show(message);

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
