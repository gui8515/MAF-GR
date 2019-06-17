using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using MySql.Data.MySqlClient;

namespace MAF_GR_Locadora_Veículos
{
    class bd
    {
        //Atributos
        //https://auth-db137.weblink.com.br/
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
            return "Persist security Info=False; server=" + this.serv + ";database=" + this.banco + ";uid=" + this.usuario + ";password=" + this.senha;
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

        //Metodo de conversão de imagem para byte[]
        public static byte[] ConvertImageToByte(Image foto)
        {
            MemoryStream MS = new MemoryStream();
            Bitmap bmp = new Bitmap(foto);
            foto.Save(MS, ImageFormat.Jpeg);
            Byte[] data = new Byte[MS.Length];
            data = MS.ToArray();

            return data;
        }

        //Metodo de conversão de byte[] para imagem
        public static Image ConvertToByteImage(byte[] foto)
        {
            MemoryStream MS = new MemoryStream(foto);
            Image returnFoto = Image.FromStream(MS);
            return returnFoto;
        }
    }
}