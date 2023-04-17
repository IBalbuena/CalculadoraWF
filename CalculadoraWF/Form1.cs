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

        // Al pulsar cualquier bot�n num�rico se imprime en pantalla.
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

        // Bot�n que convierte en negativo o positivo un numero.
        private void buttonPositivoNegativo_Click(object sender, EventArgs e)
        {
            if (pantalla.Text != "0" && !string.IsNullOrEmpty(pantalla.Text))
            {
                double numeroSigno = double.Parse(pantalla.Text);
                numeroSigno = (-1) * numeroSigno;
                pantalla.Text = numeroSigno.ToString();
            }

        }

        // Bot�n para colocar un decimal, pero si la pantalla est� vac�a o ya tiene puesto un "." decimal, no lo vuelve a poner.
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Contains(".") && !string.IsNullOrEmpty(pantalla.Text))
            {
                pantalla.Text = pantalla.Text + ".";

            }

        }

        // Funci�n auxiliar para convertir el valor de la pantalla del n�mero 1 a n�mero decimal.
        // Si se pulsa cualquier bot�n no num�rico imprimir� un 0, si no, convertir� el n�mero 1 en n�mero decimal.
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

        // Bot�n que limpia ambos n�meros.
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            pantalla.Text = "";


        }

        // Bot�n que limpia el �ltimo n�mero.
        private void buttonLimpiarEntrada_Click(object sender, EventArgs e)
        {
            pantalla.Clear();


        }

        // Bot�n igual que realiza las distintas operaciones.
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            // Si se pulsa el bot�n igual y est� vac�a la pantalla pondr� un 0, si no, convertir� el n�mero 2 en n�mero decimal.
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