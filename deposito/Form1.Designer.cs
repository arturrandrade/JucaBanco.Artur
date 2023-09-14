namespace deposito
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
            Depositar = new Button();
            Titular = new TextBox();
            TitularDaConta = new Label();
            ValorDoSaque = new Label();
            SaldoParaDepositar = new Label();
            NumeroDeposito = new Label();
            Saldo = new TextBox();
            Numero = new TextBox();
            Valor = new TextBox();
            Sacar = new Button();
            SuspendLayout();
            // 
            // Depositar
            // 
            Depositar.Location = new Point(196, 338);
            Depositar.Name = "Depositar";
            Depositar.Size = new Size(102, 28);
            Depositar.TabIndex = 43;
            Depositar.Text = "Depositar";
            Depositar.UseVisualStyleBackColor = true;
            Depositar.Click += Depositar_Click;
            // 
            // Titular
            // 
            Titular.Location = new Point(253, 134);
            Titular.Name = "Titular";
            Titular.Size = new Size(165, 23);
            Titular.TabIndex = 44;
            // 
            // TitularDaConta
            // 
            TitularDaConta.AutoSize = true;
            TitularDaConta.Location = new Point(167, 137);
            TitularDaConta.Name = "TitularDaConta";
            TitularDaConta.Size = new Size(40, 15);
            TitularDaConta.TabIndex = 45;
            TitularDaConta.Text = "Títular";
            // 
            // ValorDoSaque
            // 
            ValorDoSaque.AutoSize = true;
            ValorDoSaque.Location = new Point(167, 265);
            ValorDoSaque.Name = "ValorDoSaque";
            ValorDoSaque.Size = new Size(33, 15);
            ValorDoSaque.TabIndex = 46;
            ValorDoSaque.Text = "Valor";
            // 
            // SaldoParaDepositar
            // 
            SaldoParaDepositar.AutoSize = true;
            SaldoParaDepositar.Location = new Point(167, 222);
            SaldoParaDepositar.Name = "SaldoParaDepositar";
            SaldoParaDepositar.Size = new Size(36, 15);
            SaldoParaDepositar.TabIndex = 47;
            SaldoParaDepositar.Text = "Saldo";
            // 
            // NumeroDeposito
            // 
            NumeroDeposito.AutoSize = true;
            NumeroDeposito.Location = new Point(167, 182);
            NumeroDeposito.Name = "NumeroDeposito";
            NumeroDeposito.Size = new Size(51, 15);
            NumeroDeposito.TabIndex = 48;
            NumeroDeposito.Text = "Número";
            // 
            // Saldo
            // 
            Saldo.Location = new Point(253, 222);
            Saldo.Name = "Saldo";
            Saldo.Size = new Size(165, 23);
            Saldo.TabIndex = 49;
            // 
            // Numero
            // 
            Numero.Location = new Point(253, 182);
            Numero.Name = "Numero";
            Numero.Size = new Size(165, 23);
            Numero.TabIndex = 50;
            // 
            // Valor
            // 
            Valor.Location = new Point(253, 262);
            Valor.Name = "Valor";
            Valor.Size = new Size(165, 23);
            Valor.TabIndex = 51;
            // 
            // Sacar
            // 
            Sacar.Location = new Point(388, 338);
            Sacar.Name = "Sacar";
            Sacar.Size = new Size(102, 28);
            Sacar.TabIndex = 52;
            Sacar.Text = "Sacar";
            Sacar.UseVisualStyleBackColor = true;
            Sacar.Click += Sacar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sacar);
            Controls.Add(Valor);
            Controls.Add(Numero);
            Controls.Add(Saldo);
            Controls.Add(NumeroDeposito);
            Controls.Add(SaldoParaDepositar);
            Controls.Add(ValorDoSaque);
            Controls.Add(TitularDaConta);
            Controls.Add(Titular);
            Controls.Add(Depositar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Depositar;
        private TextBox Titular;
        private Label TitularDaConta;
        private Label ValorDoSaque;
        private Label SaldoParaDepositar;
        private Label NumeroDeposito;
        private TextBox Saldo;
        private TextBox Numero;
        private TextBox Valor;
        private Button Sacar;
    }
}