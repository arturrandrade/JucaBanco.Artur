namespace prjAula1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FazerDeposito = new TextBox();
            DepositoInicial = new Label();
            CriarConta = new Button();
            SenhaConta = new Label();
            RepetirSenhaConta = new Label();
            SenhaDaConta = new TextBox();
            RepetirSenhaDaConta = new TextBox();
            SuspendLayout();
            // 
            // FazerDeposito
            // 
            FazerDeposito.Location = new Point(278, 85);
            FazerDeposito.Name = "FazerDeposito";
            FazerDeposito.Size = new Size(165, 23);
            FazerDeposito.TabIndex = 3;
            // 
            // DepositoInicial
            // 
            DepositoInicial.AutoSize = true;
            DepositoInicial.Location = new Point(315, 58);
            DepositoInicial.Name = "DepositoInicial";
            DepositoInicial.Size = new Size(88, 15);
            DepositoInicial.TabIndex = 4;
            DepositoInicial.Text = "Depósito Inicial";
            DepositoInicial.Click += label1_Click;
            // 
            // CriarConta
            // 
            CriarConta.Location = new Point(315, 339);
            CriarConta.Name = "CriarConta";
            CriarConta.Size = new Size(102, 23);
            CriarConta.TabIndex = 5;
            CriarConta.Text = "Criar Conta";
            CriarConta.UseVisualStyleBackColor = true;
            CriarConta.Click += button3_Click;
            // 
            // SenhaConta
            // 
            SenhaConta.AutoSize = true;
            SenhaConta.Location = new Point(313, 142);
            SenhaConta.Name = "SenhaConta";
            SenhaConta.Size = new Size(90, 15);
            SenhaConta.TabIndex = 6;
            SenhaConta.Text = "Senha da Conta";
            // 
            // RepetirSenhaConta
            // 
            RepetirSenhaConta.AutoSize = true;
            RepetirSenhaConta.Location = new Point(296, 229);
            RepetirSenhaConta.Name = "RepetirSenhaConta";
            RepetirSenhaConta.Size = new Size(132, 15);
            RepetirSenhaConta.TabIndex = 7;
            RepetirSenhaConta.Text = "Repita a senha da conta";
            RepetirSenhaConta.Click += label3_Click;
            // 
            // SenhaDaConta
            // 
            SenhaDaConta.Location = new Point(278, 170);
            SenhaDaConta.Name = "SenhaDaConta";
            SenhaDaConta.Size = new Size(165, 23);
            SenhaDaConta.TabIndex = 8;
            // 
            // RepetirSenhaDaConta
            // 
            RepetirSenhaDaConta.Location = new Point(278, 258);
            RepetirSenhaDaConta.Name = "RepetirSenhaDaConta";
            RepetirSenhaDaConta.Size = new Size(165, 23);
            RepetirSenhaDaConta.TabIndex = 9;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(RepetirSenhaDaConta);
            Controls.Add(SenhaDaConta);
            Controls.Add(RepetirSenhaConta);
            Controls.Add(SenhaConta);
            Controls.Add(CriarConta);
            Controls.Add(DepositoInicial);
            Controls.Add(FazerDeposito);
            ForeColor = SystemColors.ControlText;
            Name = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FazerDeposito;
        private Label DepositoInicial;
        private Button CriarConta;
        private Label SenhaConta;
        private Label RepetirSenhaConta;
        private TextBox SenhaDaConta;
        private TextBox RepetirSenhaDaConta;
    }
}