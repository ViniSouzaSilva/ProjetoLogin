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
    public partial class TelaInfoChamadoUsuario : Form
    {
        public TelaInfoChamadoUsuario()
        {
            InitializeComponent();
        }
        public TelaInfoChamadoUsuario(string valor)
        {
            InitializeComponent();
            this.label8.Text = valor;
            Controle controle = new Controle();
            String mensagem = controle.BuscarchamadopeloID(label8.Text);
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
        private void TelaInfoChamadoUsuario_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            label17.Visible = true;
        }
    }
}
