using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Da_Forca
{
    public partial class Historia : Form
    {
        private String[] palavras;
        private String[] dicas;
        private String palavra;
        private String tela;
        private int tentativas;
        private int pospalavra;
        private int score;

        public Historia()
        {
            InitializeComponent();
            btnSair.Visible = false;
            btnVoltar.Visible = false;
            this.IniciaVetor();
        }

    
        private void IniciaVetor()
        {
            palavras = new String[15];
            dicas = new String[15];



            palavras[0] = "sabinada";
            dicas[0] = "movimento de revolta que eclodiu na bahia ";

            palavras[1] = "tordesilhas";
            dicas[1] = "tratado entre portugal e espanha para dividir a america do sul";

            palavras[2] = "monarquia";
            dicas[2] = "forma de governo liderada por um rei ou imperador";

            palavras[3] = "ribeirinho ";
            dicas[3] = "Habitante tradicional das margens dos rios";

            palavras[4] = "legislativo ";
            dicas[4] = "Um dos poderes do estado";

            palavras[5] = "executivo";
            dicas[5] = "Um dos poderes do estado";

            palavras[6] = "indigena ";
            dicas[6] = "Tipo de povos que viviam numa área geográfica antes da sua colonização";

            palavras[7] = "quilombolas";
            dicas[7] = "Habitantes de comunidades negras rurais formadas por \n descendentes de africanos escravizados";

            palavras[8] = "republica";
            dicas[8] = "forma de governo onde o chefe de estado é eleito pelo povo";

            palavras[9] = "salvador";
            dicas[9] = "primeira capital do brasil";

            palavras[10] = "renascimento";
            dicas[10] = "periodo artistico";

            palavras[11] = "romantismo";
            dicas[11] = "foi um movimento artistico";

            palavras[12] = "cabanagem";
            dicas[12] = "revolta popular e social ocorrida durante o Império do Brasil";

            palavras[13] = "balaiada";
            dicas[13] = "revolta popular mais longa e numerosa ocorrida no maranhão";

            palavras[14] = "rupestre";
            dicas[14] = "tipo de arte";



        }



        #region IniciaJogo
        private void IniciaJogo()
        {
            Random r = new Random();
            pospalavra = r.Next(0, 15);
            palavra = palavras[pospalavra];

            tela = "";

            for (int i = 0; i < palavra.Length; i++)
            {
                tela = tela + "#";
            }

            txbPalavra.Text = tela;
            lbDica.Text = dicas[pospalavra];
            tentativas = 6;
            lbTotalTentativas.Text = tentativas.ToString();
            lbtrestantes.Text = tentativas.ToString();
            txbDLetras.Text = "";

        }
        #endregion
        #region botao start
        private void btStart_Click(object sender, EventArgs e)
        {

            pnJogo.Visible = true;
            btStart.Visible = false;
            btnVoltar.Visible = true;
            btnSair.Visible = true;

            this.IniciaJogo();



        }
        #endregion
       




        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Escolha_De_Materia materia = new Escolha_De_Materia();
            this.Hide();
            materia.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Verifica2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || (e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txbLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verifica2(sender, e);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Char letra = '0';
            Boolean encontrou = false;

            if (txbDLetras.Text.Length <= 0)
            {

                txbDLetras.Text = txbDLetras.Text + " " + txbLetra.Text;
            }
            else
            {
                txbDLetras.Text = txbDLetras.Text + " " + txbLetra.Text;
            }
            try
            {
                letra = Convert.ToChar(txbLetra.Text);
                txbLetra.Focus();

            }
            catch
            {
                MessageBox.Show("É permitido apenas letras", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;


            }
            // int pletra = 0;
            String txt = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    encontrou = true;
                    // pletra = i;
                    txt = txt + txbLetra.Text;


                }
                else
                {
                    txt = txt + tela[i];
                }

            }
            tela = txt;
            txbPalavra.Text = tela;
            txbLetra.Clear();

            if (encontrou == false)
            {
                tentativas--;

            }



            lbtrestantes.Text = tentativas.ToString();

            if (txbPalavra.Text.IndexOf("#") == -1)
            {
                MessageBox.Show("Voce Acertou");
                score = score + 10;

                lblScore.Text = Convert.ToString(score);


                Random r = new Random();
                pospalavra = r.Next(0, 15);
                palavra = palavras[pospalavra];

                tela = "";

                for (int i = 0; i < palavra.Length; i++)
                {
                    tela = tela + "#";
                }

                txbPalavra.Text = tela;
                lbDica.Text = dicas[pospalavra];
                tentativas = 6;
                lbTotalTentativas.Text = tentativas.ToString();
                lbtrestantes.Text = tentativas.ToString();
                txbDLetras.Text = "";


            }


            if (tentativas <= 0)
            {
                MessageBox.Show("Voce Perdeu", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Escolha_De_Materia escolhademateria = new Escolha_De_Materia();
                this.Hide();
                escolhademateria.Show();

            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }

}