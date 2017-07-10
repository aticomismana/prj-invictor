using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_invictor.Models
{
    class Login : Usuario
    {


        public void AutenticarUsuario(String email, String senha)
        {
            string banco = "";
            banco = "";

            SqlConnection cx = new SqlConnection();
            cx.ConnectionString = banco;
            cx.Open();

            DataTable dtEmail = new DataTable();
            DataTable dtSenha = new DataTable();

            string sql = "";
            sql += " SELECT Usuario FROM Usuarios ";
            sql += " WHERE Usuario = '" + email + "' ";

            string sql2 = "";
            sql2 += " SELECT Senha FROM Usuarios ";
            sql2 += " WHERE Senha = '" + senha + "' ";

            SqlDataAdapter daEmail = new SqlDataAdapter(sql, cx);
            daEmail.Fill(dtEmail);

            SqlDataAdapter daSenha = new SqlDataAdapter(sql2, cx);
            daSenha.Fill(dtSenha);

            if (dtEmail.Rows.Count != 1 && dtSenha.Rows.Count == 1)
            {
                Console.WriteLine("Introduza um Usuário válido!");
            }
            else if (dtEmail.Rows.Count == 1 && dtSenha.Rows.Count != 1)
            {
                Console.WriteLine("Introduza uma Senha válida!");
            }
            else if (dtEmail.Rows.Count != 1 || dtSenha.Rows.Count != 1)
            {
                Console.WriteLine("Introduza um Usuário válido!");
                Console.WriteLine("Introduza uma Senha válida!");
            }
            else
            {
                Console.WriteLine("Usuário e Senha válidas");
                Console.WriteLine("Usuário Conectado");

            }
        }

        public void Recuperar(String token)
        {

        }

        public Sessao criarSessao(Usuario usuario)
        {
            Sessao sessao = new Sessao();
            sessao.Usuario = usuario;
            return sessao;

        }
    }
}
