namespace prjAula1
{
    partial class extra
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
            ValorDoDeposito = new TextBox();
            BotaoDepositar = new Button();
            Mensagem = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // ValorDoDeposito
            // 
            ValorDoDeposito.Location = new Point(167, 122);
            ValorDoDeposito.Name = "ValorDoDeposito";
            ValorDoDeposito.Size = new Size(416, 23);
            ValorDoDeposito.TabIndex = 0;
            // 
            // BotaoDepositar
            // 
            BotaoDepositar.Location = new Point(273, 208);
            BotaoDepositar.Name = "BotaoDepositar";
            BotaoDepositar.Size = new Size(75, 23);
            BotaoDepositar.TabIndex = 1;
            BotaoDepositar.Text = "Depositar";
            BotaoDepositar.UseVisualStyleBackColor = true;
            BotaoDepositar.Click += BotaoDepositar_Click;
            // 
            // Mensagem
            // 
            Mensagem.AutoSize = true;
            Mensagem.Location = new Point(361, 288);
            Mensagem.Name = "Mensagem";
            Mensagem.Size = new Size(35, 15);
            Mensagem.TabIndex = 2;
            Mensagem.Text = "saldo";
            Mensagem.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(398, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Sacar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // extra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Mensagem);
            Controls.Add(BotaoDepositar);
            Controls.Add(ValorDoDeposito);
            Name = "extra";
            Text = "extra";
            Load += extra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ValorDoDeposito;
        private Button BotaoDepositar;
        private Label Mensagem;
        private Button button1;
    }
}