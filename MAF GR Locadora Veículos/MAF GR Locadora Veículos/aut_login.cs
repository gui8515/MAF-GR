using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MAF_GR_Locadora_Veículos
{
    class aut_login
    {
        //Atributos
        private string login, senha;

        //Metodo construtor
        public aut_login(string plg, string psn)
        {
            this.login = plg;
            this.senha = psn;
        }

        //Metodo de autenticação login
        public bool verAut_login()
        {
            try
            {
                int retorno = -1;

                bd banco = new bd("mafgr_loc_veiculos");

                string sql = "SELECT COUNT(*) FROM tb_funcionario WHERE Login=@login AND Senha=@senha";

                MySqlCommand cmd = new MySqlCommand(sql, banco.conecta());
                cmd.Parameters.AddWithValue("@login", this.login);
                cmd.Parameters.AddWithValue("@senha", this.senha);
                cmd.ExecuteNonQuery();

                retorno = Convert.ToInt32(cmd.ExecuteScalar());

                banco.desconecta(banco.conecta());

                return retorno >0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
