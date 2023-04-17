namespace CalculadoraWF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // Variables.
        double numero1;
        double numero2;
        string operacion;

        // Al pulsar cualquier botón numérico se imprime en pantalla.
        private void button1_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0" && pantalla.Text != null)
            {
                pantalla.Text = "1";
            }
            else
            {
                pantalla.Text = pantalla.Text + "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0" && pantalla.Text != null)
            {
                pantalla.Text = "2";
            }
            else
            {
                pantalla.Text = pantalla.Text + "2";
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0" && pantalla.Text != null)
            {
                pantalla.Text = "3";
            }
            else
            {
                pantalla.Text = pantalla.Text + "3";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0" && pantalla.Text != null)
            {
                pantalla.Text = "4";
            }
            else
            {
                pantalla.Text = pantalla.Text + "4";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0" && pantalla.Text != null)
            {
                pantalla.Text = "5";
            }
            else
            {
                pantalla.Text = pantalla.Text + "5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0" && pantalla.Text != null)
            {
                pantalla.Text = "6";
            }
            else
            {
                pantalla.Text = pantalla.Text + "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0" && pantalla.Text != null)
            {
                pantalla.Text = "7";
            }
            else
            {
                pantalla.Text = pantalla.Text + "7";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0" && pantalla.Text != null)
            {
                pantalla.Text = "8";
            }
            else
            {
                pantalla.Text = pantalla.Text + "8";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0" && pantalla.Text != null)
            {
                pantalla.Text = "9";
            }
            else
            {
                pantalla.Text = pantalla.Text + "9";
            }

        }

        private void button0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";

        }

        // Botón que convierte en negativo o positivo un numero.
        private void buttonPositivoNegativo_Click(object sender, EventArgs e)
        {
            if (pantalla.Text != "0" && !string.IsNullOrEmpty(pantalla.Text))
            {
                double numeroSigno = double.Parse(pantalla.Text);
                numeroSigno = (-1) * numeroSigno;
                pantalla.Text = numeroSigno.ToString();
            }

        }

        // Botón para colocar un decimal, pero si la pantalla está vacía o ya tiene puesto un "." decimal, no lo vuelve a poner.
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Contains(".") && !string.IsNullOrEmpty(pantalla.Text))
            {
                pantalla.Text = pantalla.Text + ".";

            }

        }

        // Función auxiliar para convertir el valor de la pantalla del número 1 a número decimal.
        // Si se pulsa cualquier botón no numérico imprimirá un 0, si no, convertirá el número 1 en número decimal.
        public void convierteADouble()
        {
            if (!string.IsNullOrEmpty(pantalla.Text))
            {
                numero1 = Convert.ToDouble(pantalla.Text);
                pantalla.Clear();
            }
            else
            {
                pantalla.Text = "0";
            }
            
        }

        // Operaciones sumar, restar, multiplicar, dividir y elevar.
        private void buttonSumar_Click(object sender, EventArgs e)
        {
            operacion = "suma";
            convierteADouble();


        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            operacion = "resta";
            convierteADouble();

        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operacion = "multiplica";
            convierteADouble();


        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operacion = "divide";
            convierteADouble();


        }

        private void buttonElevar_Click(object sender, EventArgs e)
        {
            operacion = "eleva";
            convierteADouble();


        }

        // Botón que limpia ambos números.
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            pantalla.Text = "";


        }

        // Botón que limpia el último número.
        private void buttonLimpiarEntrada_Click(object sender, EventArgs e)
        {
            pantalla.Clear();


        }

        // Botón igual que realiza las distintas operaciones.
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            // Si se pulsa el botón igual y está vacía la pantalla pondrá un 0, si no, convertirá el número 2 en número decimal.
            if(!string.IsNullOrEmpty(pantalla.Text))
            {
                numero2 = Convert.ToDouble(pantalla.Text);
            } else {
                pantalla.Text = "0";
            }
            
            
            switch (operacion)
            {
                case "suma":
                    pantalla.Text = Convert.ToString(numero1 + numero2);
                    break;
                case "resta":
                    pantalla.Text = Convert.ToString(numero1 - numero2);
                    break;
                case "multiplica":
                    pantalla.Text = Convert.ToString(numero1 * numero2);
                    break;
                case "divide":
                    pantalla.Text = Convert.ToString(numero1 / numero2);
                    break;
                case "eleva":
                    pantalla.Text = Convert.ToString(Math.Pow(numero1, numero2));
                    break;
            }

        }
    }
}