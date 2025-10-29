namespace AppCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTablero = new System.Windows.Forms.TextBox();
            this.btnEliminarCaracter = new System.Windows.Forms.Button();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.btnLimpiarEntrada = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnExponente = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnEuler = new System.Windows.Forms.Button();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.btnAbrirParentesis = new System.Windows.Forms.Button();
            this.btnCerrarParentesis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTablero
            // 
            this.txtTablero.Location = new System.Drawing.Point(25, 34);
            this.txtTablero.Multiline = true;
            this.txtTablero.Name = "txtTablero";
            this.txtTablero.Size = new System.Drawing.Size(362, 66);
            this.txtTablero.TabIndex = 0;
            this.txtTablero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEliminarCaracter
            // 
            this.btnEliminarCaracter.Location = new System.Drawing.Point(301, 121);
            this.btnEliminarCaracter.Name = "btnEliminarCaracter";
            this.btnEliminarCaracter.Size = new System.Drawing.Size(86, 36);
            this.btnEliminarCaracter.TabIndex = 1;
            this.btnEliminarCaracter.Text = "Eliminar";
            this.btnEliminarCaracter.UseVisualStyleBackColor = true;
            this.btnEliminarCaracter.Click += new System.EventHandler(this.btnEliminarCaracter_Click);
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.Location = new System.Drawing.Point(209, 121);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(86, 36);
            this.btnLimpiarTodo.TabIndex = 2;
            this.btnLimpiarTodo.Text = "C";
            this.btnLimpiarTodo.UseVisualStyleBackColor = true;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // btnLimpiarEntrada
            // 
            this.btnLimpiarEntrada.Location = new System.Drawing.Point(117, 121);
            this.btnLimpiarEntrada.Name = "btnLimpiarEntrada";
            this.btnLimpiarEntrada.Size = new System.Drawing.Size(86, 36);
            this.btnLimpiarEntrada.TabIndex = 3;
            this.btnLimpiarEntrada.Text = "CE";
            this.btnLimpiarEntrada.UseVisualStyleBackColor = true;
            this.btnLimpiarEntrada.Click += new System.EventHandler(this.btnLimpiarEntrada_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(25, 121);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(86, 120);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "Mostrar Calculos";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnExponente
            // 
            this.btnExponente.Location = new System.Drawing.Point(117, 163);
            this.btnExponente.Name = "btnExponente";
            this.btnExponente.Size = new System.Drawing.Size(86, 36);
            this.btnExponente.TabIndex = 5;
            this.btnExponente.Text = "x²";
            this.btnExponente.UseVisualStyleBackColor = true;
            this.btnExponente.Click += new System.EventHandler(this.btnExponente_Click);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.Location = new System.Drawing.Point(209, 163);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(86, 36);
            this.btnRaizCuadrada.TabIndex = 6;
            this.btnRaizCuadrada.Text = "√x";
            this.btnRaizCuadrada.UseVisualStyleBackColor = true;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.btnRaizCuadrada_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(301, 163);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(86, 36);
            this.btnDividir.TabIndex = 7;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Location = new System.Drawing.Point(25, 247);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(86, 36);
            this.btnPorcentaje.TabIndex = 8;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(117, 205);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(86, 36);
            this.btnPi.TabIndex = 9;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnEuler
            // 
            this.btnEuler.Location = new System.Drawing.Point(209, 205);
            this.btnEuler.Name = "btnEuler";
            this.btnEuler.Size = new System.Drawing.Size(86, 36);
            this.btnEuler.TabIndex = 10;
            this.btnEuler.Text = "e";
            this.btnEuler.UseVisualStyleBackColor = true;
            this.btnEuler.Click += new System.EventHandler(this.btnEuler_Click);
            // 
            // btnN7
            // 
            this.btnN7.Location = new System.Drawing.Point(25, 289);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(86, 36);
            this.btnN7.TabIndex = 11;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = true;
            // 
            // btnN8
            // 
            this.btnN8.Location = new System.Drawing.Point(117, 289);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(86, 36);
            this.btnN8.TabIndex = 12;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = true;
            // 
            // btnN9
            // 
            this.btnN9.Location = new System.Drawing.Point(209, 289);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(86, 36);
            this.btnN9.TabIndex = 13;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = true;
            // 
            // btnN4
            // 
            this.btnN4.Location = new System.Drawing.Point(25, 331);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(86, 36);
            this.btnN4.TabIndex = 14;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = true;
            // 
            // btnN5
            // 
            this.btnN5.Location = new System.Drawing.Point(117, 331);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(86, 36);
            this.btnN5.TabIndex = 15;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = true;
            // 
            // btnN6
            // 
            this.btnN6.Location = new System.Drawing.Point(209, 331);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(86, 36);
            this.btnN6.TabIndex = 16;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = true;
            // 
            // btnN1
            // 
            this.btnN1.Location = new System.Drawing.Point(25, 373);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(86, 36);
            this.btnN1.TabIndex = 17;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = true;
            // 
            // btnN2
            // 
            this.btnN2.Location = new System.Drawing.Point(117, 373);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(86, 36);
            this.btnN2.TabIndex = 18;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = true;
            // 
            // btnN3
            // 
            this.btnN3.Location = new System.Drawing.Point(209, 373);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(86, 36);
            this.btnN3.TabIndex = 19;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(301, 205);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(86, 36);
            this.btnMultiplicar.TabIndex = 20;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(301, 247);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(86, 36);
            this.btnRestar.TabIndex = 21;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(301, 289);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(86, 36);
            this.btnSumar.TabIndex = 22;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(301, 331);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(86, 120);
            this.btnIgual.TabIndex = 23;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(209, 415);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(86, 36);
            this.btnDecimal.TabIndex = 24;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btnN0
            // 
            this.btnN0.Location = new System.Drawing.Point(117, 415);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(86, 36);
            this.btnN0.TabIndex = 25;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = true;
            // 
            // btnSigno
            // 
            this.btnSigno.Location = new System.Drawing.Point(25, 415);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(86, 36);
            this.btnSigno.TabIndex = 26;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = true;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnAbrirParentesis
            // 
            this.btnAbrirParentesis.Location = new System.Drawing.Point(117, 247);
            this.btnAbrirParentesis.Name = "btnAbrirParentesis";
            this.btnAbrirParentesis.Size = new System.Drawing.Size(86, 36);
            this.btnAbrirParentesis.TabIndex = 27;
            this.btnAbrirParentesis.Text = "(";
            this.btnAbrirParentesis.UseVisualStyleBackColor = true;
            // 
            // btnCerrarParentesis
            // 
            this.btnCerrarParentesis.Location = new System.Drawing.Point(209, 247);
            this.btnCerrarParentesis.Name = "btnCerrarParentesis";
            this.btnCerrarParentesis.Size = new System.Drawing.Size(86, 36);
            this.btnCerrarParentesis.TabIndex = 28;
            this.btnCerrarParentesis.Text = ")";
            this.btnCerrarParentesis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 524);
            this.Controls.Add(this.btnCerrarParentesis);
            this.Controls.Add(this.btnAbrirParentesis);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnEuler);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnExponente);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnLimpiarEntrada);
            this.Controls.Add(this.btnLimpiarTodo);
            this.Controls.Add(this.btnEliminarCaracter);
            this.Controls.Add(this.txtTablero);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTablero;
        private System.Windows.Forms.Button btnEliminarCaracter;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.Button btnLimpiarEntrada;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnExponente;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnEuler;
        private System.Windows.Forms.Button btnN7;
        private System.Windows.Forms.Button btnN8;
        private System.Windows.Forms.Button btnN9;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnN0;
        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Button btnAbrirParentesis;
        private System.Windows.Forms.Button btnCerrarParentesis;
    }
}

