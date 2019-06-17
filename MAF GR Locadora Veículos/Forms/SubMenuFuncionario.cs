using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MAF_GR_Locadora_Veículos.Forms
{
    public partial class frmSubMenuFuncionario : Form
    {
        public frmSubMenuFuncionario()
        {
            InitializeComponent();
        }

        private void frmSubMenuFuncionario_Load(object sender, EventArgs e)
        {
            bd banco = new bd();

            string sql = "SELECT * FROM tb_funcionario";

            MySqlDataAdapter cmd = new MySqlDataAdapter(sql, banco.conecta());
            DataSet DS = new DataSet();
            cmd.Fill(DS);
            dgvTab_Funcionario.DataSource = DS.Tables[0];

            banco.desconecta(banco.conecta());
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            //Instanciando o botão Cadastro Funcionário (objeto cadFunc)
            frmCadFuncionario cadFunc = new frmCadFuncionario();
            cadFunc.Show();
        }

        private void btnAltFuncionario_Click(object sender, EventArgs e)
        {
            int indiceselecionado = -1;
            if (dgvTab_Funcionario.SelectedRows.Count > 0)
            {
                indiceselecionado = dgvTab_Funcionario.SelectedRows[0].Index;

                //CPF, Data_nasc, Nome, CEP, Rua, Numero, Bairro, Cidade, Estado, Telefone, E_mail, Login, Senha, Foto
                string ID_func = dgvTab_Funcionario.CurrentRow.Cells["ID_Func"].Value.ToString();
                string CPF = dgvTab_Funcionario.CurrentRow.Cells["CPF"].Value.ToString();
                string Data_nasc = dgvTab_Funcionario.CurrentRow.Cells["Data_nasc"].Value.ToString();
                string Nome = dgvTab_Funcionario.CurrentRow.Cells["Nome"].Value.ToString();
                string CEP = dgvTab_Funcionario.CurrentRow.Cells["CEP"].Value.ToString();
                string Rua = dgvTab_Funcionario.CurrentRow.Cells["Rua"].Value.ToString();
                string Numero = dgvTab_Funcionario.CurrentRow.Cells["Numero"].Value.ToString();
                string Bairro = dgvTab_Funcionario.CurrentRow.Cells["Bairro"].Value.ToString();
                string Cidade = dgvTab_Funcionario.CurrentRow.Cells["Cidade"].Value.ToString();
                string Estado = dgvTab_Funcionario.CurrentRow.Cells["Estado"].Value.ToString();
                string Telefone = dgvTab_Funcionario.CurrentRow.Cells["Telefone"].Value.ToString();
                string E_mail = dgvTab_Funcionario.CurrentRow.Cells["E_mail"].Value.ToString();
                string Login = dgvTab_Funcionario.CurrentRow.Cells["Login"].Value.ToString();
                string Senha = dgvTab_Funcionario.CurrentRow.Cells["Senha"].Value.ToString();
                byte[] Foto = (byte[])dgvTab_Funcionario.CurrentRow.Cells["Foto"].Value;

                frmAltFuncionario frmAltFunc = new frmAltFuncionario(ID_func, CPF, Data_nasc, Nome, CEP, Rua, Numero, Bairro, Cidade, Estado, Telefone, E_mail, Login, Senha, Foto);
                frmAltFunc.Show();
            }
            else
            {
                MessageBox.Show("Favor Selecionar toda a linha!", "Atenção!");
            }
        }

        private void btnAtualizarTabela_Click(object sender, EventArgs e)
        {
            bd banco = new bd();

            string sql = "SELECT * FROM tb_funcionario";

            MySqlDataAdapter cmd = new MySqlDataAdapter(sql, banco.conecta());
            DataSet DS = new DataSet();
            cmd.Fill(DS);
            dgvTab_Funcionario.DataSource = DS.Tables[0];

            banco.desconecta(banco.conecta());
        }

        private void btnExcFuncionario_Click(object sender, EventArgs e)
        {
            int indiceselecionado = -1;
            if (dgvTab_Funcionario.SelectedRows.Count > 0)
            {
                indiceselecionado = dgvTab_Funcionario.SelectedRows[0].Index;

                //CPF, Data_nasc, Nome, CEP, Rua, Numero, Bairro, Cidade, Estado, Telefone, E_mail, Login, Senha, Foto
                string ID_func = dgvTab_Funcionario.CurrentRow.Cells["ID_Func"].Value.ToString();
                string CPF = dgvTab_Funcionario.CurrentRow.Cells["CPF"].Value.ToString();
                string Data_nasc = dgvTab_Funcionario.CurrentRow.Cells["Data_nasc"].Value.ToString();
                string Nome = dgvTab_Funcionario.CurrentRow.Cells["Nome"].Value.ToString();
                string CEP = dgvTab_Funcionario.CurrentRow.Cells["CEP"].Value.ToString();
                string Rua = dgvTab_Funcionario.CurrentRow.Cells["Rua"].Value.ToString();
                string Numero = dgvTab_Funcionario.CurrentRow.Cells["Numero"].Value.ToString();
                string Bairro = dgvTab_Funcionario.CurrentRow.Cells["Bairro"].Value.ToString();
                string Cidade = dgvTab_Funcionario.CurrentRow.Cells["Cidade"].Value.ToString();
                string Estado = dgvTab_Funcionario.CurrentRow.Cells["Estado"].Value.ToString();
                string Telefone = dgvTab_Funcionario.CurrentRow.Cells["Telefone"].Value.ToString();
                string E_mail = dgvTab_Funcionario.CurrentRow.Cells["E_mail"].Value.ToString();
                string Login = dgvTab_Funcionario.CurrentRow.Cells["Login"].Value.ToString();
                string Senha = dgvTab_Funcionario.CurrentRow.Cells["Senha"].Value.ToString();
                byte[] Foto = (byte[])dgvTab_Funcionario.CurrentRow.Cells["Foto"].Value;

                Funcionario excFunc = new Funcionario(ID_func, CPF, Data_nasc, Nome, CEP, Rua, Numero, Bairro, Cidade, Estado, Telefone, E_mail, Login, Senha, Foto);
                excFunc.excFuncionario();

                if (MessageBox.Show("Tem certeza que deseja exluir os dados selecionados?", "Excluir dados", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Dados excluído com sucesso", "Dados excluídos");
                }
                else
                {
                    MessageBox.Show("Operação cancelado", "Cancelado");
                }
            }
            else
            {
                MessageBox.Show("Favor Selecionar toda a linha!", "Atenção!");
            }
        }
    }
}
