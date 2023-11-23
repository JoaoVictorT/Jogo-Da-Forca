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
    public partial class Portugues : Form
    {
        

        private String[] palavras;
        private String[] dicas;
        private String palavra;
        private String tela;
        private int tentativas;
        private int pospalavra;
        private int score;
        public Portugues()
        { 
           

            InitializeComponent();
         
           
            btnSair.Visible = false;
            btnVoltar.Visible = false;
            this.IniciaVetor();
        }

    
        #region palavras e dicas
        private void IniciaVetor()
        {
            palavras = new String[15];
            dicas = new String[15];



            palavras[0] = "circunflexo";
            dicas[0] = "acento caracterizado como “chapeuzinho” ";

            palavras[1] = "aumentativo";
            dicas[1] = "da a noção de grande a uma palavra";

            palavras[2] = "diminutivo";
            dicas[2] = "da a noção de pequeno a uma palavra";

            palavras[3] = "alfabeto";
            dicas[3] = "Possui todas as letras do português";

            palavras[4] = "sinonimo";
            dicas[4] = "Palavra ou expressão que possui o mesmo significado que outra";

            palavras[5] = "antonimo";
            dicas[5] = "palavra ou expressão que possui o significado oposto que outra";

            palavras[6] = "informativo";
            dicas[6] = "Texto com informação sobre um determinado assunto";

            palavras[7] = "narrativo";
            dicas[7] = "Texto que mostra as açoes de personagens em tempo espaço";

            palavras[8] = "ortografia";
            dicas[8] = "parte da gramatica que ensina a escrever corretamente as palavras de uma lingua";

            palavras[9] = "onomatopeia ";
            dicas[9] = "figura de linguagem na qual se reproduz um som com um fonema ou palavra";

            palavras[10] = "substantivo";
            dicas[10] = "classe de palavras com que se atribui nome aos seres em geral";

            palavras[11] = "adjetivo";
            dicas[11] = "acrescenta uma qualidade ao substantivo";

            palavras[12] = "presente";
            dicas[12] = "Tempo verbal que ocorre no momento da fala";

            palavras[13] = "preterito";
            dicas[13] = "Tempo verbal que ocorre no momento antes da fala";

            palavras[14] = "descritivo";
            dicas[14] = "Texto que detalha bastante as caracteristicas de um\n lugar, acontecimento, pessoa, objeto ou animal";

            

        }


        #endregion
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
        #region botao identificar
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
            
        #endregion

        private void Portugues_Load(object sender, EventArgs e)
        {

        }

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

        private void pnJogo_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
