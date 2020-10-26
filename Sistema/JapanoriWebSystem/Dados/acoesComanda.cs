using JapanoriWebSystem.Dados;
using JapanoriWebSystem.Models;
using JapanoriWebSystem.Views.Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace JapanoriWebSystem.Dados
{
    public class acoesComanda
    {
        conexao con = new conexao();

        public List<modelComanda> BuscarComanda()
        {
            List<modelComanda> comList = new List<modelComanda>();

            MySqlCommand cmd = new MySqlCommand("select * from tbComanda", con.MyConectarBD());
           
            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);
            con.MyDesconectarBD();

            foreach (DataRow dr in dt.Rows)
            {
                comList.Add(
                    new modelComanda
                    {
                        idComanda = Convert.ToString(dr["idComanda"]),
                        situacaoComanda = Convert.ToString(dr["situacaoComanda"]),
                        statusComanda = Convert.ToString(dr["statusComanda"])
                    });
            }
            return comList;
        }

        public List<modelComanda> selecionarBuscaComanda(modelComanda cm)
        {
            
            List<modelComanda> comList = new List<modelComanda>();

            MySqlCommand cmd = new MySqlCommand("select * from tbComanda where idComanda=@idComanda", con.MyConectarBD());

            cmd.Parameters.Add("@idComanda", MySqlDbType.VarChar).Value = cm.idComanda;

            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);
            con.MyDesconectarBD();

            foreach (DataRow dr in dt.Rows)
            {
                comList.Add(
                    new modelComanda
                    {
                        idComanda = Convert.ToString(dr["idComanda"]),
                        situacaoComanda = Convert.ToString(dr["situacaoComanda"]),
                        statusComanda = Convert.ToString(dr["statusComanda"])
                    });
            }
            return comList;
        }

    }
}