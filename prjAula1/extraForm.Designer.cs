﻿namespace prjAula1
{
    partial class extraForm
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
            txtSaldo = new Label();
            button1 = new Button();
            txtValorDeposito = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtSaldo
            // 
            txtSaldo.AutoSize = true;
            txtSaldo.Location = new Point(284, 310);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(38, 15);
            txtSaldo.TabIndex = 0;
            txtSaldo.Text = "saldo:";
            // 
            // button1
            // 
            button1.Location = new Point(308, 164);
            button1.Name = "button1";
            button1.Size = new Size(102, 30);
            button1.TabIndex = 1;
            button1.Text = "depositar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.Location = new Point(284, 122);
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.Size = new Size(165, 23);
            txtValorDeposito.TabIndex = 2;
            txtValorDeposito.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(308, 211);
            button2.Name = "button2";
            button2.Size = new Size(102, 26);
            button2.TabIndex = 3;
            button2.Text = "sacar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(308, 256);
            button3.Name = "button3";
            button3.Size = new Size(102, 23);
            button3.TabIndex = 4;
            button3.Text = "exibir saldo";
            button3.UseVisualStyleBackColor = true;
            // 
            // extraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtValorDeposito);
            Controls.Add(button1);
            Controls.Add(txtSaldo);
            Name = "extraForm";
            Text = "extraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtSaldo;
        private Button button1;
        private TextBox txtValorDeposito;
        private Button button2;
        private Button button3;
    }
}