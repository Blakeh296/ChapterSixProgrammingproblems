using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailPriceCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Text box one Retail price
            double wholeSale;
            // variable we will use to convert
            double percent;
            // Output variable 
            double Retail;

            try
            {
                // Variable equal to the text box
                wholeSale = double.Parse(tbWholeSalePrice.Text);
                percent = double.Parse(tbMarkupPercent.Text);
                // Variable is pulled from my class
                Retail = WholeSaleToRetail.CalculateRetail(wholeSale, percent);
                // Output to list box
                lbRetailPrice.Items.Add(Retail.ToString("c"));
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbRetailPrice.Items.Clear();
            tbMarkupPercent.Text = " ";
            tbWholeSalePrice.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
