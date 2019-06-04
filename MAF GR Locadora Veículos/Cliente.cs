using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MAF_GR_Locadora_Veículos
{
    class Cliente
    {
        //Atributos
        private string cnh, cpf, data_nasc, nome, cep, rua, numero, bairro, cidade, estado, telefone, email;
        //private int numero;

        //Metodo construtor
        public Cliente(string pcnh, string pcpf, string pdt_nasc, string pnome, string pcep, string prua, string pnumero, string pbairro, string pcidade, string pestado, string ptelef, string pemail)
        {
            this.cnh = pcnh;
            this.cpf = pcpf;
            this.data_nasc = pdt_nasc;
            this.nome = pnome;
            this.cep = pcep;
            this.rua = prua;
            this.numero = pnumero;
            this.bairro = pbairro;
            this.cidade = pcidade;
            this.estado = pestado;
            this.telefone = ptelef;
            this.email = pemail;
        }

        //Metodo de cadastrar
        public bool setCliente()
        {
            try
            {
                bd banco = new bd();

                string sql = "INSERT INTO tb_cliente (ID_cliente, CNH, CPF, Data_nasc, Nome, CEP, Rua, Numero, Bairro, Cidade, Estado, Telefone, E_mail, Cam_imagem) VALUES (NULL, @CNH, @CPF, @Data_nasc, @Nome, @CEP, @Rua, @Numero, @Bairro, @Cidade, @Estado, @Telefone, @E_mail, NULL)";

                MySqlCommand cmd = new MySqlCommand(sql, banco.conecta());
                cmd.Parameters.AddWithValue("@CNH", this.cnh);
                cmd.Parameters.AddWithValue("@CPF", this.cpf);
                cmd.Parameters.AddWithValue("@Data_nasc", this.data_nasc);
                cmd.Parameters.AddWithValue("@Nome", this.nome);
                cmd.Parameters.AddWithValue("@CEP", this.cep);
                cmd.Parameters.AddWithValue("@Rua", this.rua);
                cmd.Parameters.AddWithValue("@Numero", this.numero);
                cmd.Parameters.AddWithValue("@Bairro", this.bairro);
                cmd.Parameters.AddWithValue("@Cidade", this.cidade);
                cmd.Parameters.AddWithValue("@Estado", this.estado);
                cmd.Parameters.AddWithValue("@Telefone", this.telefone);
                cmd.Parameters.AddWithValue("@E_mail", this.email);
                cmd.ExecuteNonQuery();

                banco.desconecta(banco.conecta());

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
