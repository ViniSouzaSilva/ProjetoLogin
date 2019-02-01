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
    public partial class TelaBuscarUsuarioADM : Form
    {
        public TelaBuscarUsuarioADM()
        {
            InitializeComponent();
        }


        private void btnbuscarusuario_Click(object sender, EventArgs e)
        {

            if (maskedTextBox1.Text == "   .   .   -")
            {
                MetroMessageBox.Show(this, "Campos não pode ficar em branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Controle controle = new Controle(); // instancia o objeto da classe controle
                String mensagem = controle.BuscarUsuario(maskedTextBox1.Text);//Mensagem vai receber o retorno do metodo Buscarusuario que vai receber como parametro o cpf digitado no textbox
                if (controle.mensagem != "")
                {
                    textBox4.Visible = true;
                    label5.Visible = true;

                    maskedTextBox1.Text = controle.conteudobuscacpf;
                    textBox2.Text = controle.conteudonome;
                    TXTbuscadepto.Text = controle.conteudodepto;
                    textBox3.Text = controle.conteudoemail;
                    textBox4.Text = controle.conteudomatricula;
                    if (controle.conteudodepto == "T.I")
                    {
                        textBox4.Visible = true;
                        label5.Visible = true;
                    }
                    if (controle.conteudomatricula == "Sem")
                    {
                        textBox4.Visible = false;
                        label5.Visible = false;

                    }
                    textBox5.Text = controle.conteudosenha;
                    maskedTextBox2.Text = controle.conteudotelefone;
                    if (controle.conteudobuscacpf != "")
                    {
                        maskedTextBox1.ReadOnly = true;
                    }
                    if (controle.mensagem == "CPF não cadastrado")
                    {
                        MetroMessageBox.Show(this, mensagem, "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        maskedTextBox1.ReadOnly = false;
                    }



                }
            }
        }

        private void TelaBuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "   .   .   -")
            {
                MetroMessageBox.Show(this, "Digite um CPF válido", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (MetroMessageBox.Show(this, "Deseja realmente excluir o usuário?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Controle controle = new Controle();
                    String mensagem = controle.ExcluirUsuarioPeloCpf(maskedTextBox1.Text);
                    if (controle.mensagem != "")
                    {
                        MetroMessageBox.Show(this, mensagem, "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information); 
    
                    maskedTextBox1.Text = "";
                        textBox2.Text = "";
                        TXTbuscadepto.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        maskedTextBox2.Text = "";
                        textBox4.Text = "";
                        maskedTextBox1.ReadOnly = false;
                        textBox4.Visible = true;
                        label5.Visible = true;
                    }
                    else
                    {
                        maskedTextBox1.Text = "";
                        textBox2.Text = "";
                        TXTbuscadepto.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        maskedTextBox2.Text = "";
                        textBox4.Text = "";
                        maskedTextBox1.ReadOnly = false;
                        textBox4.Visible = true;
                        label5.Visible = true;
                    }
                }
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            TelaChamado telainicial = new TelaChamado();
            this.Hide();
            telainicial.ShowDialog();
            this.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "As alterações entrarão em vigor assim que efetuar o login novamente.", "Salvar alterações?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (maskedTextBox1.Text == "" || textBox2.Text == "" || TXTbuscadepto.Text == "" || textBox3.Text == "" || textBox5.Text == "")
                {
                    MetroMessageBox.Show(this,"Campos não podem ficar em braco!" , "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    Controle controle = new Controle();


                    String mensagem = controle.AtualizarDadosUsuario(maskedTextBox1.Text, textBox2.Text, TXTbuscadepto.Text, textBox3.Text, textBox5.Text, maskedTextBox2.Text, textBox4.Text);
                    if (controle.tem)
                    {
                        MetroMessageBox.Show(this, mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        maskedTextBox1.Text = "";
                        textBox2.Text = "";
                        TXTbuscadepto.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        maskedTextBox2.Text = "";
                        textBox4.Text = "";
                        maskedTextBox1.ReadOnly = false;
                        textBox4.Visible = true;
                        label5.Visible = true;




                    }
                    else
                    {
                        MetroMessageBox.Show(this, controle.mensagem);//mensagem de erro
                    }
                }
            }

        }

        private void TXTbuscadepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TXTbuscadepto.Text == "T.I")
            {

                textBox4.Visible = true;
                label5.Visible = true;
            }
            else
            {
                
                textBox4.Visible = false;
                label5.Visible = false;


            }
        }
    }
}
