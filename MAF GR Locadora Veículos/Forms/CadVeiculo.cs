using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MAF_GR_Locadora_Veículos
{
    public partial class frmCadVeiculo : Form
    {
        public frmCadVeiculo()
        {
            InitializeComponent();
        }

        private void btnSalvarVeiculo_Click(object sender, EventArgs e)
        {
            //Metodo de conversão
            int renav = System.Convert.ToInt32(txtRenVeiculo.Text);
            double km = System.Convert.ToDouble(txtKilomVeiculo.Text);
            byte[] bfoto = bd.ConvertImageToByte(picFotoVeiculo.Image);

            //Instanciando a classe Funcionario (objeto setFunc)
            Class.Veiculo setVeic = new Class.Veiculo(mtxPlacaVeiculo.Text, cmbUFVeiculo.SelectedItem.ToString(), renav, txtCorVeiculo.Text, txtMarcVeiculo.Text, cmbFabVeiculo.SelectedItem.ToString(), cmbModVeiculo.SelectedItem.ToString(), cmbCategVeiculo.SelectedItem.ToString(), km, cmbStatusVeiculo.SelectedItem.ToString(), bfoto);

            //Utilizando o objeto setFunc
            bool verifica = setVeic.setVeiculo();

            if (verifica == true)
            {
                MessageBox.Show("Veículo cadastrado com sucesso", "Message");

                //Limpar formulário
                mtxPlacaVeiculo.Clear();
                cmbUFVeiculo.SelectedIndex = -1;
                txtRenVeiculo.Clear();
                txtCorVeiculo.Clear();
                txtMarcVeiculo.Clear();
                cmbFabVeiculo.SelectedIndex = -1;
                cmbModVeiculo.SelectedIndex = -1;
                cmbCategVeiculo.SelectedIndex = -1;
                txtKilomVeiculo.Clear();
                cmbStatusVeiculo.SelectedIndex = -1;
                picFotoVeiculo.Image = null;

                //Carregar imagem padrão do formulário e focus para digitar
                picFotoVeiculo.Image = Properties.Resources.Icone_Foto_Veículo;
                mtxPlacaVeiculo.Focus();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o veículo", "Atenção");
            }
        }

        private void frmCadVeiculo_Load(object sender, EventArgs e)
        {
            mtxPlacaVeiculo.Focus();

            //Carregar os Estados do Brasil
            cmbUFVeiculo.Items.Add("AC");
            cmbUFVeiculo.Items.Add("AL");
            cmbUFVeiculo.Items.Add("AP");
            cmbUFVeiculo.Items.Add("AM");
            cmbUFVeiculo.Items.Add("BA");
            cmbUFVeiculo.Items.Add("CE");
            cmbUFVeiculo.Items.Add("DF");
            cmbUFVeiculo.Items.Add("ES");
            cmbUFVeiculo.Items.Add("GO");
            cmbUFVeiculo.Items.Add("MA");
            cmbUFVeiculo.Items.Add("MT");
            cmbUFVeiculo.Items.Add("MS");
            cmbUFVeiculo.Items.Add("MG");
            cmbUFVeiculo.Items.Add("PA");
            cmbUFVeiculo.Items.Add("PB");
            cmbUFVeiculo.Items.Add("PR");
            cmbUFVeiculo.Items.Add("PE");
            cmbUFVeiculo.Items.Add("PI");
            cmbUFVeiculo.Items.Add("RJ");
            cmbUFVeiculo.Items.Add("RN");
            cmbUFVeiculo.Items.Add("RS");
            cmbUFVeiculo.Items.Add("RO");
            cmbUFVeiculo.Items.Add("RR");
            cmbUFVeiculo.Items.Add("SC");
            cmbUFVeiculo.Items.Add("SP");
            cmbUFVeiculo.Items.Add("SE");
            cmbUFVeiculo.Items.Add("TO");

            //Carregar a lista de modelo e ano
            int i = 1900;

            while (i <= 2019)
            {
                cmbFabVeiculo.Items.Add(i);
                cmbModVeiculo.Items.Add(i);
                Console.WriteLine(i);
                i++;
            }

            //Carregar categoria do veículo
            cmbCategVeiculo.Items.Add("Manual");
            cmbCategVeiculo.Items.Add("Automático");

            //Carregar o status do veículo
            cmbStatusVeiculo.Items.Add("Disponível");
            cmbStatusVeiculo.Items.Add("Não disponível");
        }

        private void btnCancVeiculo_Click(object sender, EventArgs e)
        {
            //Limpar formulário
            mtxPlacaVeiculo.Clear();
            cmbUFVeiculo.SelectedIndex = -1;
            txtRenVeiculo.Clear();
            txtCorVeiculo.Clear();
            txtMarcVeiculo.Clear();
            cmbFabVeiculo.SelectedIndex = -1;
            cmbModVeiculo.SelectedIndex = -1;
            cmbCategVeiculo.SelectedIndex = -1;
            txtKilomVeiculo.Clear();
            cmbStatusVeiculo.SelectedIndex = -1;
            picFotoVeiculo.Image = null;

            //Carregar imagem padrão do formulário e focus para digitar
            picFotoVeiculo.Image = Properties.Resources.Icone_Foto_Veículo;
            mtxPlacaVeiculo.Focus();
        }

        private void btnAdFotoVeiculo_Click(object sender, EventArgs e)
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
            picFotoVeiculo.Image = Image.FromFile(ofdLogo.FileName);
        }
    }
}
