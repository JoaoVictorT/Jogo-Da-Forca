namespace Jogo_Da_Forca
{
    partial class Portugues
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
            this.pnJogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txbDLetras = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbDica = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btOk = new System.Windows.Forms.Button();
            this.txbLetra = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbtrestantes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotalTentativas = new System.Windows.Forms.Label();
            this.txbPalavra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnJogo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnJogo
            // 
            this.pnJogo.Controls.Add(this.label2);
            this.pnJogo.Controls.Add(this.lblScore);
            this.pnJogo.Controls.Add(this.groupBox5);
            this.pnJogo.Controls.Add(this.groupBox4);
            this.pnJogo.Controls.Add(this.groupBox3);
            this.pnJogo.Controls.Add(this.groupBox2);
            this.pnJogo.Controls.Add(this.groupBox1);
            this.pnJogo.Controls.Add(this.txbPalavra);
            this.pnJogo.Controls.Add(this.label1);
            this.pnJogo.Location = new System.Drawing.Point(12, 12);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(701, 418);
            this.pnJogo.TabIndex = 0;
            this.pnJogo.Visible = false;
            this.pnJogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnJogo_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(4, 54);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txbDLetras);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(58, 205);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(620, 86);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Letras usadas";
            // 
            // txbDLetras
            // 
            this.txbDLetras.Enabled = false;
            this.txbDLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDLetras.Location = new System.Drawing.Point(10, 29);
            this.txbDLetras.Name = "txbDLetras";
            this.txbDLetras.Size = new System.Drawing.Size(604, 31);
            this.txbDLetras.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbDica);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(58, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(620, 69);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dica:";
            // 
            // lbDica
            // 
            this.lbDica.AutoSize = true;
            this.lbDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDica.Location = new System.Drawing.Point(6, 24);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(41, 20);
            this.lbDica.TabIndex = 0;
            this.lbDica.Text = "Dica";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btOk);
            this.groupBox3.Controls.Add(this.txbLetra);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(52, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 113);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escreva uma letra";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(6, 75);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(385, 33);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "Identificar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txbLetra
            // 
            this.txbLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLetra.Location = new System.Drawing.Point(6, 30);
            this.txbLetra.MaxLength = 1;
            this.txbLetra.Name = "txbLetra";
            this.txbLetra.Size = new System.Drawing.Size(385, 29);
            this.txbLetra.TabIndex = 0;
            this.txbLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLetra_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbtrestantes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(455, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 55);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tentativas Restantes";
            // 
            // lbtrestantes
            // 
            this.lbtrestantes.AutoSize = true;
            this.lbtrestantes.Location = new System.Drawing.Point(87, 25);
            this.lbtrestantes.Name = "lbtrestantes";
            this.lbtrestantes.Size = new System.Drawing.Size(20, 24);
            this.lbtrestantes.TabIndex = 0;
            this.lbtrestantes.Text = "6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotalTentativas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(456, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total de Tentativas";
            // 
            // lbTotalTentativas
            // 
            this.lbTotalTentativas.AutoSize = true;
            this.lbTotalTentativas.Location = new System.Drawing.Point(86, 25);
            this.lbTotalTentativas.Name = "lbTotalTentativas";
            this.lbTotalTentativas.Size = new System.Drawing.Size(20, 24);
            this.lbTotalTentativas.TabIndex = 0;
            this.lbTotalTentativas.Text = "6";
            // 
            // txbPalavra
            // 
            this.txbPalavra.Enabled = false;
            this.txbPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPalavra.Location = new System.Drawing.Point(52, 54);
            this.txbPalavra.Name = "txbPalavra";
            this.txbPalavra.Size = new System.Drawing.Size(626, 46);
            this.txbPalavra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifique a palavra";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 436);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(701, 60);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(64, 436);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(295, 60);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(366, 437);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(324, 59);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Portugues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 508);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pnJogo);
            this.Name = "Portugues";
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.Portugues_Load);
            this.pnJogo.ResumeLayout(false);
            this.pnJogo.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnJogo;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox txbPalavra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbLetra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbtrestantes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTotalTentativas;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txbDLetras;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
    }
}