namespace CalculadoraWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonPositivoNegativo = new Button();
            buttonDecimal = new Button();
            buttonIgual = new Button();
            buttonSumar = new Button();
            buttonRestar = new Button();
            buttonMultiplicar = new Button();
            buttonLimpiar = new Button();
            buttonLimpiarEntrada = new Button();
            buttonElevar = new Button();
            buttonDividir = new Button();
            pantalla = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 243);
            button1.Name = "button1";
            button1.Size = new Size(68, 53);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(88, 243);
            button2.Name = "button2";
            button2.Size = new Size(70, 53);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(164, 243);
            button3.Name = "button3";
            button3.Size = new Size(70, 53);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 184);
            button4.Name = "button4";
            button4.Size = new Size(70, 53);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(88, 184);
            button5.Name = "button5";
            button5.Size = new Size(70, 53);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(164, 184);
            button6.Name = "button6";
            button6.Size = new Size(70, 53);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(12, 125);
            button7.Name = "button7";
            button7.Size = new Size(70, 53);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(88, 125);
            button8.Name = "button8";
            button8.Size = new Size(70, 53);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(164, 125);
            button9.Name = "button9";
            button9.Size = new Size(70, 53);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(88, 302);
            button0.Name = "button0";
            button0.Size = new Size(70, 53);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonPositivoNegativo
            // 
            buttonPositivoNegativo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPositivoNegativo.Location = new Point(12, 302);
            buttonPositivoNegativo.Name = "buttonPositivoNegativo";
            buttonPositivoNegativo.Size = new Size(70, 53);
            buttonPositivoNegativo.TabIndex = 10;
            buttonPositivoNegativo.Text = "+/-";
            buttonPositivoNegativo.UseVisualStyleBackColor = true;
            buttonPositivoNegativo.Click += buttonPositivoNegativo_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecimal.Location = new Point(164, 302);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(70, 53);
            buttonDecimal.TabIndex = 11;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += buttonDecimal_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.BackColor = SystemColors.Info;
            buttonIgual.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIgual.Location = new Point(240, 302);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(70, 53);
            buttonIgual.TabIndex = 12;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = false;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonSumar
            // 
            buttonSumar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSumar.Location = new Point(240, 243);
            buttonSumar.Name = "buttonSumar";
            buttonSumar.Size = new Size(70, 53);
            buttonSumar.TabIndex = 13;
            buttonSumar.Text = "+";
            buttonSumar.UseVisualStyleBackColor = true;
            buttonSumar.Click += buttonSumar_Click;
            // 
            // buttonRestar
            // 
            buttonRestar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRestar.Location = new Point(240, 184);
            buttonRestar.Name = "buttonRestar";
            buttonRestar.Size = new Size(70, 53);
            buttonRestar.TabIndex = 14;
            buttonRestar.Text = "-";
            buttonRestar.UseVisualStyleBackColor = true;
            buttonRestar.Click += buttonRestar_Click;
            // 
            // buttonMultiplicar
            // 
            buttonMultiplicar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiplicar.Location = new Point(240, 125);
            buttonMultiplicar.Name = "buttonMultiplicar";
            buttonMultiplicar.Size = new Size(70, 53);
            buttonMultiplicar.TabIndex = 15;
            buttonMultiplicar.Text = "x";
            buttonMultiplicar.UseVisualStyleBackColor = true;
            buttonMultiplicar.Click += buttonMultiplicar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = SystemColors.ScrollBar;
            buttonLimpiar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(12, 66);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(70, 53);
            buttonLimpiar.TabIndex = 16;
            buttonLimpiar.Text = "C";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonLimpiarEntrada
            // 
            buttonLimpiarEntrada.BackColor = SystemColors.ScrollBar;
            buttonLimpiarEntrada.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiarEntrada.Location = new Point(88, 66);
            buttonLimpiarEntrada.Name = "buttonLimpiarEntrada";
            buttonLimpiarEntrada.Size = new Size(70, 53);
            buttonLimpiarEntrada.TabIndex = 17;
            buttonLimpiarEntrada.Text = "CE";
            buttonLimpiarEntrada.UseVisualStyleBackColor = false;
            buttonLimpiarEntrada.Click += buttonLimpiarEntrada_Click;
            // 
            // buttonElevar
            // 
            buttonElevar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonElevar.Location = new Point(164, 66);
            buttonElevar.Name = "buttonElevar";
            buttonElevar.Size = new Size(70, 53);
            buttonElevar.TabIndex = 18;
            buttonElevar.Text = "EXP";
            buttonElevar.UseVisualStyleBackColor = true;
            buttonElevar.Click += buttonElevar_Click;
            // 
            // buttonDividir
            // 
            buttonDividir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDividir.Location = new Point(240, 66);
            buttonDividir.Name = "buttonDividir";
            buttonDividir.Size = new Size(70, 53);
            buttonDividir.TabIndex = 19;
            buttonDividir.Text = "/";
            buttonDividir.UseVisualStyleBackColor = true;
            buttonDividir.Click += buttonDividir_Click;
            // 
            // pantalla
            // 
            pantalla.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pantalla.Location = new Point(12, 12);
            pantalla.Multiline = true;
            pantalla.Name = "pantalla";
            pantalla.Size = new Size(298, 48);
            pantalla.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(324, 361);
            Controls.Add(pantalla);
            Controls.Add(buttonDividir);
            Controls.Add(buttonElevar);
            Controls.Add(buttonLimpiarEntrada);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonMultiplicar);
            Controls.Add(buttonRestar);
            Controls.Add(buttonSumar);
            Controls.Add(buttonIgual);
            Controls.Add(buttonDecimal);
            Controls.Add(buttonPositivoNegativo);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonPositivoNegativo;
        private Button buttonDecimal;
        private Button buttonIgual;
        private Button buttonSumar;
        private Button buttonRestar;
        private Button buttonMultiplicar;
        private Button buttonLimpiar;
        private Button buttonLimpiarEntrada;
        private Button buttonElevar;
        private Button buttonDividir;
        private TextBox pantalla;
    }
}