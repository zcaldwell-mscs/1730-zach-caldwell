namespace Ex1C
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                    4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");

            txtHamburgersSubtotal.Text = (
                    5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");

            txtPretaxTotal.Text = (
                Convert.ToDecimal(txtHotDogsSubtotal.Text)
                + Convert.ToDecimal(txtHamburgersSubtotal.Text)
                ).ToString("0.00");

            txtTax.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text)
                * 0.06875m
                ).ToString("0.00");

            txtTotal.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text)
                + Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");

            btnClear.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();

            //hi

        }
    }
}