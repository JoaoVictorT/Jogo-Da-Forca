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
    public partial class Geografia : Form
    {
        private String[] palavras;
        private String[] dicas;
        private String palavra;
        private String tela;
        private int tentativas;
        private int pospalavra;
        private int score;

        public Geografia()
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



            palavras[0] = "brasilia";
            dicas[0] = "Capital do brasil ";

            palavras[1] = "sudoeste";
            dicas[1] = "coordenada geografia que fica entre o sul e o oeste";

            palavras[2] = "maranhao";
            dicas[2] = "Estado da capital de São luís";

            palavras[3] = "montanha";
            dicas[3] = "Lugares altos rochosos";

            palavras[4] = "planicie";
            dicas[4] = "Grande territorio plano";

            palavras[5] = "cordilheira";
            dicas[5] = "Um conjunto montanhas";

            palavras[6] = "arquipelago";
            dicas[6] = "Conjunto de ilhas ou ilheus";

            palavras[7] = "antartida";
            dicas[7] = "continente mais frio do nosso planeta";

            palavras[8] = "noroeste";
            dicas[8] = "coordenada geografia que fica entre norte e o oeste";

            palavras[9] = "nordeste ";
            dicas[9] = "coordenada geografia que fica entre o norte e o leste";

            palavras[10] = "pecuaria";
            dicas[10] = "Atividade que envolve criação de gado";

            palavras[11] = "ferrovia";
            dicas[11] = "Sistema de transporte baseado em trens sobre trilhos";

            palavras[12] = "agricultura";
            dicas[12] = "Conjunto de técnicas utilizadas para cultivar plantas";

            palavras[13] = "desmatamento";
            dicas[13] = "Grave problema ambiental";

            palavras[14] = "extensiva";
            dicas[14] = "Tipo de agricultura pelo uso de técnicas tradicionais na produção";



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




        private void btStart_Click_1(object sender, EventArgs e)
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
