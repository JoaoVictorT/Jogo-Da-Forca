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
    public partial class Escolha_De_Materia : Form
    {
        Form1 instanciaDoForm1;



        public Escolha_De_Materia(Form1 frm1)
        {

            InitializeComponent();
            instanciaDoForm1 = frm1;
            lblUsuario.Text = instanciaDoForm1.txtUsuario.Text.Split('.')[0];

            
        }

        
        public Escolha_De_Materia()
        {
            InitializeComponent();
        }

        private void Escolha_De_Materia_Load(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Portugues portugues = new Portugues();
            this.Hide();
            portugues.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Historia historia = new Historia();
            this.Hide();
            historia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Geografia geografia = new Geografia();
            this.Hide();
            geografia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ciencias ciencias = new Ciencias();
            this.Hide();
            ciencias.Show();
        }

        
    }
}
