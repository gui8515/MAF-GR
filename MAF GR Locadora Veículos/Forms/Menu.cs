using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAF_GR_Locadora_Veículos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            //Instanciando o botão Cadastro Funcionário (objeto cadFunc)
            Forms.frmSubMenuFuncionario submenuFunc = new Forms.frmSubMenuFuncionario();
            submenuFunc.Show();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            //Instanciando o botão Cadastro Cliente (objeto cadCli)
            frmCadCliente cadCli = new frmCadCliente();
            cadCli.Show();
        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            //Instanciando o botão Cadastro Veiculo (objeto cadVei)
            frmCadVeiculo cadVei = new frmCadVeiculo();
            cadVei.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUserConectado.Text = "Usuário: " + Forms.frmLogin.userConectado;
        }

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            //Instanciando o botão Locação (objeto setLoc)
            Forms.frmLocacao setLoc = new Forms.frmLocacao();
            setLoc.Show();
        }
    }
}
