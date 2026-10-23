namespace HelloWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = $"IMC Calculado {imc:F2}";

            if (imc < 18.5)
                lblInterpretacao.Text = "Abaixo do peso";

            else if (imc >= 18.5 && imc < 25)
                lblInterpretacao.Text = "Peso normal";

            else if (imc >= 25 && imc < 30)
                lblInterpretacao.Text = "Sobrepeso";

            else if (imc >= 30 && imc < 35)
                lblInterpretacao.Text = "Obesidade grau I";

            else if (imc >= 35 && imc < 40)
                lblInterpretacao.Text = "Obesidade grau II";

            else if (imc >= 40)
                lblInterpretacao.Text = "Obesidade grau III ou mais"; 
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
