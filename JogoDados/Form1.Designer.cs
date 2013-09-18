namespace JogoDados
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownJogador1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownJogador2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLacarDados = new System.Windows.Forms.Button();
            this.pictureBoxdado1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDado2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxCampoVencedor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJogador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJogador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faça sua aposta!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aposte e ganhe creditos!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jogador 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jogador 2:";
            // 
            // numericUpDownJogador1
            // 
            this.numericUpDownJogador1.Location = new System.Drawing.Point(15, 100);
            this.numericUpDownJogador1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownJogador1.Name = "numericUpDownJogador1";
            this.numericUpDownJogador1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownJogador1.TabIndex = 4;
            this.numericUpDownJogador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownJogador2
            // 
            this.numericUpDownJogador2.Location = new System.Drawing.Point(121, 100);
            this.numericUpDownJogador2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownJogador2.Name = "numericUpDownJogador2";
            this.numericUpDownJogador2.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownJogador2.TabIndex = 4;
            this.numericUpDownJogador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vencedor:";
            // 
            // buttonLacarDados
            // 
            this.buttonLacarDados.Location = new System.Drawing.Point(217, 90);
            this.buttonLacarDados.Name = "buttonLacarDados";
            this.buttonLacarDados.Size = new System.Drawing.Size(102, 32);
            this.buttonLacarDados.TabIndex = 7;
            this.buttonLacarDados.Text = "Lançar dados";
            this.buttonLacarDados.UseVisualStyleBackColor = true;
            this.buttonLacarDados.Click += new System.EventHandler(this.buttonLacarDados_Click);
            // 
            // pictureBoxdado1
            // 
            this.pictureBoxdado1.Image = global::JogoDados.Properties.Resources.Dado;
            this.pictureBoxdado1.Location = new System.Drawing.Point(15, 153);
            this.pictureBoxdado1.Name = "pictureBoxdado1";
            this.pictureBoxdado1.Size = new System.Drawing.Size(81, 66);
            this.pictureBoxdado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxdado1.TabIndex = 6;
            this.pictureBoxdado1.TabStop = false;
            // 
            // pictureBoxDado2
            // 
            this.pictureBoxDado2.Image = global::JogoDados.Properties.Resources.Dado;
            this.pictureBoxDado2.Location = new System.Drawing.Point(121, 153);
            this.pictureBoxDado2.Name = "pictureBoxDado2";
            this.pictureBoxDado2.Size = new System.Drawing.Size(84, 66);
            this.pictureBoxDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDado2.TabIndex = 6;
            this.pictureBoxDado2.TabStop = false;
            this.pictureBoxDado2.Click += new System.EventHandler(this.pictureBoxDado2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Turquoise;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox1.Location = new System.Drawing.Point(238, 153);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 66);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCampoVencedor
            // 
            this.textBoxCampoVencedor.BackColor = System.Drawing.Color.Turquoise;
            this.textBoxCampoVencedor.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCampoVencedor.ForeColor = System.Drawing.Color.Red;
            this.textBoxCampoVencedor.Location = new System.Drawing.Point(121, 280);
            this.textBoxCampoVencedor.Name = "textBoxCampoVencedor";
            this.textBoxCampoVencedor.Size = new System.Drawing.Size(193, 33);
            this.textBoxCampoVencedor.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Jogar Novamente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(326, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxCampoVencedor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLacarDados);
            this.Controls.Add(this.pictureBoxdado1);
            this.Controls.Add(this.pictureBoxDado2);
            this.Controls.Add(this.numericUpDownJogador2);
            this.Controls.Add(this.numericUpDownJogador1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MairaFatima1241028";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJogador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJogador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownJogador1;
        private System.Windows.Forms.NumericUpDown numericUpDownJogador2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxDado2;
        private System.Windows.Forms.PictureBox pictureBoxdado1;
        private System.Windows.Forms.Button buttonLacarDados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxCampoVencedor;
        private System.Windows.Forms.Button button2;
    }
}

