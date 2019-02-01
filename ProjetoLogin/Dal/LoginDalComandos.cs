using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MetroFramework;
using System.Windows.Forms;
using ProjetoLogin.Modelo;

namespace ProjetoLogin.Dal
{
    class LoginDalComandos
    {
        public static string usuarioConectado; // Recebe um nome do metodo verificarlogin
        public String salvarcpf = userLogin;
        public static string userLogin;//Recebe um cpf do metodo verificarlogin
        public static string IdChamado;
        public bool tem = false;
        public bool gui = false;
        //------------------------------------------------------------------------------------------
        public String conteudoID;           //Inicio das variáveis que irão receber o conteúdo das linhas, da tabela chamado
        public String conteudodescricao;   //
        public String conteudocategoria;  //
        public String conteudostatus;    //
        public String conteudodata;     //
        public String conteudotipo;    //
        public String conteudocpf;    // 
        public String mensagem;      //
        public String conteudodataF;//FIM
        //------------------------------------------------------------------------------------------
        public String conteudobuscacpf;       //Inicio das variáveis que irão receber o conteúdo das linhas, da tabela cadastro
        public String conteudonome;          //
        public String conteudoemail;        //
        public String conteudodepto;       //
        public String conteudomatricula;  //
        public String conteudosenha;     //
        public String conteudotelefone; //FIM
        //-------------------------------------------------------------------------------------------
        SqlCommand cmd = new SqlCommand();//Objeto para manipulação de dados no SQL
        Conexao con = new Conexao();//Objeto para conexão com banco de dados 
        SqlDataReader DataReader;//Objeto para leitura de dados das tabelas no SQL
        SqlDataReader Reader; //Objeto para manipulação de dados no SQL
        SqlCommand cmdo = new SqlCommand();
        Conexao conn = new Conexao();
        

        //Classe de verificação para trazer os dados de cpf e nome e adicionar as variáveis userLogin e usuarioConectado
        public bool verificarlogin(String matricula, String senha)
        {
            cmd.CommandText = "select * from cadastro where matricula = @matricula and senha = @senha "; // comandos SQL para trazer todas as informações de um registro obedecendo a condição de usuário e senha digitados
            cmd.Parameters.AddWithValue("@matricula", matricula);//Adiciona o valor recebido pela assinatura a uma variavel no SQL
            cmd.Parameters.AddWithValue("@senha", senha);//Adiciona o valor recebido pela assinatura a uma variavel no SQL


            try
            {

                cmd.Connection = con.Conectar();// Utiliza o metodo conectar da classe de conexão para estabelecer uma conexão com banco
                var DataReader = cmd.ExecuteReader();//Executa a leitura dos dados retornados do sql



                if (DataReader.Read())//Caso a leitura tenha sido efetuada
                {
                    userLogin = DataReader["cpf"].ToString();//Adiciona o valor do campo cpf para a variavel userLogin
                    usuarioConectado = DataReader["nome"].ToString();//Adiciona o valor do campo nome para a variavel usuarioConectado

                    if (DataReader.HasRows)//Se o Dados existirem no banco de dados 
                    {

                        tem = true;

                    }
                }
                con.desconectar();//Desconecta o banco de dados
                DataReader.Close();//Desconecta o leitor de dados 
            }
            catch (SqlException)//Em caso de alguma inconsistência aparecer na consulta
            {
                this.mensagem = "Erro com Banco de Dados";//Essa será a mensagem que apaecerá na tela 




            }
            return tem;
        }


        //Classe de verificação para trazer os dados de cpf e nome e adicionar as variáveis userLogin e usuarioConectado
        public bool verificarUser(String cpf, String senha)

