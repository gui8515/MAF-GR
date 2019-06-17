using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MAF_GR_Locadora_Veículos.Forms
{
    public partial class frmAltFuncionario : Form
    {
        //CPF, Data_nasc, Nome, CEP, Rua, Numero, Bairro, Cidade, Estado, Telefone, E_mail, Login, Senha, Foto
        protected string pID_func, pCPF, pData_nasc, pNome, pCEP, pRua, pNumero, pBairro, pCidade, pEstado, pTelefone, pE_mail, pLogin, pSenha;

        private void btnCancFunc_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void ofdLogo_FileOk(object sender, CancelEventArgs e)
        {
            picFotoFunc.Image = Image.FromFile(ofdLogo.FileName);
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

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            //Metodo de conversão
            byte[] bfoto = bd.ConvertImageToByte(picFotoFunc.Image);

            //Instanciando a classe Funcionario (objeto setFunc)
            Funcionario altFunc = new Funcionario(txtIDFunc.Text, mtxCPFFunc.Text, mtxDataFunc.Text, txtNomeFunc.Text, mtxCEPFunc.Text, txtRuaFunc.Text, txtNumFunc.Text, txtBairFunc.Text, txtCidFunc.Text, cmbEstFunc.Text, mtxTelFunc.Text, txtEmailFunc.Text, txtLoginFunc.Text, txtSenhaFunc.Text, bfoto);

            //Utilizando o objeto setFunc
            bool verifica = altFunc.altFuncionario();

            if (verifica == true)
            {
                MessageBox.Show("Dados atualizado com sucesso", "Message");
                frmAltFuncionario.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar os dados" + "\n" + "Verificar se todos os campos estão preenchidos!", "Atenção");
            }
        }

        protected byte[] pFoto;
        public frmAltFuncionario(string ID_func, string CPF, string Data_nasc, string Nome, string CEP, string Rua, string Numero, string Bairro, string Cidade, string Estado, string Telefone, string E_mail, string Login, string Senha, byte[] Foto)
        {
            pID_func = ID_func;
            pCPF = CPF;
            pData_nasc = Data_nasc;
            pNome = Nome;
            pCEP = CEP;
            pRua = Rua;
            pNumero = Numero;
            pBairro = Bairro;
            pCidade = Cidade;
            pEstado = Estado;
            pTelefone = Telefone;
            pE_mail = E_mail;
            pLogin = Login;
            pSenha = Senha;
            pFoto = Foto;

            InitializeComponent();
        }
        private void frmAltFuncionario_Load(object sender, EventArgs e)
        {
            txtIDFunc.Text = pID_func;
            mtxCPFFunc.Text = pCPF;
            mtxDataFunc.Text = pData_nasc;
            txtNomeFunc.Text = pNome;
            mtxCEPFunc.Text = pCEP;
            txtRuaFunc.Text = pRua;
            txtNumFunc.Text = pNumero;
            txtBairFunc.Text = pBairro;
            txtCidFunc.Text = pCidade;
            cmbEstFunc.Text = pEstado;
            mtxTelFunc.Text = pTelefone;
            txtEmailFunc.Text = pE_mail;
            txtLoginFunc.Text = pLogin;
            txtSenhaFunc.Text = pSenha;
            picFotoFunc.Image = null;

            if (pFoto != null)
            {
                MemoryStream MS = new MemoryStream(pFoto);
                picFotoFunc.Image = Image.FromStream(MS);
            }
            else
            {
                MessageBox.Show("Erro ao carregar imagem!", "Erro");
            }

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
    }
}
