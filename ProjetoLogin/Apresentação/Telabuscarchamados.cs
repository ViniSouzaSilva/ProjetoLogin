using MetroFramework;
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
    public partial class Telabuscarchamados : Form
    {
        public Telabuscarchamados()
        {
            InitializeComponent();
        }
   

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.BuscarchamadopeloID(txtboxbuscaridchamado.Text);
            if (controle.mensagem != "")
            {
                label1.Text = controle.mensagem;
                label2.Text = controle.conteudodescricao;
                label3.Text = controle.conteudocategoria;
                label4.Text = controle.conteudostatus;
                label5.Text = controle.conteudodata;
                label6.Text = controle.conteudotipo;
                label7.Text = controle.conteudocpf;
                label16.Text = controle.conteudodataF;




            }

        }

        private void btnexcluirchamado_Click_1(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Deseja realmente excluir o chamado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Controle controle = new Controle();
                String mensagem = controle.excluirchamadopeloID(txtboxbuscaridchamado.Text);

                String mensagemdt = controle.Gravar_dtexclusao(txtboxbuscaridchamado.Text);


                if (controle.mensagem != "")
                {


                    MetroMessageBox.Show(this, mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            else
            {
            }

        }

        private void Telabuscarchamados_Load(object sender, EventArgs e)
        {
           
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            TelaChamado telaChamado = new TelaChamado();
            this.Hide();
            telaChamado.ShowDialog();
            this.Close();
        }
    }
}