        // vai ao banco de dados, verifica se tem o e-mail e senha digitado e retornar em booleano, se true existe a informação, se false não deixará logar e apresentará uma mensagem
        {
            // comandos sql para verificar se tem no banco


            cmdo.CommandText = "select * from cadastro where cpf = @cpf and senha = @senha";
            cmdo.Parameters.AddWithValue("@cpf", cpf);
            cmdo.Parameters.AddWithValue("@senha", senha);


            try
            {

                cmdo.Connection = conn.Conectar();
                var Reader = cmdo.ExecuteReader();



                if (Reader.Read())
                {
                    userLogin = Reader["cpf"].ToString();
                    usuarioConectado = Reader["nome"].ToString();

                    if (Reader.HasRows)
                    {

                        gui = true;

                    }
                }
                conn.desconectar();
                Reader.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";




            }
            return gui;
        }
        //Metodo de cadastrar usuários 
        public String cadastrar(String matricula, String nome, String cpf, String depto, String email, String senha, String confSenha, String telefone)
        {
            tem = false;
            //comandos para inserir
            if (senha == confSenha)// Se os campos senha e confSenha estiverem iguais 
            {
                cmd.CommandText = "INSERT INTO cadastro(matricula,nome,cpf,depto,email,senha,telefone)"
                       + "VALUES(@matricula,@nome,@cpf,@depto,@email,@senha,@telefone)";// CommandText permite escrever na linguagem do banco de dados

                cmd.Parameters.AddWithValue("@matricula", matricula);            //Adiciona o valor recebido pela assinatura, a uma variavel no SQL  
                cmd.Parameters.AddWithValue("@nome", nome);                     //
                cmd.Parameters.AddWithValue("@cpf", cpf);                      //
                cmd.Parameters.AddWithValue("@depto", depto);                 //
                cmd.Parameters.AddWithValue("@email", email);                //
                cmd.Parameters.AddWithValue("@senha", senha);               //
                cmd.Parameters.AddWithValue("@telefone", telefone);        // FIM
                try
                {

                    cmd.Connection = con.Conectar();//Abre a conexão com Banco de Dados
                    cmd.ExecuteNonQuery();//Executa a query criada acima 
                    con.desconectar();//Fecha conexão com BD
                    this.mensagem = "Cadastrado com sucesso!" + LoginDalComandos.IdChamado;//Mensagem de sucesso

                    tem = true;

                }
                catch (SqlException)//Em caso de alguma inconsistência aparecer na consulta
                {
                    this.mensagem = "CPF já cadastrado";//Em caso de problema em algum metodo do try, receberá essa mensagem

                }
            }
            else// Se os campos senha e confSenha não estiverem iguais
            {
                this.mensagem = "Senhas não correspondem";
            }
            return mensagem;
        }
        //Atualiza os dados do cadastro do usuário
        public String AtualizarDadosUsuario(String cpf, String nome, String depto, String email, String senha, String telefone, String matricula)
        {
            tem = false;
            cmd.CommandText = "UPDATE cadastro SET nome = @nome , depto = @depto , email = @email , senha = @senha , telefone = @telefone, matricula = @matricula where cpf = @cpf";// CommandText permite escrever na linguagem do banco de dados  
            cmd.Parameters.AddWithValue("@nome", nome);                         //Adiciona o valor recebido pela assinatura, a uma variavel no SQL  
            cmd.Parameters.AddWithValue("@cpf", cpf);                          //
            cmd.Parameters.AddWithValue("@depto", depto);                     //
            cmd.Parameters.AddWithValue("@email", email);                    //
            cmd.Parameters.AddWithValue("@senha", senha);                   //
            cmd.Parameters.AddWithValue("@telefone", telefone);            //
            cmd.Parameters.AddWithValue("@matricula", matricula);         //FIM

            try
            {

                cmd.Connection = con.Conectar();//Abre a conexão com Banco de Dados
                cmd.ExecuteNonQuery();//Executa a query criada acima 
                con.desconectar();//Fecha conexão com BD
                this.mensagem = "Dados alterados com sucesso!" + LoginDalComandos.IdChamado;

                tem = true;

            }
            catch (SqlException)//Em caso de alguma inconsistência aparecer na consulta
            {
                this.mensagem = "CPF já cadastrado";//Em caso de problema em algum metodo do try, receberá essa mensagem

            }

            return mensagem;

        }
        //Cadastra os chamados pelo técnico e usuário
        public String cadastrarchamado(String cpf, String descricao, String categoria_chamado, String tipo_chamado, String DT_abertura)
        {
            tem = false;

            bool status_chamado = true;// coloca no BD como chamado ativo


            //comandos para inserir

            {

                cmd.CommandText = "INSERT INTO chamado (cpf,descricao,categoria_chamado,DT_abertura,tipo_chamado,status_chamado)"
                     + "VALUES(@cpf,@descricao, @categoria_chamado,@DT_abertura,@tipo_chamado,@status_chamado)"; // CommandText permite escrever na linguagem do banco de dados

                cmd.Parameters.AddWithValue("@cpf", cpf);                                   //Adiciona o valor recebido pela assinatura, a uma variavel no SQL  
                cmd.Parameters.AddWithValue("@descricao", descricao);                      //
                cmd.Parameters.AddWithValue("@categoria_chamado", categoria_chamado);     //
                cmd.Parameters.AddWithValue("@DT_abertura", DT_abertura);                //
                cmd.Parameters.AddWithValue("@tipo_chamado", tipo_chamado);             //
                cmd.Parameters.AddWithValue("@status_chamado", status_chamado);        //FIM




                try
                {

                    cmd.Connection = con.Conectar();//Abre a conexão com Banco de Dados
                    cmd.ExecuteNonQuery();//Executa a query criada acima 
                    con.desconectar();//Fecha conexão com BD
                    this.mensagem = "Chamado realizado com sucesso!!!";

                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados";//Em caso de problema em algum metodo do try, receberá essa mensagem

                }


                return mensagem;
            }
        }
        //Busca no banco todos os dados do chamado com determidado ID
        public String BuscarchamadopeloID(String ID_chamado)
        {
            cmd.CommandText = "select * from chamado where ID_chamado = @ID_chamado";
            cmd.Parameters.AddWithValue("@ID_chamado", ID_chamado);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                DataReader = cmd.ExecuteReader();

                if (DataReader.HasRows)

                {
                    tem = true;
                    if (tem == true)
                    {
                        while (DataReader.Read())
                        {
                            conteudoID = DataReader["ID_chamado"].ToString();                // INICIO -- Atribuição do valor de cada campo a cada variavel
                            conteudodescricao = DataReader["descricao"].ToString();         //
                            conteudocategoria = DataReader["categoria_chamado"].ToString();//
                            conteudostatus = DataReader["status_chamado"].ToString();     //
                            conteudodata = DataReader["DT_abertura"].ToString();         //
                            conteudotipo = DataReader["tipo_chamado"].ToString();       //
                            conteudocpf = DataReader["cpf"].ToString();                //
                            conteudodataF = DataReader["DT_fechamento"].ToString();   //FIM
                        }
                        this.mensagem = conteudoID;
                    }

                }


                con.desconectar();
                DataReader.Close();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";




            }
            return mensagem;

        }

