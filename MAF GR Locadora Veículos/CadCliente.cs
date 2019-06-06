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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            //Instanciando a classe Funcionario (objeto setFunc)
            Cliente setCli = new Cliente (txtCNHCliente.Text, mtxCPFCliente.Text, mtxDataCliente.Text, txtNomeCliente.Text, mtxCEPCliente.Text, txtRuaCliente.Text, txtNumCliente.Text, txtBairCliente.Text, txtCidCliente.Text, cmbEstCliente.SelectedItem.ToString(), mtxTelCliente.Text, txtEmailCliente.Text);

            //Utilizando o objeto setFunc
            bool verifica = setCli.setCliente();

            if (verifica == true)
            {
                MessageBox.Show("Cliente cadastrado com sucesso", "Message");

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
        }

        private void btnCancCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente.ActiveForm.Close();
        }
    }
}
