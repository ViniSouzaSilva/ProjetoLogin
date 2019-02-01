using MetroFramework.Controls;
using ProjetoLogin.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool gui;
        public bool tem;
        public String mensagem = "";
                                              //Inicio das variáveis que irão receber o conteúdo das linhas, da tabela chamado que vem da classe logindalcomandos
        public String conteudodescricao;     //
        public String conteudocategoria;    //
        public String conteudostatus;      //
        public String conteudodata;       //
        public String conteudotipo;      //
        public String conteudodataF;     //
        public String conteudocpf;     // FIM
        //------------------------------------------------------------------------------------------------
        public String conteudobuscacpf;       //Inicio das variáveis que irão receber o conteúdo das linhas, da tabela cadastro
        public String conteudonome;          //
        public String conteudoemail;        //
        public String conteudodepto;       //
        public String conteudomatricula;  //
        public String conteudosenha;     //
        public String conteudotelefone; //FIM
        //------------------------------------------------------------------------------------------------
        public bool acessar(String matricula, String senha, String cpf)

        {
            LoginDalComandos logindao = new LoginDalComandos();//instanciamento 
            tem = logindao.verificarlogin(matricula, senha);
            gui = logindao.verificarUser(cpf, senha);

            if (logindao.mensagem != "")// verifica se existem mensagem de erro
                {
                    this.mensagem = logindao.mensagem;
                }
                
            
            return tem|gui;
        }

        public String cadastrar(String matricula, String nome, String cpf,String depto,String email,String senha, String confsenha,String telefone)

        {
            LoginDalComandos logindao = new LoginDalComandos();
            this.mensagem = logindao.cadastrar(matricula,nome,cpf,depto,email, senha, confsenha,telefone);// mensagem recebe todos os dados do método cadastrar 
            if (logindao.tem)// a mensagem que vai vir é de sucesso
            {
                this.tem = true;//valor true para dizer que foi cadastrado com sucesso

            }
            return mensagem;
        }
        public String AtualizarDadosUsuario(String cpf, String nome, String depto, String email, String senha, String telefone, String matricula)

        {
            LoginDalComandos logindao = new LoginDalComandos();
            this.mensagem = logindao.AtualizarDadosUsuario(cpf, nome, depto, email, senha, telefone, matricula);// mensagem recebe todos os dados do método cadastrar 
            if (logindao.tem)// a mensagem que vai vir é de sucesso
            {
                this.tem = true;//valor true para dizer que foi cadastrado com sucesso

            }
            return mensagem;
        }

        public String cadastrarchamado(String cpf, String descricao, String categoria_chamado, String tipo_chamado,String DT_abertura )
        {

            LoginDalComandos logindao = new LoginDalComandos();
           this.mensagem = logindao.cadastrarchamado(cpf,descricao,categoria_chamado, tipo_chamado, DT_abertura);// mensagem recebe todos os dados do método cadastrarchamado
            if (logindao.tem)// a mensagem que vai vir é de sucesso
            {
                this.tem = true;//valor true para dizer que foi cadastrado com sucesso

            }
            return mensagem;
        }
        public String BuscarchamadopeloID(String ID_chamado)
        {

            LoginDalComandos logindao = new LoginDalComandos();
            this.mensagem = logindao.BuscarchamadopeloID(ID_chamado);
            conteudodescricao = logindao.conteudodescricao;
            conteudocategoria = logindao.conteudocategoria;
            conteudostatus = logindao.conteudostatus;
            conteudodata = logindao.conteudodata;
            conteudotipo = logindao.conteudotipo;
            conteudocpf = logindao.conteudocpf;
            conteudodataF = logindao.conteudodataF;

            if (conteudostatus == "True")
            {
                conteudostatus = "ativo";
            }
            else
            {
                conteudostatus = "inativo";
            }
            if (logindao.tem)// a mensagem que vai vir é de sucesso
            {
                this.tem = true;

            }

            return mensagem;
        }
        public String excluirchamadopeloID(String ID_chamado)
        {

            LoginDalComandos logindao = new LoginDalComandos();
            this.mensagem = logindao.excluirchamadopeloID(ID_chamado);
            conteudodescricao = logindao.conteudodescricao;
            conteudocategoria = logindao.conteudocategoria;
            conteudostatus = logindao.conteudostatus;
            conteudodata = logindao.conteudodata;
            conteudotipo = logindao.conteudotipo;
            conteudocpf = logindao.conteudocpf;
            conteudodataF = logindao.conteudodataF;

            if (conteudostatus == "False")
            {
                mensagem = "Chamado excluído";
                conteudostatus = "Inativo";
            }
           
            if (logindao.tem)// a mensagem que vai vir é de sucesso
            {
                this.tem = true;

            }

            return mensagem;
        }

        public String Gravar_dtexclusao(String ID_chamado)
        {
            String DT_fechamento = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            
            LoginDalComandos logindao = new LoginDalComandos();
            this.mensagem = logindao.Gravar_dtexclusao(ID_chamado);
            


            if (logindao.tem)// a mensagem que vai vir é de sucesso
            {
                this.tem = true;

            }

            return mensagem;
        }
        public String BuscarUsuario(String CPF)
        {

            LoginDalComandos logindao = new LoginDalComandos();
            this.mensagem = logindao.BuscarUsuario(CPF);

            conteudobuscacpf = logindao.conteudobuscacpf;
            conteudonome = logindao.conteudonome;
            conteudoemail = logindao.conteudoemail;
            conteudodepto = logindao.conteudodepto;
            conteudomatricula = logindao.conteudomatricula;
            conteudosenha = logindao.conteudosenha;
            conteudotelefone = logindao.conteudotelefone;

            if (logindao.tem)// a mensagem que vai vir é de sucesso
            {
                this.tem = true;

            }

            return mensagem;
        }

        public String ExcluirUsuarioPeloCpf(String cpf)
        {

            LoginDalComandos logindao = new LoginDalComandos();
            this.mensagem = logindao.ExcluirUsuarioPeloCpf(cpf);
            
            if (logindao.tem)// a mensagem que vai vir é de sucesso
            {
                this.tem = true;

            }

            return mensagem;
        }

        public String AtribuirChamado(String id)
        {

            LoginDalComandos logindao = new LoginDalComandos();
            this.mensagem = logindao.AtribuirChamado(id);

            if (logindao.tem)// a mensagem que vai vir é de sucesso
            {
                this.tem = true;

            }

            return mensagem;
        }
    }
}
    

