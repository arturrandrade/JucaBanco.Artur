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
            label1 = new Label();
            button1 = new Button();
            lblMensagem = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 310);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "saldo:";
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
            // lblMensagem
            // 
            lblMensagem.Location = new Point(284, 122);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(165, 23);
            lblMensagem.TabIndex = 2;
            lblMensagem.TextChanged += textBox1_TextChanged;
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
            Controls.Add(lblMensagem);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "extraForm";
            Text = "extraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox lblMensagem;
        private Button button2;
        private Button button3;
    }
}