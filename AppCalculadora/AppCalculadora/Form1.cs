using System;
using System.Collections.Generic;
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
            AsignarEventos();            // Asignar eventos a todos los botones numéricos y operadores
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

            // Paréntesis
            btnAbrirParentesis.Click += btnParentesis_Click;
            btnCerrarParentesis.Click += btnParentesis_Click;
        }

        private void btnParentesis_Click(object sender, EventArgs e)
        {
            if (txtTablero.Text == "0")
                txtTablero.Clear();

            Button btn = (Button)sender;    //Identifica el botón presionado 
            txtTablero.Text += btn.Text;
        }


        //Números y punto
        private void btnNumero_Click(object sender, EventArgs e)
        {
            if (txtTablero.Text == "0")
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

            if (txtTablero.Text.EndsWith("+") || txtTablero.Text.EndsWith("-") ||   //vita poner dos operadores seguidos
                txtTablero.Text.EndsWith("*") || txtTablero.Text.EndsWith("/"))     // El metodo EndsWith verifica si el texto en el textbox termina en operador

                txtTablero.Text += " " + btn.Text + " ";
        }

        //Soluciona expresión simple.
        private double ResolverExpresionSimple(string expresion)
        {
            string[] partes = expresion.Split(' ');         //El metodo Split divide la cadena en partes usando el espacio como separador

            if (partes.Length < 3)                          //Verifica si hay 3 o más partes (número operador número) y si no, convierte el único número (si es válido) y lo retorna.
            {
                double unico;
                if (double.TryParse(expresion, out unico))
                    return unico;
                return 0;
            }

            List<string> lista = new List<string>(partes);  //Convierte el arreglo(partes) en una lista para facilitar la manipulación

            for (int i = 0; i < lista.Count; i++) //1ro. Multiplicación y división
            {
                if (lista[i] == "*" || lista[i] == "/")
                {
                    double a = double.Parse(lista[i - 1]);
                    double b = double.Parse(lista[i + 1]);
                    double resultado = 0;

                    if (lista[i] == "*")
                        resultado = a * b;
                    else
                    {
                        if (b == 0)
                        {
                            MessageBox.Show("No se puede dividir entre cero");
                            return 0;
                        }
                        resultado = a / b;
                    }

                    lista[i - 1] = resultado.ToString();
                    lista.RemoveAt(i);
                    lista.RemoveAt(i);
                    i--;
                }
            }


            for (int i = 0; i < lista.Count; i++) //2do. Suma y resta
            {
                if (lista[i] == "+" || lista[i] == "-")
                {
                    double a = double.Parse(lista[i - 1]);
                    double b = double.Parse(lista[i + 1]);
                    double resultado = (lista[i] == "+") ? a + b : a - b; // Verifica(?), si el valor del indice actual es "+", si, si Suma si no(:) Resta.

                    lista[i - 1] = resultado.ToString();
                    lista.RemoveAt(i);
                    lista.RemoveAt(i);
                    i--;
                }
            }

            return double.Parse(lista[0]); // Resultado final
        }

        //Botón igual (=)
        private void btnIgual_Click(object sender, EventArgs e)
        {
            string expresionOriginal = txtTablero.Text.Trim();      //Guardar la expresión original para el historial
            string expresion = expresionOriginal;

            if (string.IsNullOrEmpty(expresion))
            {
                MessageBox.Show("Expresión vacía");
                return;
            }

            while (expresion.Contains("("))                         //Resuelve todos los paréntesis (desde el más interno al externo) mientras haya paréntesis abiertos
            {
                int fin = expresion.IndexOf(")");
                if (fin == -1)
                {
                    MessageBox.Show("Falta cerrar un paréntesis");
                    return;
                }

                int inicio = expresion.LastIndexOf("(", fin);
                if (inicio == -1)
                {
                    MessageBox.Show("Falta abrir un paréntesis");
                    return;
                }


                string dentro = expresion.Substring(inicio + 1, fin - inicio - 1);      // Extraer la parte interna entre paréntesis


                double resultadoDentro = ResolverExpresionSimple(dentro);               // Resolver solo lo de adentro


                expresion = expresion.Substring(0, inicio) + resultadoDentro.ToString() + expresion.Substring(fin + 1); // Reemplazar ( ... ) por el resultado
            }


            double final = ResolverExpresionSimple(expresion);


            txtTablero.Text = final.ToString();                                         // Mostra el resultado en el tablero(TextBox)

            string resultadoGuardar = (final % 1 == 0) ? final.ToString("0") : final.ToString("F4");
            double resultadoFinal = double.Parse(resultadoGuardar);

            guardarOperacion(expresionOriginal, resultadoFinal);                        //Guardar la operación completa en la BD
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
                txtTablero.Text = txtTablero.Text.Substring(1);     //elimina el primer caracter
            else if (txtTablero.Text != "0")                        //Si no es cero, agrega el signo negativo
                txtTablero.Text = "-" + txtTablero.Text;
        }

        // Cuadrado (x²)
        private void btnExponente_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtTablero.Text, out double numero))       // Verifica si la entrada es un número válido
            {
                MessageBox.Show("Entrada inválida");
                return;
            }

            double resultado = Math.Pow(numero, 2);
            txtTablero.Text = resultado.ToString();

            guardarOperacion($"{numero}²", resultado);
        }

        // Raíz cuadrada (√x)
        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtTablero.Text, out double numero))
            {
                MessageBox.Show("Entrada inválida");
                return;
            }

            if (numero < 0)
            {
                MessageBox.Show("No se puede sacar raíz de un número negativo");
                return;
            }

            double resultado = Math.Sqrt(numero);
            txtTablero.Text = resultado.ToString();

            guardarOperacion($"√{numero}", resultado);
        }

        //Botones especiales
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtTablero.Text = Math.PI.ToString("F4");
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
                txtTablero.Text = txtTablero.Text.Substring(0, txtTablero.Text.Length - 1); // El método Substring elimina el último carácter del tablero, recortando desde el inicio hasta uno antes del final


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
                if (conexion != null)   //Verifica si hay una conexión abierta antes de cerrarla
                    conexion.Close();   //Cierra la conexión
            }
        }

        //Guardar operación en la base de datos
        private void guardarOperacion(string expresion, double resultado)
        {
            string operacionTexto = expresion + " = " + resultado.ToString();
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
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

    }
}
