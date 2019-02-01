using MetroFramework;
using ProjetoLogin.Apresentação;
using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLogin
{

    public partial class TelaPrincipal : Form


    {
        
    
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (TXTlogin.Text == "")
            {
                TXTlogin.Mask = "999,999,999-99";
            }
            else
            {
                
                TXTlogin.Mask = "";
            }
        }

        
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();

        }

        private void btnsair_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(TXTlogin.Text, TXTsenha.Text, TXTlogin.Text);
            if (controle.mensagem != "")
            {
             


                if (controle.tem)
                {

                    TelaChamado logado = new TelaChamado();
                    this.Hide();
                    logado.Show();
                }

                else if (controle.gui)// nova parte
                {
                    ChamadoUsuario chamado = new ChamadoUsuario();
                    this.Hide();
                    chamado.Show();
                }//
                else
                {
                    MetroMessageBox.Show(this, "Erro, verifique o login e senha", "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
            }

            else
            {
                MetroMessageBox.Show(this, controle.mensagem);
            }
        }
        private void TXTlogin_Click(object sender, EventArgs e)
        {
            
                
            

        }

        private void txtboxsenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnentrar_Click(sender, e);
            }
        }

        private void txtboxloginmatricula_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtboxsenha_Click(sender, e);
            }
        }

        private void txtboxsenha_Click(object sender, EventArgs e)
        {

        }

        private void TXTlogin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            TXTlogin.Mask = "";
            
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Para alterações de senha, entre em contato com o número (11) 1234-5678", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
