using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonLacarDados_Click(object sender, EventArgs e)
        {
            int R;
            Random NumeroJoga1 = new Random();
            int A = NumeroJoga1.Next(1,7);            
            Random NumeroJoga2 = new Random();
            int B = (2 + NumeroJoga2.Next(1, 7));
            textBoxCampoVencedor.Text = " ";
          
                      
            switch (A)
            {
                case 1: pictureBoxdado1.Image = Properties.Resources.Dado1; break;
                case 2: pictureBoxdado1.Image = Properties.Resources.dado2; break;
                case 3: pictureBoxdado1.Image = Properties.Resources.dado3; break;
                case 4: pictureBoxdado1.Image = Properties.Resources.dado4; break;
                case 5: pictureBoxdado1.Image = Properties.Resources.Dado5; break;
                case 6: pictureBoxdado1.Image = Properties.Resources.dado6; break;
            }
            switch (B)
            {
                case 1: pictureBoxDado2.Image = Properties.Resources.Dado1; break;
                case 2: pictureBoxDado2.Image = Properties.Resources.dado2; break;
                case 3: pictureBoxDado2.Image = Properties.Resources.dado3; break;
                case 4: pictureBoxDado2.Image = Properties.Resources.dado4; break;
                case 5: pictureBoxDado2.Image = Properties.Resources.Dado5; break;
                case 6: pictureBoxDado2.Image = Properties.Resources.dado6; break;
            }
            R = A + B;
            textBox1.Text = Convert.ToString(Convert.ToInt16(R));

            if (numericUpDownJogador1.Value == R)
            {
                if (numericUpDownJogador2.Value == R)
                {
                    textBoxCampoVencedor.Text = "Empate";
                }
                else 
                {
                    textBoxCampoVencedor.Text = "Jogador 1";                   
                }

            }
            else if (numericUpDownJogador2.Value == R)
            {
                textBoxCampoVencedor.Text = "Jogador 2";
            }
            else
            {
                textBoxCampoVencedor.Text = "Não há vencedor!!";
            }
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxdado1.Image = Properties.Resources.Dado;
            pictureBoxDado2.Image = Properties.Resources.Dado;
            textBox1.Text = " ";
            textBoxCampoVencedor.Text = " ";
            numericUpDownJogador1.Value = 0;
            numericUpDownJogador2.Value = 0;
        }

        private void pictureBoxDado2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
