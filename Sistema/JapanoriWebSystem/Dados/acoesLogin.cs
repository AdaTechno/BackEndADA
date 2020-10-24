using JapanoriWebSystem.Models;
using JapanoriWebSystem.Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using JapanoriWebSystem.Views.Dados;

namespace JapanoriWebSystem.Dados
{
    public class acoesLogin
    {
        conexao con = new conexao();

        public void inserirLogin(modelLogin cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tblogin values(@usuario, @senha, @perm)", con.MyConectarBD());

            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = cm.usuario;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = cm.senha;
            cmd.Parameters.Add("@perm", MySqlDbType.VarChar).Value = cm.perm;

            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }


        public void TestarUsuario(modelLogin user)
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbLogin where usuario = @usuario and senha = @senha", con.MyConectarBD());
            
            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = user.usuario;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = user.senha;

            MySqlDataReader leitor;

            leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    {
                        user.usuario = Convert.ToString(leitor["usuario"]);
                        user.senha = Convert.ToString(leitor["senha"]);
                        user.perm = Convert.ToString(leitor["perm"]);
                    }
                }
            }

            else
            {
                user.usuario = null;
                user.senha = null;
                user.perm = null;
            }

            con.MyDesconectarBD();
        }
    }
}
