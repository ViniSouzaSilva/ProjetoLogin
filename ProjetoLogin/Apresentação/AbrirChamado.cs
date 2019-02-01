using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ProjetoLogin.Modelo;
using MetroFramework;
using ProjetoLogin.Dal;

namespace ProjetoLogin.Apresentação
{
    public partial class AbrirChamado : Form
    {




        public AbrirChamado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXTdescricao.Text == "")
            {
                MessageBox.Show("Campos não podem ficar em branco");
            }
            else
            {

                Controle controle = new Controle();
                String mensagem = controle.cadastrarchamado(TXTcpf2.Text, TXTdescricao.Text, BOXcategoria.Text, TXTstatus.Text, TXBdata.Text);

                if (controle.tem)
                {


                    MetroMessageBox.Show(this, mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MetroMessageBox.Show(this, controle.mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//mensagem de erro
                }
                TelaChamado telainicial = new TelaChamado();
                this.Hide();
                telainicial.ShowDialog();
                this.Close();

            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            TelaChamado telainicial = new TelaChamado();
            this.Hide();
            telainicial.ShowDialog();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;

                MaximumSize = this.Size;
            }
            else
            {
                WindowState = FormWindowState.Normal;

                MinimumSize = this.Size;
            }
        }

        private void BOXtitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DTA_TextChanged(object sender, EventArgs e)
        {
            TXBdata.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }



        private void Abrirchamadoform_Load(object sender, EventArgs e)
        {
            LoginDalComandos login = new LoginDalComandos();
            TXTcpf2.Text = LoginDalComandos.userLogin;
            TXBdata.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TXTcpf2_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            TelaChamado telainicial = new TelaChamado();
            this.Hide();
            telainicial.ShowDialog();
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (TXTdescricao.Text == "")
            {
                MetroMessageBox.Show(this,"Campos não podem ficar em branco","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Controle controle = new Controle();
                String mensagem = controle.cadastrarchamado(TXTcpf2.Text, TXTdescricao.Text, BOXcategoria.Text, TXTstatus.Text, TXBdata.Text);

                if (controle.tem)
                {


                    MetroMessageBox.Show(this, mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MetroMessageBox.Show(this, controle.mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//mensagem de erro
                }
                TelaChamado telainicial = new TelaChamado();
                this.Hide();
                telainicial.ShowDialog();
                this.Close();


            }
        }

    }
}