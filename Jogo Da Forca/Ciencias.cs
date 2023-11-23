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
    public partial class Ciencias : Form
    {
        private String[] palavras;
        private String[] dicas;
        private String palavra;
        private String tela;
        private int tentativas;
        private int pospalavra;
        private int score;
        public Ciencias()
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



            palavras[0] = "capivara";
            dicas[0] = "maior mamífero roedor do mundo";

            palavras[1] = "mamifero";
            dicas[1] = "classe de animais vertebrados";

            palavras[2] = "cachorro";
            dicas[2] = "é um animal doméstico";

            palavras[3] = "melancia";
            dicas[3] = "Fruta ricas em vitaminas e minerais";

            palavras[4] = "hipopotamo";
            dicas[4] = "mamífero herbívoro que vive na África";

            palavras[5] = "anfibios";
            dicas[5] = "classe de animais vertebrados de pele lisa sem escamas";

            palavras[6] = "serpente";
            dicas[6] = "animal da classe dos répteis ";

            palavras[7] = "carnivoro";
            dicas[7] = "animais que se alimentam de carnes";

            palavras[8] = "herbivoro";
            dicas[8] = "animais que se alimentam de vegetais";

            palavras[9] = "elefante";
            dicas[9] = "maior mamífero terrestre";

            palavras[10] = "ariranha";
            dicas[10] = "Mamífero conhecida como lontra-gigante";

            palavras[11] = "jaguatirica";
            dicas[11] = "Mamífero da família dos felinos";

            palavras[12] = "seringueira";
            dicas[12] = "arvore utilizada para a produçao de borracha";

            palavras[13] = "mercurio";
            dicas[13] = "Primeiro planeta mais próximo do sol";

            palavras[14] = "Fotossintese";
            dicas[14] = "Forma de alimentação da planta";



        }

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

        private void Ciencias_Load(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            pnJogo.Visible = true;
            btStart.Visible = false;
            btnVoltar.Visible = true;
            btnSair.Visible = true;

            this.IniciaJogo();
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

    }
}
