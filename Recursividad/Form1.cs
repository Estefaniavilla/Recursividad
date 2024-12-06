namespace Recursividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Factorial(int n)
        {
            if (n == 0 || n == 1) 
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int numero = int.Parse(txtNumero.Text);

                if (numero < 0)
                {
                    MessageBox.Show("Por favor, ingrese un número no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    int resultado = Factorial(numero);

                    
                    lblResultado.Text = $"El factorial de {numero} es: {resultado}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

        
    