        //Inativa os chamados através do ID 
        public String excluirchamadopeloID(String ID_chamado)
        {
            bool status_chamado = false;// coloca no BD como chamado

            cmd.CommandText = "UPDATE chamado SET status_chamado = @status_chamado where id_chamado = @ID_chamado";
            cmd.Parameters.AddWithValue("@ID_chamado", ID_chamado);
            cmd.Parameters.AddWithValue("@status_chamado", status_chamado);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                conteudostatus = "False";
                this.mensagem = "Excluído com sucesso";


            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";




            }

            return mensagem;

        }
        public String Gravar_dtexclusao(String ID_chamado)
        {
            String DT_fechamento = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            cmd.CommandText = "UPDATE chamado SET DT_fechamento = @DT_fechamento where id_chamado = @ID_chamado";
            cmd.Parameters.AddWithValue("@ID_chamado", ID_chamado);
            cmd.Parameters.AddWithValue("@DT_fechamento", DT_fechamento);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Excluído com sucesso";



            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";




            }

            return mensagem;


        }


        public String BuscarUsuario(String cpf)

        {
            // comandos sql para verificar se tem no banco


            cmd.CommandText = "select * from cadastro where cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                DataReader = cmd.ExecuteReader();

                if (DataReader.HasRows)

                {
                    tem = true;
                    if (tem == true)
                    {
                        while (DataReader.Read())
                        {
                            conteudobuscacpf = DataReader["cpf"].ToString();                 // INICIO -- Atribuição do valor de cada campo a cada variavel
                            conteudonome = DataReader["nome"].ToString();                   //
                            conteudoemail = DataReader["email"].ToString();                //
                            conteudodepto = DataReader["depto"].ToString();               //
                            conteudomatricula = DataReader["matricula"].ToString();       //
                            conteudosenha = DataReader["senha"].ToString();             //
                            conteudotelefone = DataReader["telefone"].ToString();      //
                                                                                       //FIM
                        }

                    }

                }
                else
                {
                    this.mensagem = "CPF não cadastrado";
                }


                con.desconectar();
                DataReader.Close();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";




            }
            return mensagem;

        }
        public String ExcluirUsuarioPeloCpf(String cpf)

        // vai ao banco de dados, verifica se tem o e-mail e senha digitado e retornar em booleano, se true existe a informação, se false não deixará logar e apresentará uma mensagem
        {

            cmd.CommandText = "DELETE FROM cadastro WHERE cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Excluído com sucesso";


            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";




            }

            return mensagem;

        }

        public String AtribuirChamado(String id)
        {
            tem = false;
            String atribuicao = usuarioConectado;
            cmd.CommandText = "UPDATE chamado SET atribuicao = @atribuicao where ID_chamado = @id";// CommandText permite escrever na linguagem do banco de dados  
            cmd.Parameters.AddWithValue("@id", id);                         //Adiciona o valor recebido pela assinatura, a uma variavel no SQL  
            cmd.Parameters.AddWithValue("@atribuicao", atribuicao);                          //

            try
            {

                cmd.Connection = con.Conectar();//Abre a conexão com Banco de Dados
                cmd.ExecuteNonQuery();//Executa a query criada acima 
                con.desconectar();//Fecha conexão com BD
                this.mensagem = "Atribuido com sucesso!" + LoginDalComandos.IdChamado;

                tem = true;

            }
            catch (SqlException)//Em caso de alguma inconsistência aparecer na consulta
            {
                this.mensagem = "CPF já cadastrado";//Em caso de problema em algum metodo do try, receberá essa mensagem

            }

            return mensagem;

        }


    }
}

