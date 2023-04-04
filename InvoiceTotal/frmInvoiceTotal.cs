using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        }

        //private void btnCalculate_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        decimal subtotal = Decimal.Parse(txtSubtotal.Text);
        //        decimal discountPercent = 0.1m; // You can change this value as needed or fetch it from another source.
        //        decimal discountAmount = subtotal * discountPercent;
        //        decimal total = subtotal - discountAmount;

        //        txtDiscountPercent.Text = (discountPercent * 100).ToString("0.00") + "%";
        //        txtDiscountAmount.Text = discountAmount.ToString("c");
        //        txtTotal.Text = total.ToString("c");
        //    }
        //    catch (FormatException)
        //    {
        //        MessageBox.Show("Please enter a valid number for the subtotal.", "Input Error");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An unexpected error has occurred: " + ex.Message, "Error");
        //    }
        //}

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                decimal discountPercent = 0.1m; // You can change this value as needed or fetch it from another source.
                decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
                decimal total = Math.Round(subtotal - discountAmount, 2);

                txtDiscountPercent.Text = (discountPercent * 100).ToString("0.00") + "%";
                txtDiscountAmount.Text = discountAmount.ToString(); // Removed formatting code
                txtTotal.Text = total.ToString(); // Removed formatting code
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for the subtotal.", "Input Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error has occurred: " + ex.Message, "Error");
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
