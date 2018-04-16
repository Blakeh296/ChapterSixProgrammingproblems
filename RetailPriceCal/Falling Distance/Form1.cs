using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falling_Distance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double distance;
            double t;

            t = double.Parse(tbFallTime.Text);

            distance = FallingDistance.CalFallingDistance(t);

            lblOutput.Text = distance.ToString("#.##");
        }
    }
}
