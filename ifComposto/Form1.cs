namespace ifComposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvestimento_Click(object sender, EventArgs e)
        {
            double doacao, investir;
            doacao = double.Parse(txtDoacao.Text);

            if(doacao <= 1000)
            {
                investir = doacao * 0.05;
            }
            else
            {
                investir = doacao * 0.15;
            }
            MessageBox.Show("O valor do investimento deve ser de R$" +
                investir.ToString("0.00"), "ONG", MessageBoxButtons.OK,MessageBoxIcon.Information);

        
        }
    }
}