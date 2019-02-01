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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (TXTcpf.Text == "" ||TXTnome.Text =="" ||TXTdepto.Text == "" ||TXTfone.Text =="" ||TXTemail.Text =="" ||TXTsenha.Text == "" ||TXTc_senha.Text =="" )
            {
                MetroMessageBox.Show(this, "Campos não podem ficar em branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(TXTmatricula.Visible == true)
            {
                if (TXTmatricula.Text == "")
                {
                    MetroMessageBox.Show(this, "Campos não podem ficar em branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    Controle controle = new Controle();


                    String mensagem = controle.cadastrar(TXTmatricula.Text, TXTnome.Text, TXTcpf.Text, TXTdepto.Text, TXTemail.Text, TXTsenha.Text, TXTc_senha.Text, TXTfone.Text);
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
            else
            {

                Controle controle = new Controle();


                String mensagem = controle.cadastrar(TXTmatricula.Text, TXTnome.Text, TXTcpf.Text, TXTdepto.Text, TXTemail.Text, TXTsenha.Text, TXTc_senha.Text, TXTfone.Text);
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

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load_1(object sender, EventArgs e)
        {

        }

        private void txtboxcadastrodepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TXTdepto.Text == "T.I")
            {

                TXTmatricula.Visible = true;
                label1.Visible = true;
            }
            else
            {
                TXTmatricula.Text = "Sem";
                TXTmatricula.Visible = false;
                label1.Visible = false;
             

            }
        }

     }
}
