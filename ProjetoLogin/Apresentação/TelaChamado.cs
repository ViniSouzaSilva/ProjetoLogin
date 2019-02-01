using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using ProjetoLogin;
using ProjetoLogin.Dal;
using ProjetoLogin.Modelo;
using ProjetoLogin.Apresentação;

namespace ProjetoLogin.Apresentação
{
    public partial class TelaChamado : Form
    {
        String cpf;
        public String id;


        public TelaChamado()
        {
            InitializeComponent();
        }

        private void abrirChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirChamado telaChamado = new AbrirChamado();
            this.Hide();
            telaChamado.ShowDialog();
            this.Close();

        }

        private void todosOsChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkLabel1.Visible = false;
            chamadoDataGridView.Visible = true;
            chamados_inativosToolStrip1.Visible = true;
            chamado_ativosToolStrip1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            metroTile2.Visible = true;
            metroTile4.Visible = true;
            metroTile3.Visible = true;
            


            /*TelaTodosChamados telaChamado = new TelaTodosChamados();
            this.Hide();
            telaChamado.ShowDialog();
            this.Close();*/
        }

        private void buscarChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telabuscarchamados buscar = new Telabuscarchamados();
            this.Hide();
            buscar.ShowDialog();
            this.Close();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSet.chamado'. Você pode movê-la ou removê-la conforme necessário.
            this.chamadoTableAdapter4.Fill(this.projetoLoginDataSet.chamado);


            LoginDalComandos login = new LoginDalComandos();
            linkLabel1.Text = "Seja Bem vindo, " + LoginDalComandos.usuarioConectado;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            this.Hide();
            telaPrincipal.ShowDialog();
            this.Close();


        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        

        private void alterarEExcluirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarUsuarioADM usuario = new TelaBuscarUsuarioADM();
            this.Hide();
            usuario.ShowDialog();
            this.Close();
        }

        private void chamadoDataGridView_ButtonColumnClick(object sender, DataGridViewButtonColumn e)
        {
            //DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
        }

        public void chamadoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            label1.Text = chamadoDataGridView["ID_chamado", e.RowIndex].Value.ToString();
            id = label1.Text;


        }

        public void metroTile2_Click(object sender, EventArgs e)
        {
            Controle atribuir = new Controle();
            atribuir.AtribuirChamado(id);
            this.chamadoTableAdapter4.Fill(this.projetoLoginDataSet.chamado);
            
        }

        private void chamados_inativosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.chamadoTableAdapter4.Chamados_inativos(this.projetoLoginDataSet.chamado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void chamado_ativosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.chamadoTableAdapter4.Chamado_ativos(this.projetoLoginDataSet.chamado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void chamado_ativosToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.chamadoTableAdapter4.Chamado_ativos(this.projetoLoginDataSet.chamado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void chamado_ativosToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.chamadoTableAdapter4.Chamado_ativos(this.projetoLoginDataSet.chamado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void chamados_inativosToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.chamadoTableAdapter4.Chamados_inativos(this.projetoLoginDataSet.chamado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (id != "" && id != null)
            {
                TelaInfoChamado telaInfo = new TelaInfoChamado(id);
                telaInfo.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Primeiro selecione o chamado desejado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            this.chamadoTableAdapter4.Fill(this.projetoLoginDataSet.chamado);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            TelaChamado telaprincipal = new TelaChamado();
            this.Hide();
            telaprincipal.ShowDialog();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
