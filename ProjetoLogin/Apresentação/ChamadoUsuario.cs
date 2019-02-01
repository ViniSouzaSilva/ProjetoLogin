using MetroFramework;
using ProjetoLogin.Dal;
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
    public partial class ChamadoUsuario : Form
    {
        public String nome;
        public String id;

        public ChamadoUsuario()
        {
            InitializeComponent();
        }
    

        private void metroTile1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            this.Hide();
            telaPrincipal.ShowDialog();
            this.Close();
        }

        private void ChamadoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSetUsuario.chamado'. Você pode movê-la ou removê-la conforme necessário.
            this.chamadoTableAdapter.Fill(this.projetoLoginDataSetUsuario.chamado);
            LoginDalComandos login = new LoginDalComandos();
            linkLabel1.Text = "Seja Bem vindo, " + LoginDalComandos.usuarioConectado;

            nome = login.salvarcpf;

        }

        private void btnvoltartodoschamados_Click(object sender, EventArgs e)
        {

            ChamadoUsuario telaprincipal = new ChamadoUsuario();
            this.Hide();
            telaprincipal.ShowDialog();
            this.Close();
        }

        private void abrirChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirChamadoUsuario chamado = new AbrirChamadoUsuario();
            this.Hide();
            chamado.ShowDialog();
            this.Close();
        }

        private void alterarexcluirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarUsuario usuario = new TelaBuscarUsuario();
            this.Hide();
            usuario.ShowDialog();
            this.Close();
        }

        private void todosOsChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userdataGridView.Visible = true;
            meus_chamadosToolStrip1.Visible = true;
            label.Visible = true;
            label2.Visible = true;
            metroTile3.Visible = true;
            metroTile4.Visible = true;
            meus_chamadosToolStripButton1.PerformClick();

        }

        
        private void meus_chamadosToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDalComandos login = new LoginDalComandos();
                nomeToolStripTextBox1.Text = login.salvarcpf;
                this.chamadoTableAdapter.Meus_chamados(this.projetoLoginDataSetUsuario.chamado, nomeToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void meus_chamadosToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            LoginDalComandos login = new LoginDalComandos();
            nome = login.salvarcpf;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

            if (id != "" && id != null)
            {
                TelaInfoChamadoUsuario telaInfo = new TelaInfoChamadoUsuario(id);
                telaInfo.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Primeiro selecione o chamado desejado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            label.Text = userdataGridView["ID_chamado", e.RowIndex].Value.ToString();
            id = label.Text;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            ChamadoUsuario telaprincipal = new ChamadoUsuario();
            this.Hide();
            telaprincipal.ShowDialog();
            this.Close();
        }
    }
}
