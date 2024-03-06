using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbNhanVat.SelectedItem.ToString() + " da ha guc ban");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbNhanVat.Items.Add("Kennen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbNhanVat.SelectedIndex > -1)
            {
                lbNhanVat.Items.Remove(lbNhanVat.SelectedItem);
            }
        }

        private void btnShowCBB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbbVungDat.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbbVungDat.Items.Add("Icathia");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbbVungDat.SelectedIndex > -1)
            {
                cbbVungDat.Items.Remove(cbbVungDat.SelectedItem);
            }
        }
    }
}
