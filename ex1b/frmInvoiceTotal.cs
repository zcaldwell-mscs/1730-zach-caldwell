namespace ex1b
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtDiscountAmount.Text =
                (Convert.ToDecimal(txtSubtotal.Text) 
                * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");

            txtTotal.Text =
                (Convert.ToDecimal(txtSubtotal.Text)
                - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");
        }
    }
}