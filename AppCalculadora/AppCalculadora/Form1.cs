using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {
        // Variables globales
        double valorActual = 0;
        string operacion = "";
        bool operacionPresionada = false;

        // Cadena de conexión
        string cadenaConexion = @"Server=.\SQLEXPRESS;Database=CalculadoraDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();

            // Asignar eventos a todos los botones numéricos y operadores
            AsignarEventos();
        }

        //Asignando eventos comunes para números y operadores
        private void AsignarEventos()
        {
            // Números
            btnN0.Click += btnNumero_Click;
            btnN1.Click += btnNumero_Click;
            btnN2.Click += btnNumero_Click;
            btnN3.Click += btnNumero_Click;
            btnN4.Click += btnNumero_Click;
            btnN5.Click += btnNumero_Click;
            btnN6.Click += btnNumero_Click;
            btnN7.Click += btnNumero_Click;
            btnN8.Click += btnNumero_Click;
            btnN9.Click += btnNumero_Click;
            btnDecimal.Click += btnNumero_Click;

            // Operadores
            btnSumar.Click += btnOperador_Click;
            btnRestar.Click += btnOperador_Click;
            btnMultiplicar.Click += btnOperador_Click;
            btnDividir.Click += btnOperador_Click;
        }

        //Números y punto
        private void btnNumero_Click(object sender, EventArgs e)
        {
            if (txtTablero.Text == "0" || operacionPresionada)
                txtTablero.Clear();

            operacionPresionada = false;
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!txtTablero.Text.Contains("."))
                    txtTablero.Text += btn.Text;
            }
            else
                txtTablero.Text += btn.Text;
        }

        //Operaciones básicas
        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacion = btn.Text;
            valorActual = double.Parse(txtTablero.Text);
            operacionPresionada = true;
        }

        //Botón igual (=)
        private void btnIgual_Click(object sender, EventArgs e)
        {
            double segundoValor = double.Parse(txtTablero.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+": resultado = valorActual + segundoValor; break;
                case "-": resultado = valorActual - segundoValor; break;
                case "*": resultado = valorActual * segundoValor; break;
                case "/":
                    if (segundoValor == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        return;
                    }
                    resultado = valorActual / segundoValor;
                    break;
                default:
                    resultado = segundoValor;
                    break;
            }

            txtTablero.Text = resultado.ToString();
            GuardarOperacion(valorActual, operacion, segundoValor, resultado);
            valorActual = resultado;
            operacion = "";
        }

        //CE: limpia entrada actual
        private void btnLimpiarEntrada_Click(object sender, EventArgs e)
        {
            txtTablero.Text = "0";
        }

        //C: limpia todo
        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            txtTablero.Text = "0";
            valorActual = 0;
            operacion = "";
        }

        //Cambiar signo (+/-)
        private void btnSigno_Click(object sender, EventArgs e)
        {
            if (txtTablero.Text.StartsWith("-"))
                txtTablero.Text = txtTablero.Text.Substring(1);
            else if (txtTablero.Text != "0")
                txtTablero.Text = "-" + txtTablero.Text;
        }

        //Cuadrado
        private void btnExponente_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(txtTablero.Text);
            double resultado = Math.Pow(numero, 2);
            txtTablero.Text = resultado.ToString();
            GuardarOperacion(numero, "x²", numero, resultado);
        }

        //Raíz cuadrada
        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(txtTablero.Text);
            if (numero < 0)
            {
                MessageBox.Show("No se puede sacar raíz de un número negativo");
                return;
            }

            double resultado = Math.Sqrt(numero);
            txtTablero.Text = resultado.ToString();
            GuardarOperacion(numero, "√x", numero, resultado);
        }

        //Botones especiales
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtTablero.Text = Math.PI.ToString();
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            txtTablero.Text = Math.E.ToString();
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(txtTablero.Text);
            double resultado = numero / 100;
            txtTablero.Text = resultado.ToString();
        }

        private void btnEliminarCaracter_Click(object sender, EventArgs e)
        {
            if (txtTablero.Text.Length > 0)
                txtTablero.Text = txtTablero.Text.Substring(0, txtTablero.Text.Length - 1);

            if (txtTablero.Text == "")
                txtTablero.Text = "0";
        }

        //Mostrar historial guardado en BD
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Historial ORDER BY Fecha DESC", conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                string historial = "";
                while (reader.Read())
                {
                    historial += $"{reader["OperacionTexto"]}\n";
                }

                reader.Close();

                MessageBox.Show(
                    historial == "" ? "No hay operaciones registradas." : historial,
                    "Historial de cálculos"
                );
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        //Guardar operación en la base de datos
        private void GuardarOperacion(double a, string op, double b, double r)
        {
            string operacionTexto = $"{a} {op} {b} = {r}";
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Historial (OperacionTexto, Fecha) VALUES (@OperacionTexto, GETDATE())",
                    conexion
                );
                cmd.Parameters.AddWithValue("@OperacionTexto", operacionTexto);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }
    }
}
