using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjetoLogin.Dal
{
   public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-TM9NO2D\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True";
            //con.ConnectionString = @"Data Source=sql.hostlocation.com.br;Initial Catalog=hd-infinitysolutions;Persist Security Info=True;User ID=hd-infinitysolutions;Password=UniP1234";
            //con.ConnectionString = @"Initial Catalog = Help Desk(PIM); Integrated Security = True;";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
