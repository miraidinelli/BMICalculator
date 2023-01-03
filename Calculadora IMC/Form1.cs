namespace Calculadora_IMC
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

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(txbAltura.Text);
            double peso = Convert.ToDouble(txbPeso.Text);
            txbIMC.Text = calc_imc(peso, altura).ToString();
            double resultado = calc_imc(peso, altura);

            if(resultado <= 24.9 && resultado >=18.9)
            {
                MessageBox.Show("Niveis normais");
            }
            else if(resultado >= 25.0 && resultado < 29.9 )
            {
                MessageBox.Show("Sobrepeso");
            }
            else if(resultado >= 30)
            {
                MessageBox.Show("Obesidade");
            }

        }
        double calc_imc(double peso, double altura)
        {
            double resultado = peso / (altura * altura);
            return resultado;
        }
    }
}