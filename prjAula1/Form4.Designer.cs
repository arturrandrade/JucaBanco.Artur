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
            txtSaldoInicial = new TextBox();
            txtDepositoInicial = new Label();
            CriarConta = new Button();
            txtSenhaConta = new Label();
            txtRepeteSenhaConta = new Label();
            SenhaDaConta = new TextBox();
            RepetirSenhaDaConta = new TextBox();
            SuspendLayout();
            // 
            // txtSaldoInicial
            // 
            txtSaldoInicial.Location = new Point(278, 85);
            txtSaldoInicial.Name = "txtSaldoInicial";
            txtSaldoInicial.Size = new Size(165, 23);
            txtSaldoInicial.TabIndex = 3;
            // 
            // txtDepositoInicial
            // 
            txtDepositoInicial.AutoSize = true;
            txtDepositoInicial.Location = new Point(315, 58);
            txtDepositoInicial.Name = "txtDepositoInicial";
            txtDepositoInicial.Size = new Size(88, 15);
            txtDepositoInicial.TabIndex = 4;
            txtDepositoInicial.Text = "Depósito Inicial";
            txtDepositoInicial.Click += label1_Click;
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
            // txtSenhaConta
            // 
            txtSenhaConta.AutoSize = true;
            txtSenhaConta.Location = new Point(313, 142);
            txtSenhaConta.Name = "txtSenhaConta";
            txtSenhaConta.Size = new Size(90, 15);
            txtSenhaConta.TabIndex = 6;
            txtSenhaConta.Text = "Senha da Conta";
            // 
            // txtRepeteSenhaConta
            // 
            txtRepeteSenhaConta.AutoSize = true;
            txtRepeteSenhaConta.Location = new Point(296, 229);
            txtRepeteSenhaConta.Name = "txtRepeteSenhaConta";
            txtRepeteSenhaConta.Size = new Size(132, 15);
            txtRepeteSenhaConta.TabIndex = 7;
            txtRepeteSenhaConta.Text = "Repita a senha da conta";
            txtRepeteSenhaConta.Click += label3_Click;
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
            Controls.Add(txtRepeteSenhaConta);
            Controls.Add(txtSenhaConta);
            Controls.Add(CriarConta);
            Controls.Add(txtDepositoInicial);
            Controls.Add(txtSaldoInicial);
            ForeColor = SystemColors.ControlText;
            Name = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSaldoInicial;
        private Label txtDepositoInicial;
        private Button CriarConta;
        private Label txtSenhaConta;
        private Label txtRepeteSenhaConta;
        private TextBox SenhaDaConta;
        private TextBox RepetirSenhaDaConta;
    }
}