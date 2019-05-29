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
        protected string serv = "localhost";
        protected string usuario = "root";
        protected string senha = "";
        private string mafgr_loc_veiculos;

        //Metodo construtor
        public bd(string pdb)
        {
            mafgr_loc_veiculos = pdb;
        }

        //Metodo string de conexão
        private string monta_string()
        {
            return "Persist security Info=False; server=" + this.serv + ";database=" + this.mafgr_loc_veiculos + ";uid=" + this.usuario + ";password=" + this.senha;
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
