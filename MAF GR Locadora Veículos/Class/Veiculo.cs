using System;
using MySql.Data.MySqlClient;

namespace MAF_GR_Locadora_Veículos.Class
{
    class Veiculo
    {
        //Atributos
        private string placa, uf, cor, fabricante, modelo, ano, categoria, status_veiculo;
        private int renavam;
        private double kilometragem;
        byte[] foto;

        //Metodo construtor
        public Veiculo(string pplaca, string puf, int prenavam, string pcor, string pfabricante, string pmodelo, string pano, string pcategoria, double pkm, string pst_veiculo, byte[] pfoto)
        {
            this.placa = pplaca;
            this.uf = puf;
            this.renavam = prenavam;
            this.cor = pcor;
            this.fabricante = pfabricante;
            this.modelo = pmodelo;
            this.ano = pano;
            this.categoria = pcategoria;
            this.kilometragem = pkm;
            this.status_veiculo = pst_veiculo;
            this.foto = pfoto;
        }

        //Metodo de cadastrar
        public bool setVeiculo()
        {
            try
            {
                bd banco = new bd();

                string sql = "INSERT INTO tb_veiculo (ID_veiculo, Placa, UF, Renavam, Cor, Fabricante, Modelo, Ano, Categoria, Kilometragem, Status, Foto) VALUES (NULL, @Placa, @UF, @Renavam, @cor, @Fabricante, @Modelo, @Ano, @Categoria, @Kilometragem, @Status, @Foto)";

                MySqlCommand cmd = new MySqlCommand(sql, banco.conecta());
                cmd.Parameters.AddWithValue("@Placa", this.placa);
                cmd.Parameters.AddWithValue("@UF", this.uf);
                cmd.Parameters.AddWithValue("@Renavam", this.renavam);
                cmd.Parameters.AddWithValue("@Cor", this.cor);
                cmd.Parameters.AddWithValue("@Fabricante", this.fabricante);
                cmd.Parameters.AddWithValue("@Modelo", this.modelo);
                cmd.Parameters.AddWithValue("@Ano", this.ano);
                cmd.Parameters.AddWithValue("@Categoria", this.categoria);
                cmd.Parameters.AddWithValue("@Kilometragem", this.kilometragem);
                cmd.Parameters.AddWithValue("@Status", this.status_veiculo);
                cmd.Parameters.AddWithValue("@Foto", this.foto);
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
