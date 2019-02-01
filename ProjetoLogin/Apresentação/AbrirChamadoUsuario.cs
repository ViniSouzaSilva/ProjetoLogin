using MetroFramework;
using ProjetoLogin.Dal;
using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentação
{
    public partial class AbrirChamadoUsuario : Form
    {
        public AbrirChamadoUsuario()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ChamadoUsuario principal = new ChamadoUsuario();
            this.Hide();
            principal.ShowDialog();
            this.Close();
        }

        private void btnvoltartodoschamados_Click(object sender, EventArgs e)
        {
           
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
                    MetroMessageBox.Show(this, controle.mensagem);//mensagem de erro
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
            TelaChamado telainicial = new TelaChamado();
            this.Hide();
            telainicial.ShowDialog();
            this.Close();
        }

        private void AbrirChamadoUsuario_Load(object sender, EventArgs e)
        {
            LoginDalComandos login = new LoginDalComandos();
            TXTcpf2.Text = LoginDalComandos.userLogin;
            TXBdata.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TXTdescricao.Text == "")
            {

                MetroMessageBox.Show(this, "Campos não podem ficar em branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Controle controle = new Controle();
                String mensagem = controle.cadastrarchamado(TXTcpf2.Text, TXTdescricao.Text, BOXcategoria.Text, TXTstatus.Text, TXBdata.Text);

                if (controle.tem)
                {


                    MetroMessageBox.Show(this, mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

                else
                {
                    MetroMessageBox.Show(this, controle.mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//mensagem de erro
                }
                ChamadoUsuario telainicial = new ChamadoUsuario();
                this.Hide();
                telainicial.ShowDialog();
                this.Close();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TXTstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTdescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void BOXcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTcpf2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
