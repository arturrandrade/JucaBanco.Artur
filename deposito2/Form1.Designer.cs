namespace deposito2
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
            txtDepositoInicial = new Label();
            SenhaDaConta = new TextBox();
            CriarConta = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Numero = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtDepositoInicial
            // 
            txtDepositoInicial.AutoSize = true;
            txtDepositoInicial.Location = new Point(200, 115);
            txtDepositoInicial.Name = "txtDepositoInicial";
            txtDepositoInicial.Size = new Size(40, 15);
            txtDepositoInicial.TabIndex = 5;
            txtDepositoInicial.Text = "Titular";
            // 
            // SenhaDaConta
            // 
            SenhaDaConta.Location = new Point(296, 141);
            SenhaDaConta.Name = "SenhaDaConta";
            SenhaDaConta.Size = new Size(165, 23);
            SenhaDaConta.TabIndex = 9;
            // 
            // CriarConta
            // 
            CriarConta.Location = new Point(234, 271);
            CriarConta.Name = "CriarConta";
            CriarConta.Size = new Size(102, 30);
            CriarConta.TabIndex = 10;
            CriarConta.Text = "Depositar";
            CriarConta.UseVisualStyleBackColor = true;
            CriarConta.Click += CriarConta_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(296, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 13;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 202);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 14;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 173);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 15;
            label2.Text = "Saldo";
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Location = new Point(200, 144);
            Numero.Name = "Numero";
            Numero.Size = new Size(51, 15);
            Numero.TabIndex = 16;
            Numero.Text = "Numero";
            // 
            // button1
            // 
            button1.Location = new Point(382, 271);
            button1.Name = "button1";
            button1.Size = new Size(102, 30);
            button1.TabIndex = 17;
            button1.Text = "Sacar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Numero);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(CriarConta);
            Controls.Add(SenhaDaConta);
            Controls.Add(txtDepositoInicial);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtDepositoInicial;
        private TextBox SenhaDaConta;
        private Button CriarConta;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label Numero;
        private Button button1;
    }
}