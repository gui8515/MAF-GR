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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe aut_login (objeto aut_lg)
            aut_login aut_lg = new aut_login(txtUsuario.Text, txtSenha.Text);

            bool verifica;

            verifica = aut_lg.verAut_login();

            if (verifica == true)
            {
                MessageBox.Show("Usuário " + txtUsuario.Text + " Logado com sucesso!");
                this.Hide();
                frmMenu logMenu = new frmMenu();
                logMenu.FormClosed += (s, args) => this.Close();
                logMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!");

                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }
    }
}
