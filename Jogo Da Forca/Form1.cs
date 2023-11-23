using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jogo_Da_Forca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Jogo_Da_Forca\Banco_de_Dados\Usuarios");
       
        if(d.Exists)
        {
            DirectoryInfo listapasta = new DirectoryInfo(@"C:\Jogo_Da_Forca\Banco_de_Dados\Usuarios");
            FileInfo[] arq = listapasta.GetFiles("*.txt*");
            foreach (FileInfo fi in arq)
            {

                    txtUsuario.Items.Add(fi.Name.Split('.').FirstOrDefault());
                }
         

        }else{
            d.Create();
        }
       
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string senha;
            string senha2;
            string[] buscasenha;
            int linha = 1;
            senha2 = txtSenha.Text;
            string nome;

            try
            {
                string caminhoArquivo = @"C:\Jogo_Da_Forca\Banco_de_Dados\Usuarios\" + txtUsuario.Text + ".txt";

                if (File.Exists(caminhoArquivo))
                {
                    buscasenha = File.ReadAllLines(caminhoArquivo);
                    senha = buscasenha[linha - 1];
                    if (senha2 == senha)
                    {


                        Escolha_De_Materia escolhademateria = new Escolha_De_Materia(this);
                        this.Hide();
                        escolhademateria.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            catch (Exception ex)
            {
                // Outros erros possíveis
                MessageBox.Show("Usuário ou senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnIrCadastrar_Click(object sender, EventArgs e)
        {
            TelaDeCadastro telaDeCadastro = new TelaDeCadastro();
            this.Hide();
            telaDeCadastro.Show();
        }

    }
}
