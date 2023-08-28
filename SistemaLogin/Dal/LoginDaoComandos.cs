using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Dal {
    internal class LoginDaoComandos 
    {
        public bool tem = false;
        public string mensagem = "";
        
        SqlCommand cmd = new SqlCommand();
        Conexao con =new Conexao();
        SqlDataReader dr;


        public bool verificarLogin(string login, string senha) 
        {
            //comandos SQL para verificar se tem no banco

            cmd.CommandText = "select * from nomeDaTabela where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try 
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows) //se foi encontrado
                {
                    tem = true;
                }

            } 
            catch (SqlException) 
            {

                this.mensagem = "Erro com o Banco de Dados!";
            }

            return tem;
        }

        public string cadastrar(string email, string senha, string confirmarSenha) 
        {
            //comandos para inserir
            return mensagem;
        }
    }
}
