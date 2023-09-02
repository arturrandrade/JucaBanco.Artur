namespace prjAula1
{
    partial class cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            txtNome = new TextBox();
            txtSenhaCadastro = new TextBox();
            txtCpf = new TextBox();
            txtDataNascimento = new TextBox();
            txtEmail = new TextBox();
            rbOutro = new RadioButton();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            cmbEstados = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            txtCidade = new TextBox();
            txtSenhaConta = new TextBox();
            txtRepetirSenhaConta = new TextBox();
            txtNumero = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Pink;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(184, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 512);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Agency FB", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.HotPink;
            lblLogin.Location = new Point(22, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(156, 45);
            lblLogin.TabIndex = 16;
            lblLogin.Text = "CADASTRAR";
            lblLogin.Click += lblLogin_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.ScrollBar;
            txtNome.Location = new Point(197, 9);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(217, 33);
            txtNome.TabIndex = 17;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaCadastro.ForeColor = SystemColors.ScrollBar;
            txtSenhaCadastro.Location = new Point(197, 44);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PlaceholderText = "senha(6 digitos)";
            txtSenhaCadastro.Size = new Size(217, 33);
            txtSenhaCadastro.TabIndex = 19;
            txtSenhaCadastro.TextChanged += txtSenhaCadastro_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.ForeColor = SystemColors.ScrollBar;
            txtCpf.Location = new Point(197, 434);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "CPF";
            txtCpf.Size = new Size(217, 33);
            txtCpf.TabIndex = 22;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataNascimento.ForeColor = SystemColors.ScrollBar;
            txtDataNascimento.Location = new Point(197, 83);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PlaceholderText = "data de nascimento";
            txtDataNascimento.Size = new Size(217, 33);
            txtDataNascimento.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.ScrollBar;
            txtEmail.Location = new Point(197, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email";
            txtEmail.Size = new Size(217, 33);
            txtEmail.TabIndex = 24;
            // 
            // rbOutro
            // 
            rbOutro.AutoSize = true;
            rbOutro.BackColor = Color.Transparent;
            rbOutro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbOutro.ForeColor = Color.DeepPink;
            rbOutro.Location = new Point(22, 435);
            rbOutro.Name = "rbOutro";
            rbOutro.Size = new Size(76, 29);
            rbOutro.TabIndex = 27;
            rbOutro.TabStop = true;
            rbOutro.Text = "outro";
            rbOutro.UseVisualStyleBackColor = false;
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.BackColor = Color.Transparent;
            rbFeminino.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbFeminino.ForeColor = Color.DeepPink;
            rbFeminino.Location = new Point(22, 357);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(105, 29);
            rbFeminino.TabIndex = 28;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "feminino";
            rbFeminino.UseVisualStyleBackColor = false;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.BackColor = Color.Transparent;
            rbMasculino.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbMasculino.ForeColor = Color.DeepPink;
            rbMasculino.Location = new Point(22, 399);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(116, 29);
            rbMasculino.TabIndex = 29;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "masculino";
            rbMasculino.UseVisualStyleBackColor = false;
            rbMasculino.CheckedChanged += rbMasculino_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepPink;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(571, 458);
            button2.Name = "button2";
            button2.Size = new Size(124, 33);
            button2.TabIndex = 30;
            button2.Text = "Criar Conta";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(571, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(197, 161);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "RG";
            textBox1.Size = new Size(217, 33);
            textBox1.TabIndex = 39;
            // 
            // cmbEstados
            // 
            cmbEstados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstados.ForeColor = SystemColors.ScrollBar;
            cmbEstados.Location = new Point(197, 200);
            cmbEstados.Name = "cmbEstados";
            cmbEstados.PlaceholderText = "Estado";
            cmbEstados.Size = new Size(217, 33);
            cmbEstados.TabIndex = 41;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(197, 239);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Sexo";
            textBox4.Size = new Size(217, 33);
            textBox4.TabIndex = 42;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = SystemColors.ScrollBar;
            textBox6.Location = new Point(197, 278);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Depósito Inicial";
            textBox6.Size = new Size(217, 33);
            textBox6.TabIndex = 44;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.ForeColor = SystemColors.ScrollBar;
            txtCidade.Location = new Point(197, 317);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(217, 33);
            txtCidade.TabIndex = 47;
            // 
            // txtSenhaConta
            // 
            txtSenhaConta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaConta.ForeColor = SystemColors.ScrollBar;
            txtSenhaConta.Location = new Point(197, 356);
            txtSenhaConta.Name = "txtSenhaConta";
            txtSenhaConta.PlaceholderText = "Senha";
            txtSenhaConta.Size = new Size(217, 33);
            txtSenhaConta.TabIndex = 48;
            // 
            // txtRepetirSenhaConta
            // 
            txtRepetirSenhaConta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepetirSenhaConta.ForeColor = SystemColors.ScrollBar;
            txtRepetirSenhaConta.Location = new Point(197, 395);
            txtRepetirSenhaConta.Name = "txtRepetirSenhaConta";
            txtRepetirSenhaConta.PlaceholderText = "Repetir Senha";
            txtRepetirSenhaConta.Size = new Size(217, 33);
            txtRepetirSenhaConta.TabIndex = 49;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.ForeColor = SystemColors.ScrollBar;
            txtNumero.Location = new Point(197, 473);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Número";
            txtNumero.Size = new Size(217, 33);
            txtNumero.TabIndex = 50;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(725, 516);
            Controls.Add(txtNumero);
            Controls.Add(txtRepetirSenhaConta);
            Controls.Add(txtSenhaConta);
            Controls.Add(txtCidade);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(cmbEstados);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(rbMasculino);
            Controls.Add(rbFeminino);
            Controls.Add(rbOutro);
            Controls.Add(txtEmail);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(txtNome);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "cadastro";
            Text = "Form3";
            Load += cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private TextBox txtNome;
        private TextBox txtSenhaCadastro;
        private TextBox txtCpf;
        private TextBox txtDataNascimento;
        private TextBox txtEmail;
        private RadioButton rbOutro;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private Button button2;
        internal protected PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox cmbEstados;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox txtCidade;
        private TextBox txtSenhaConta;
        private TextBox txtRepetirSenhaConta;
        private TextBox txtNumero;
    }
}