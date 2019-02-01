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
    public partial class TelaInfoChamado : Form
    {
        public TelaInfoChamado()
        {
            InitializeComponent();
        }
        public TelaInfoChamado(string valor)
        {
            InitializeComponent();
            this.labelID.Text = valor;
            Controle controle = new Controle();
            String mensagem = controle.BuscarchamadopeloID(labelID.Text);
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

        

        

        private void btnexcluirchamado_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Deseja realmente encerrar o chamado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                labelID.Visible = false;
                label8.Visible = true;
                Controle controle = new Controle();
                String mensagem = controle.excluirchamadopeloID(label1.Text);

                String mensagemdt = controle.Gravar_dtexclusao(label1.Text);


                if (controle.mensagem != "")
                {


                    MetroMessageBox.Show(this, "Chamado encerrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    this.Close();
                }
            }
            else
            {
            }
        }

        private void TelaInfoChamado_Load(object sender, EventArgs e)
        {
            labelID.Visible = false;
            label8.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }

