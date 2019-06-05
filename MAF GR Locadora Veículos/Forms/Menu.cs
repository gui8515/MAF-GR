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

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            //Instanciando o botão Cadastro Funcionário (objeto cadFunc)
            frmCadFuncionario cadFunc = new frmCadFuncionario();
            cadFunc.Show();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            //Instanciando o botão Cadastro Funcionário (objeto cadFunc)
            frmCadCliente cadCli = new frmCadCliente();
            cadCli.Show();
        }
    }
}
