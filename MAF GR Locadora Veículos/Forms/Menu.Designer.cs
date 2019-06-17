namespace MAF_GR_Locadora_Veículos
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnCadVeiculo = new System.Windows.Forms.Button();
            this.btnLocacao = new System.Windows.Forms.Button();
            this.lblUserConectado = new System.Windows.Forms.Label();
            this.picFotoFunc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFuncionario.BackgroundImage = global::MAF_GR_Locadora_Veículos.Properties.Resources.Icone_Menu_Funcionário;
            this.btnFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Location = new System.Drawing.Point(294, 93);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(145, 135);
            this.btnFuncionario.TabIndex = 0;
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadCliente.Location = new System.Drawing.Point(500, 161);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(142, 67);
            this.btnCadCliente.TabIndex = 1;
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadVeiculo.Location = new System.Drawing.Point(297, 281);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(142, 67);
            this.btnCadVeiculo.TabIndex = 2;
            this.btnCadVeiculo.Text = "Cadastrar Veículo";
            this.btnCadVeiculo.UseVisualStyleBackColor = true;
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // btnLocacao
            // 
            this.btnLocacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLocacao.Location = new System.Drawing.Point(500, 281);
            this.btnLocacao.Name = "btnLocacao";
            this.btnLocacao.Size = new System.Drawing.Size(142, 67);
            this.btnLocacao.TabIndex = 3;
            this.btnLocacao.Text = "Locação";
            this.btnLocacao.UseVisualStyleBackColor = true;
            this.btnLocacao.Click += new System.EventHandler(this.btnLocacao_Click);
            // 
            // lblUserConectado
            // 
            this.lblUserConectado.AutoSize = true;
            this.lblUserConectado.BackColor = System.Drawing.Color.Transparent;
            this.lblUserConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserConectado.Location = new System.Drawing.Point(12, 132);
            this.lblUserConectado.Name = "lblUserConectado";
            this.lblUserConectado.Size = new System.Drawing.Size(66, 16);
            this.lblUserConectado.TabIndex = 4;
            this.lblUserConectado.Text = "Usuário:";
            // 
            // picFotoFunc
            // 
            this.picFotoFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotoFunc.Image = global::MAF_GR_Locadora_Veículos.Properties.Resources.Icone_Foto_Funcionário;
            this.picFotoFunc.Location = new System.Drawing.Point(12, 12);
            this.picFotoFunc.Name = "picFotoFunc";
            this.picFotoFunc.Size = new System.Drawing.Size(116, 117);
            this.picFotoFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoFunc.TabIndex = 49;
            this.picFotoFunc.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::MAF_GR_Locadora_Veículos.Properties.Resources.Wallpaper02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 513);
            this.Controls.Add(this.picFotoFunc);
            this.Controls.Add(this.lblUserConectado);
            this.Controls.Add(this.btnLocacao);
            this.Controls.Add(this.btnCadVeiculo);
            this.Controls.Add(this.btnCadCliente);
            this.Controls.Add(this.btnFuncionario);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnCadVeiculo;
        private System.Windows.Forms.Button btnLocacao;
        private System.Windows.Forms.Label lblUserConectado;
        private System.Windows.Forms.PictureBox picFotoFunc;
    }
}