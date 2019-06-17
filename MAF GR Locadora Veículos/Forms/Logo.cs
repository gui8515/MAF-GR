using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAF_GR_Locadora_Veículos
{
    public partial class frmLogo : Form
    {
        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public frmLogo()
        {
            InitializeComponent();
            timer.Interval = 8000;
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Forms.frmLogin logLogin = new Forms.frmLogin();
            logLogin.FormClosed += (s, args) => this.Close();
            logLogin.Show();
            timer.Stop();
        }

        private void frmLogo_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}