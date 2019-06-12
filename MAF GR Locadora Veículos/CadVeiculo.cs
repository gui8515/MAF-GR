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
            
            //Instanciando a classe Funcionario (objeto setFunc)
            Veiculo setVeic = new Veiculo(mtxPlacaVeiculo.Text, cmbUFVeiculo.SelectedItem.ToString(), renav, txtCorVeiculo.Text, txtFabVeiculo.Text, cmbModVeiculo.SelectedItem.ToString(), cmbAnoVeiculo.SelectedItem.ToString(), cmbCategVeiculo.SelectedItem.ToString(), km, cmbStatusVeiculo.SelectedItem.ToString());

            //Utilizando o objeto setFunc
            bool verifica = setVeic.setVeiculo();

            if (verifica == true)
            {
                MessageBox.Show("Veículo cadastrado com sucesso", "Message");

                mtxPlacaVeiculo.Clear();
                cmbUFVeiculo.SelectedIndex = -1;
                txtRenVeiculo.Clear();
                txtCorVeiculo.Clear();
                txtFabVeiculo.Clear();
                cmbModVeiculo.SelectedIndex = -1;
                cmbAnoVeiculo.SelectedIndex = -1;
                cmbCategVeiculo.SelectedIndex = -1;
                txtKilomVeiculo.Clear();
                cmbStatusVeiculo.SelectedIndex = -1;

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
                cmbModVeiculo.Items.Add(i);
                cmbAnoVeiculo.Items.Add(i);
                Console.WriteLine(i);
                i++;
            }

            //Carregar categoria do veículo
            cmbCategVeiculo.Items.Add("Manual");
            cmbCategVeiculo.Items.Add("Automático");

            //Carregar o status do veículo
            cmbStatusVeiculo.Items.Add("Reservado");
            cmbStatusVeiculo.Items.Add("Disponível");
        }

        private void btnCancVeiculo_Click(object sender, EventArgs e)
        {
            frmCadVeiculo.ActiveForm.Close();
        }
    }
}
