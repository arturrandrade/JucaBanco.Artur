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
            txtCpfCadastro = new TextBox();
            txtDataNascimento = new TextBox();
            txtEmail = new TextBox();
            rbOutro = new RadioButton();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
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
            pictureBox1.Size = new Size(352, 467);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
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
            // txtCpfCadastro
            // 
            txtCpfCadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfCadastro.ForeColor = SystemColors.ScrollBar;
            txtCpfCadastro.Location = new Point(197, 434);
            txtCpfCadastro.Name = "txtCpfCadastro";
            txtCpfCadastro.PlaceholderText = "CPF";
            txtCpfCadastro.Size = new Size(217, 33);
            txtCpfCadastro.TabIndex = 22;
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
            rbOutro.Location = new Point(447, 475);
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
            rbFeminino.Location = new Point(184, 475);
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
            rbMasculino.Location = new Point(309, 475);
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
            button2.Click += button2_Click;
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
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(197, 200);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Estado";
            textBox3.Size = new Size(217, 33);
            textBox3.TabIndex = 41;
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
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.ForeColor = SystemColors.ScrollBar;
            textBox9.Location = new Point(197, 317);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Cidade";
            textBox9.Size = new Size(217, 33);
            textBox9.TabIndex = 47;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.ForeColor = SystemColors.ScrollBar;
            textBox10.Location = new Point(197, 356);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Senha";
            textBox10.Size = new Size(217, 33);
            textBox10.TabIndex = 48;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.ForeColor = SystemColors.ScrollBar;
            textBox11.Location = new Point(197, 395);
            textBox11.Name = "textBox11";
            textBox11.PlaceholderText = "Repetir Senha";
            textBox11.Size = new Size(217, 33);
            textBox11.TabIndex = 49;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(725, 516);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(rbMasculino);
            Controls.Add(rbFeminino);
            Controls.Add(rbOutro);
            Controls.Add(txtEmail);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtCpfCadastro);
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
        private TextBox txtCpfCadastro;
        private TextBox txtDataNascimento;
        private TextBox txtEmail;
        private RadioButton rbOutro;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private Button button2;
        internal protected PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
    }
}