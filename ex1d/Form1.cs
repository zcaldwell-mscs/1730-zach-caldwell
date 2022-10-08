namespace ex1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPolishAmount.Text = "0.00";
            txtPolishRate.Text = "0.20044144";

            txtSouthKoreanAmount.Text = "0.00";
            txtSouthKoreanRate.Text = "0.00070804765";

            txtRussianAmount.Text = "0.00";
            txtRussianRate.Text = "0.016062508";

            txtJapaneseAmount.Text = "0.00";
            txtJapaneseRate.Text = "0.0068791077";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void polishTextChanged(object sender, EventArgs e)
        {
            txtUSDPolish.Text = (
                Convert.ToDecimal(txtPolishAmount.Text)
                * Convert.ToDecimal(txtPolishRate.Text)
                ).ToString("0.00");
        }

        private void southkoreanTextChanged(object sender, EventArgs e)
        {
            txtUSDSouthKorean.Text = (
                Convert.ToDecimal(txtSouthKoreanAmount.Text)
                * Convert.ToDecimal(txtSouthKoreanRate.Text)
                ).ToString("0.00");
        }

        private void russianTextChanged(object sender, EventArgs e)
        {
            txtUSDRussian.Text = (
                Convert.ToDecimal(txtRussianAmount.Text)
                * Convert.ToDecimal(txtRussianRate.Text)
                ).ToString("0.00");
        }

        private void japaneseTextChanged(object sender, EventArgs e)
        {
            txtUSDJapanese.Text = (
                Convert.ToDecimal(txtJapaneseAmount.Text)
                * Convert.ToDecimal(txtJapaneseRate.Text)
                ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtUSDTotal.Text = (
                Convert.ToDecimal(txtUSDPolish.Text)
                + Convert.ToDecimal(txtUSDSouthKorean.Text)
                + Convert.ToDecimal(txtUSDRussian.Text)
                + Convert.ToDecimal(txtUSDJapanese.Text)
                ).ToString("0.00");
        }
    }
}