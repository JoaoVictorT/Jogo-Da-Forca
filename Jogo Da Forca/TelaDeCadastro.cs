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
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        private void TelaDeCadastro_Load(object sender, EventArgs e)
        {

        }

        private void Verifica(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 44 || e.KeyChar == 45 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        private void Verifica2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 45 || (e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtCadastroUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verifica2(sender, e);


        }

        private void txtCadastroSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verifica(sender, e);
        }

        private void txtCadastroSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string cadastroJaFeito = @"C:\\Jogo_Da_Forca\\Banco_de_Dados\\Usuarios\\" + txtCadastroUsuario.Text + ".txt";
            if (File.Exists(cadastroJaFeito) || txtCadastroUsuario.Text == "" || txtCadastroSenha.Text == "")
            {


                MessageBox.Show("Já existe esse cadastro ou tem algum espaço em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                
                using (StreamWriter cadastroDoUsuario = new StreamWriter(@"C:\\Jogo_Da_Forca\\Banco_de_Dados\\Usuarios\\" + txtCadastroUsuario.Text + ".txt", true))
                {
                    cadastroDoUsuario.WriteLine(txtCadastroSenha.Text);
                }

                MessageBox.Show("Cadastrado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Form1 telaDeLogin = new Form1();
                this.Hide();
                telaDeLogin.Show();
            }
            
        }
    }
}
