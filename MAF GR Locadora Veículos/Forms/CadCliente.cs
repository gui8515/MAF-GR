using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MAF_GR_Locadora_Veículos
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            //Metodo de conversão
            byte[] bfoto = bd.ConvertImageToByte(picFotoCliente.Image);

            //Instanciando a classe Funcionario (objeto setFunc)
            Cliente setCli = new Cliente (txtCNHCliente.Text, cmbCategCliente.SelectedItem.ToString(), mtxValCliente.Text, mtxCPFCliente.Text, mtxDataCliente.Text, txtNomeCliente.Text, mtxCEPCliente.Text, txtRuaCliente.Text, txtNumCliente.Text, txtBairCliente.Text, txtCidCliente.Text, cmbEstCliente.SelectedItem.ToString(), mtxTelCliente.Text, txtEmailCliente.Text, bfoto);

            //Utilizando o objeto setFunc
            bool verifica = setCli.setCliente();

            if (verifica == true)
            {
                MessageBox.Show("Cliente cadastrado com sucesso", "Message");

                //Limpar formulário
                txtCNHCliente.Clear();
                mtxCEPCliente.Clear();
                mtxDataCliente.Clear();
                txtNomeCliente.Clear();
                mtxCEPCliente.Clear();
                txtRuaCliente.Clear();
                txtNumCliente.Clear();
                txtBairCliente.Clear();
                txtCidCliente.Clear();
                cmbEstCliente.SelectedIndex = -1;
                mtxTelCliente.Clear();
                txtEmailCliente.Clear();
                picFotoCliente.Image = null;

                //Carregar imagem padrão do formulário e focus para digitar
                picFotoCliente.Image = Properties.Resources.Icone_Foto_Cliente;
                txtCNHCliente.Focus();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o Cliente", "Atenção");
            }
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            txtCNHCliente.Focus();

            //Carregar os Estados do Brasil
            cmbEstCliente.Items.Add("AC");
            cmbEstCliente.Items.Add("AL");
            cmbEstCliente.Items.Add("AP");
            cmbEstCliente.Items.Add("AM");
            cmbEstCliente.Items.Add("BA");
            cmbEstCliente.Items.Add("CE");
            cmbEstCliente.Items.Add("DF");
            cmbEstCliente.Items.Add("ES");
            cmbEstCliente.Items.Add("GO");
            cmbEstCliente.Items.Add("MA");
            cmbEstCliente.Items.Add("MT");
            cmbEstCliente.Items.Add("MS");
            cmbEstCliente.Items.Add("MG");
            cmbEstCliente.Items.Add("PA");
            cmbEstCliente.Items.Add("PB");
            cmbEstCliente.Items.Add("PR");
            cmbEstCliente.Items.Add("PE");
            cmbEstCliente.Items.Add("PI");
            cmbEstCliente.Items.Add("RJ");
            cmbEstCliente.Items.Add("RN");
            cmbEstCliente.Items.Add("RS");
            cmbEstCliente.Items.Add("RO");
            cmbEstCliente.Items.Add("RR");
            cmbEstCliente.Items.Add("SC");
            cmbEstCliente.Items.Add("SP");
            cmbEstCliente.Items.Add("SE");
            cmbEstCliente.Items.Add("TO");

            //Carregar as categorias da CNH
            cmbCategCliente.Items.Add("A");
            cmbCategCliente.Items.Add("B");
            cmbCategCliente.Items.Add("C");
            cmbCategCliente.Items.Add("D");
            cmbCategCliente.Items.Add("E");
            cmbCategCliente.Items.Add("AB");
            cmbCategCliente.Items.Add("AC");
            cmbCategCliente.Items.Add("AD");
            cmbCategCliente.Items.Add("AE");
        }

        private void btnCancCliente_Click(object sender, EventArgs e)
        {
            //Limpar formulário
            txtCNHCliente.Clear();
            mtxCEPCliente.Clear();
            mtxDataCliente.Clear();
            txtNomeCliente.Clear();
            mtxCEPCliente.Clear();
            txtRuaCliente.Clear();
            txtNumCliente.Clear();
            txtBairCliente.Clear();
            txtCidCliente.Clear();
            cmbEstCliente.SelectedIndex = -1;
            mtxTelCliente.Clear();
            txtEmailCliente.Clear();
            picFotoCliente.Image = null;

            //Carregar imagem padrão do formulário e focus para digitar
            picFotoCliente.Image = Properties.Resources.Icone_Foto_Cliente;
            txtCNHCliente.Focus();
        }

        private void btnAdFotoCliente_Click(object sender, EventArgs e)
        {
            //Instanciando comando OpenFileDialog (objeto dialog)
            OpenFileDialog dialog = new OpenFileDialog();

            //Configurando OpenFileDialog
            ofdLogo.FileName = "";
            ofdLogo.Title = "Seleciona uma foto";
            ofdLogo.Filter = "JPEG Files(*.JPG)|*.jpg|PNG Files(*.PNG)|*.png|All Files(*.*)|*.*";
            ofdLogo.ShowDialog();
        }

        private void ofdLogo_FileOk(object sender, CancelEventArgs e)
        {
            picFotoCliente.Image = Image.FromFile(ofdLogo.FileName);
        }
    }
}