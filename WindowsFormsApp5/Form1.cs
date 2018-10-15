using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSphere_Click(object sender, EventArgs e)
        {
            try
            {

                double R = Convert.ToDouble(txtRadius.Text);
                double V = 4.0 / 3.0 * Math.PI * R * R * R;
                label3.Text = "Volume = " + V;
                double A = Math.PI * R * R;
                label2.Text = "Area = " + A;

            }
            catch
            {
                MessageBox.Show("Type a number in the radius box");
            }
        }
    }
}
