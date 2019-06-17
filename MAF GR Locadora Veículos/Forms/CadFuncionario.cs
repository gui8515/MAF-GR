using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MAF_GR_Locadora_Veículos
{
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }
        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            //Metodo de conversão
            byte[] bfoto = bd.ConvertImageToByte(picFotoFunc.Image);

            //Instanciando a classe Funcionario (objeto setFunc)
            Funcionario setFunc = new Funcionario(txtIDFunc.Text, mtxCPFFunc.Text, mtxDataFunc.Text, txtNomeFunc.Text, mtxCEPFunc.Text, txtRuaFunc.Text, txtNumFunc.Text, txtBairFunc.Text, txtCidFunc.Text, cmbEstFunc.SelectedItem.ToString(), mtxTelFunc.Text, txtEmailFunc.Text, txtLoginFunc.Text, txtSenhaFunc.Text, bfoto);

            //Utilizando o objeto setFunc
            bool verifica = setFunc.setFuncionario();

            if (verifica == true)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso", "Message");

                //Limpar formulário
                mtxCPFFunc.Clear();
                mtxDataFunc.Clear();
                txtNomeFunc.Clear();
                mtxCEPFunc.Clear();
                txtRuaFunc.Clear();
                txtNumFunc.Clear();
                txtBairFunc.Clear();
                txtCidFunc.Clear();
                cmbEstFunc.SelectedIndex = -1;
                mtxTelFunc.Clear();
                txtEmailFunc.Clear();
                txtLoginFunc.Clear();
                txtSenhaFunc.Clear();
                picFotoFunc.Image = null;

                //Carregar imagem padrão do formulário e focus para digitar
                picFotoFunc.Image = Properties.Resources.Icone_Foto_Funcionário;
                mtxCPFFunc.Focus();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o funcionário", "Atenção");
            }
        }
        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            mtxCEPFunc.Focus();
            
            //Carregar os Estados do Brasil
            cmbEstFunc.Items.Add("AC");
            cmbEstFunc.Items.Add("AL");
            cmbEstFunc.Items.Add("AP");
            cmbEstFunc.Items.Add("AM");
            cmbEstFunc.Items.Add("BA");
            cmbEstFunc.Items.Add("CE");
            cmbEstFunc.Items.Add("DF");
            cmbEstFunc.Items.Add("ES");
            cmbEstFunc.Items.Add("GO");
            cmbEstFunc.Items.Add("MA");
            cmbEstFunc.Items.Add("MT");
            cmbEstFunc.Items.Add("MS");
            cmbEstFunc.Items.Add("MG");
            cmbEstFunc.Items.Add("PA");
            cmbEstFunc.Items.Add("PB");
            cmbEstFunc.Items.Add("PR");
            cmbEstFunc.Items.Add("PE");
            cmbEstFunc.Items.Add("PI");
            cmbEstFunc.Items.Add("RJ");
            cmbEstFunc.Items.Add("RN");
            cmbEstFunc.Items.Add("RS");
            cmbEstFunc.Items.Add("RO");
            cmbEstFunc.Items.Add("RR");
            cmbEstFunc.Items.Add("SC");
            cmbEstFunc.Items.Add("SP");
            cmbEstFunc.Items.Add("SE");
            cmbEstFunc.Items.Add("TO");
        }
        private void btnCancFunc_Click(object sender, EventArgs e)
        {
            //Limpar formulário
            mtxCPFFunc.Clear();
            mtxDataFunc.Clear();
            txtNomeFunc.Clear();
            mtxCEPFunc.Clear();
            txtRuaFunc.Clear();
            txtNumFunc.Clear();
            txtBairFunc.Clear();
            txtCidFunc.Clear();
            cmbEstFunc.SelectedIndex = -1;
            mtxTelFunc.Clear();
            txtEmailFunc.Clear();
            txtLoginFunc.Clear();
            txtSenhaFunc.Clear();
            picFotoFunc.Image = null;

            //Carregar imagem padrão do formulário e focus para digitar
            picFotoFunc.Image = Properties.Resources.Icone_Foto_Funcionário;
            mtxCPFFunc.Focus();
        }
        private void btnAdFotoFunc_Click(object sender, EventArgs e)
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
            picFotoFunc.Image = Image.FromFile(ofdLogo.FileName);
        }
    }
}