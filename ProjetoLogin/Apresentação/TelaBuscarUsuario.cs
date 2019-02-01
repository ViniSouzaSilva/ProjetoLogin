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
    public partial class TelaBuscarUsuario : Form
    {
        public TelaBuscarUsuario()
        {
            InitializeComponent();
        }

        private void TelaBuscarUsuario_Load(object sender, EventArgs e)
        {
            LoginDalComandos login = new LoginDalComandos();
            TXTBOXcpfusuario.Text = login.salvarcpf;
            Controle controle = new Controle();
            String mensagem = controle.BuscarUsuario(TXTBOXcpfusuario.Text);

            if (controle.mensagem != "")
            {
                TXTBOXmatricula.Visible = true;
                label5.Visible = true;

                TXTBOXcpfusuario.Text = controle.conteudobuscacpf;
                TXTBOXnome.Text = controle.conteudonome;
                TXTbuscadepto.Text = controle.conteudodepto;
                TXTBOXemail.Text = controle.conteudoemail;
                TXTBOXmatricula.Text = controle.conteudomatricula;
                if (controle.conteudomatricula == "Sem       ")
                {
                    TXTBOXmatricula.Visible = false;
                    label5.Visible = false;

                }
                TXTBOXsenha.Text = controle.conteudosenha;
                TXTBOXtelefone.Text = controle.conteudotelefone;
            }
        }

        private void btnbuscarusuario_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "(Ao salvar, você será redirecionado a tela de login)", "Salvar alterações?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (TXTBOXnome.Text == "" || TXTbuscadepto.Text == "" || TXTBOXtelefone.Text == "" || TXTBOXemail.Text == "" || TXTBOXsenha.Text == "")
                {
                    MessageBox.Show("campos não podem ficar em branco");
                }
                else
                {

                    Controle controle = new Controle();


                    String mensagem = controle.AtualizarDadosUsuario(TXTBOXcpfusuario.Text, TXTBOXnome.Text, TXTbuscadepto.Text, TXTBOXemail.Text, TXTBOXsenha.Text, TXTBOXtelefone.Text, TXTBOXmatricula.Text);
                    if (controle.tem)
                    {
                        MetroMessageBox.Show(this, mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TelaPrincipal telainicial = new TelaPrincipal();
                        this.Hide();
                        telainicial.Show();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, controle.mensagem);//mensagem de erro
                    }
                }
            }

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ChamadoUsuario voltar = new ChamadoUsuario();
            this.Hide();
            voltar.ShowDialog();
            this.Close();
        }
    }
    }
    
