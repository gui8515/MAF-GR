using System;
using System.Windows.Forms;

namespace MAF_GR_Locadora_Veículos.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Usuário conectado
        public static string userConectado;

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe aut_login (objeto aut_lg)
            aut_login aut_lg = new aut_login(txtUsuario.Text, txtSenha.Text);

            userConectado = txtUsuario.Text;

            bool verifica;

            verifica = aut_lg.verAut_login();

            if (verifica == true)
            {
                MessageBox.Show("Usuário Logado com sucesso!", "Acesso Liberado");
                this.Hide();
                frmMenu logMenu = new frmMenu();
                logMenu.FormClosed += (s, args) => this.Close();
                logMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!", "Atenção");

                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }
    }
}
