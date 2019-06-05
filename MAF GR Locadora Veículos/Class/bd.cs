using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MAF_GR_Locadora_Veículos
{
    class bd
    {
        //Atributos
        // https://auth-db137.weblink.com.br/ 
        protected string serv = "sql137.main-hosting.eu";
        protected string usuario = "u819008409_admin";
        protected string senha = "12345678";
        private string banco = "u819008409_ifsp";

        //Metodo construtor
        public bd()
        {
           
        }

        //Metodo string de conexão
        private string monta_string()
        {
            try
            {
                return "Persist security Info=False; server=" + this.serv + ";database=" + this.banco + ";uid=" + this.usuario + ";password=" + this.senha;
            }
            catch (Exception ex)
            {
                return "erro de coneccao";
            }
        }

        //Metodo de conexão
        public MySqlConnection conecta()
        {
            MySqlConnection con = new MySqlConnection(this.monta_string());

            con.Open();

            return con;
        }

        //Metodo de desconexão
        public void desconecta(MySqlConnection pcon)
        {
            pcon.Close();
        }
    }
}
