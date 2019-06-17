namespace MAF_GR_Locadora_Veículos
{
    partial class frmCadFuncionario
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
            this.cmbEstFunc = new System.Windows.Forms.ComboBox();
            this.mtxCEPFunc = new System.Windows.Forms.MaskedTextBox();
            this.lblCEPFunc = new System.Windows.Forms.Label();
            this.btnAdFotoFunc = new System.Windows.Forms.Button();
            this.btnCancFunc = new System.Windows.Forms.Button();
            this.btnSalvarFunc = new System.Windows.Forms.Button();
            this.txtCidFunc = new System.Windows.Forms.TextBox();
            this.txtBairFunc = new System.Windows.Forms.TextBox();
            this.lblCidFunc = new System.Windows.Forms.Label();
            this.lblEstFunc = new System.Windows.Forms.Label();
            this.lblBairFunc = new System.Windows.Forms.Label();
            this.txtNumFunc = new System.Windows.Forms.TextBox();
            this.lblNumFunc = new System.Windows.Forms.Label();
            this.mtxTelFunc = new System.Windows.Forms.MaskedTextBox();
            this.mtxDataFunc = new System.Windows.Forms.MaskedTextBox();
            this.mtxCPFFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.txtLoginFunc = new System.Windows.Forms.TextBox();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.txtRuaFunc = new System.Windows.Forms.TextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblSenhaFunc = new System.Windows.Forms.Label();
            this.lblLoginFunc = new System.Windows.Forms.Label();
            this.lblEmailFunc = new System.Windows.Forms.Label();
            this.lblTelFunc = new System.Windows.Forms.Label();
            this.lblRuaFunc = new System.Windows.Forms.Label();
            this.lblDataFunc = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblCPFFunc = new System.Windows.Forms.Label();
            this.picFotoFunc = new System.Windows.Forms.PictureBox();
            this.ofdLogo = new System.Windows.Forms.OpenFileDialog();
            this.lblIDFunc = new System.Windows.Forms.Label();
            this.txtIDFunc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstFunc
            // 
            this.cmbEstFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEstFunc.DropDownHeight = 100;
            this.cmbEstFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstFunc.FormattingEnabled = true;
            this.cmbEstFunc.IntegralHeight = false;
            this.cmbEstFunc.Location = new System.Drawing.Point(622, 214);
            this.cmbEstFunc.Name = "cmbEstFunc";
            this.cmbEstFunc.Size = new System.Drawing.Size(80, 24);
            this.cmbEstFunc.TabIndex = 9;
            // 
            // mtxCEPFunc
            // 
            this.mtxCEPFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxCEPFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxCEPFunc.Location = new System.Drawing.Point(392, 98);
            this.mtxCEPFunc.Mask = "00.000-000";
            this.mtxCEPFunc.Name = "mtxCEPFunc";
            this.mtxCEPFunc.Size = new System.Drawing.Size(101, 22);
            this.mtxCEPFunc.TabIndex = 4;
            // 
            // lblCEPFunc
            // 
            this.lblCEPFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCEPFunc.AutoSize = true;
            this.lblCEPFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEPFunc.Location = new System.Drawing.Point(349, 104);
            this.lblCEPFunc.Name = "lblCEPFunc";
            this.lblCEPFunc.Size = new System.Drawing.Size(38, 16);
            this.lblCEPFunc.TabIndex = 0;
            this.lblCEPFunc.Text = "CEP";
            // 
            // btnAdFotoFunc
            // 
            this.btnAdFotoFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdFotoFunc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdFotoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdFotoFunc.Location = new System.Drawing.Point(47, 195);
            this.btnAdFotoFunc.Name = "btnAdFotoFunc";
            this.btnAdFotoFunc.Size = new System.Drawing.Size(130, 43);
            this.btnAdFotoFunc.TabIndex = 16;
            this.btnAdFotoFunc.Text = "Adicionar Foto";
            this.btnAdFotoFunc.UseVisualStyleBackColor = false;
            this.btnAdFotoFunc.Click += new System.EventHandler(this.btnAdFotoFunc_Click);
            // 
            // btnCancFunc
            // 
            this.btnCancFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancFunc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancFunc.Location = new System.Drawing.Point(759, 458);
            this.btnCancFunc.Name = "btnCancFunc";
            this.btnCancFunc.Size = new System.Drawing.Size(130, 43);
            this.btnCancFunc.TabIndex = 15;
            this.btnCancFunc.Text = "Cancelar";
            this.btnCancFunc.UseVisualStyleBackColor = false;
            this.btnCancFunc.Click += new System.EventHandler(this.btnCancFunc_Click);
            // 
            // btnSalvarFunc
            // 
            this.btnSalvarFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarFunc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFunc.Location = new System.Drawing.Point(623, 458);
            this.btnSalvarFunc.Name = "btnSalvarFunc";
            this.btnSalvarFunc.Size = new System.Drawing.Size(130, 43);
            this.btnSalvarFunc.TabIndex = 14;
            this.btnSalvarFunc.Text = "Salvar";
            this.btnSalvarFunc.UseVisualStyleBackColor = false;
            this.btnSalvarFunc.Click += new System.EventHandler(this.btnSalvarFunc_Click);
            // 
            // txtCidFunc
            // 
            this.txtCidFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidFunc.Location = new System.Drawing.Point(392, 216);
            this.txtCidFunc.Name = "txtCidFunc";
            this.txtCidFunc.Size = new System.Drawing.Size(161, 22);
            this.txtCidFunc.TabIndex = 8;
            // 
            // txtBairFunc
            // 
            this.txtBairFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairFunc.Location = new System.Drawing.Point(392, 176);
            this.txtBairFunc.Name = "txtBairFunc";
            this.txtBairFunc.Size = new System.Drawing.Size(357, 22);
            this.txtBairFunc.TabIndex = 7;
            // 
            // lblCidFunc
            // 
            this.lblCidFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidFunc.AutoSize = true;
            this.lblCidFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidFunc.Location = new System.Drawing.Point(328, 222);
            this.lblCidFunc.Name = "lblCidFunc";
            this.lblCidFunc.Size = new System.Drawing.Size(58, 16);
            this.lblCidFunc.TabIndex = 0;
            this.lblCidFunc.Text = "Cidade";
            // 
            // lblEstFunc
            // 
            this.lblEstFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstFunc.AutoSize = true;
            this.lblEstFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstFunc.Location = new System.Drawing.Point(559, 222);
            this.lblEstFunc.Name = "lblEstFunc";
            this.lblEstFunc.Size = new System.Drawing.Size(57, 16);
            this.lblEstFunc.TabIndex = 0;
            this.lblEstFunc.Text = "Estado";
            // 
            // lblBairFunc
            // 
            this.lblBairFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBairFunc.AutoSize = true;
            this.lblBairFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairFunc.Location = new System.Drawing.Point(336, 182);
            this.lblBairFunc.Name = "lblBairFunc";
            this.lblBairFunc.Size = new System.Drawing.Size(50, 16);
            this.lblBairFunc.TabIndex = 0;
            this.lblBairFunc.Text = "Bairro";
            // 
            // txtNumFunc
            // 
            this.txtNumFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFunc.Location = new System.Drawing.Point(787, 136);
            this.txtNumFunc.Name = "txtNumFunc";
            this.txtNumFunc.Size = new System.Drawing.Size(89, 22);
            this.txtNumFunc.TabIndex = 6;
            // 
            // lblNumFunc
            // 
            this.lblNumFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumFunc.AutoSize = true;
            this.lblNumFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFunc.Location = new System.Drawing.Point(756, 142);
            this.lblNumFunc.Name = "lblNumFunc";
            this.lblNumFunc.Size = new System.Drawing.Size(25, 16);
            this.lblNumFunc.TabIndex = 0;
            this.lblNumFunc.Text = "Nº";
            // 
            // mtxTelFunc
            // 
            this.mtxTelFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxTelFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxTelFunc.Location = new System.Drawing.Point(392, 259);
            this.mtxTelFunc.Mask = "(99) 00000-0000";
            this.mtxTelFunc.Name = "mtxTelFunc";
            this.mtxTelFunc.Size = new System.Drawing.Size(100, 22);
            this.mtxTelFunc.TabIndex = 10;
            // 
            // mtxDataFunc
            // 
            this.mtxDataFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxDataFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxDataFunc.Location = new System.Drawing.Point(774, 19);
            this.mtxDataFunc.Mask = "00/00/0000";
            this.mtxDataFunc.Name = "mtxDataFunc";
            this.mtxDataFunc.Size = new System.Drawing.Size(100, 22);
            this.mtxDataFunc.TabIndex = 2;
            this.mtxDataFunc.ValidatingType = typeof(System.DateTime);
            // 
            // mtxCPFFunc
            // 
            this.mtxCPFFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxCPFFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxCPFFunc.Location = new System.Drawing.Point(392, 19);
            this.mtxCPFFunc.Mask = "000.000.000-00";
            this.mtxCPFFunc.Name = "mtxCPFFunc";
            this.mtxCPFFunc.Size = new System.Drawing.Size(101, 22);
            this.mtxCPFFunc.TabIndex = 1;
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaFunc.Location = new System.Drawing.Point(392, 402);
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.Size = new System.Drawing.Size(161, 22);
            this.txtSenhaFunc.TabIndex = 13;
            // 
            // txtLoginFunc
            // 
            this.txtLoginFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginFunc.Location = new System.Drawing.Point(392, 364);
            this.txtLoginFunc.Name = "txtLoginFunc";
            this.txtLoginFunc.Size = new System.Drawing.Size(161, 22);
            this.txtLoginFunc.TabIndex = 12;
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFunc.Location = new System.Drawing.Point(392, 299);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(353, 22);
            this.txtEmailFunc.TabIndex = 11;
            // 
            // txtRuaFunc
            // 
            this.txtRuaFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRuaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaFunc.Location = new System.Drawing.Point(392, 136);
            this.txtRuaFunc.Name = "txtRuaFunc";
            this.txtRuaFunc.Size = new System.Drawing.Size(357, 22);
            this.txtRuaFunc.TabIndex = 5;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(392, 59);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(484, 22);
            this.txtNomeFunc.TabIndex = 3;
            // 
            // lblSenhaFunc
            // 
            this.lblSenhaFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenhaFunc.AutoSize = true;
            this.lblSenhaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaFunc.Location = new System.Drawing.Point(334, 408);
            this.lblSenhaFunc.Name = "lblSenhaFunc";
            this.lblSenhaFunc.Size = new System.Drawing.Size(52, 16);
            this.lblSenhaFunc.TabIndex = 0;
            this.lblSenhaFunc.Text = "Senha";
            // 
            // lblLoginFunc
            // 
            this.lblLoginFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoginFunc.AutoSize = true;
            this.lblLoginFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginFunc.Location = new System.Drawing.Point(340, 370);
            this.lblLoginFunc.Name = "lblLoginFunc";
            this.lblLoginFunc.Size = new System.Drawing.Size(46, 16);
            this.lblLoginFunc.TabIndex = 0;
            this.lblLoginFunc.Text = "Login";
            // 
            // lblEmailFunc
            // 
            this.lblEmailFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailFunc.AutoSize = true;
            this.lblEmailFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFunc.Location = new System.Drawing.Point(334, 305);
            this.lblEmailFunc.Name = "lblEmailFunc";
            this.lblEmailFunc.Size = new System.Drawing.Size(52, 16);
            this.lblEmailFunc.TabIndex = 0;
            this.lblEmailFunc.Text = "E-mail";
            // 
            // lblTelFunc
            // 
            this.lblTelFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelFunc.AutoSize = true;
            this.lblTelFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelFunc.Location = new System.Drawing.Point(316, 265);
            this.lblTelFunc.Name = "lblTelFunc";
            this.lblTelFunc.Size = new System.Drawing.Size(70, 16);
            this.lblTelFunc.TabIndex = 0;
            this.lblTelFunc.Text = "Telefone";
            // 
            // lblRuaFunc
            // 
            this.lblRuaFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRuaFunc.AutoSize = true;
            this.lblRuaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuaFunc.Location = new System.Drawing.Point(351, 142);
            this.lblRuaFunc.Name = "lblRuaFunc";
            this.lblRuaFunc.Size = new System.Drawing.Size(36, 16);
            this.lblRuaFunc.TabIndex = 0;
            this.lblRuaFunc.Text = "Rua";
            // 
            // lblDataFunc
            // 
            this.lblDataFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataFunc.AutoSize = true;
            this.lblDataFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFunc.Location = new System.Drawing.Point(619, 25);
            this.lblDataFunc.Name = "lblDataFunc";
            this.lblDataFunc.Size = new System.Drawing.Size(149, 16);
            this.lblDataFunc.TabIndex = 0;
            this.lblDataFunc.Text = "Data de Nascimento";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(337, 65);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(49, 16);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome";
            // 
            // lblCPFFunc
            // 
            this.lblCPFFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCPFFunc.AutoSize = true;
            this.lblCPFFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFFunc.Location = new System.Drawing.Point(349, 25);
            this.lblCPFFunc.Name = "lblCPFFunc";
            this.lblCPFFunc.Size = new System.Drawing.Size(37, 16);
            this.lblCPFFunc.TabIndex = 0;
            this.lblCPFFunc.Text = "CPF";
            // 
            // picFotoFunc
            // 
            this.picFotoFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picFotoFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotoFunc.Image = global::MAF_GR_Locadora_Veículos.Properties.Resources.Icone_Foto_Funcionário;
            this.picFotoFunc.Location = new System.Drawing.Point(12, 19);
            this.picFotoFunc.Name = "picFotoFunc";
            this.picFotoFunc.Size = new System.Drawing.Size(200, 170);
            this.picFotoFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoFunc.TabIndex = 48;
            this.picFotoFunc.TabStop = false;
            // 
            // ofdLogo
            // 
            this.ofdLogo.FileName = "openFileDialog1";
            this.ofdLogo.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLogo_FileOk);
            // 
            // lblIDFunc
            // 
            this.lblIDFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDFunc.AutoSize = true;
            this.lblIDFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDFunc.Location = new System.Drawing.Point(218, 25);
            this.lblIDFunc.Name = "lblIDFunc";
            this.lblIDFunc.Size = new System.Drawing.Size(23, 16);
            this.lblIDFunc.TabIndex = 82;
            this.lblIDFunc.Text = "ID";
            this.lblIDFunc.Visible = false;
            // 
            // txtIDFunc
            // 
            this.txtIDFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDFunc.Enabled = false;
            this.txtIDFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDFunc.Location = new System.Drawing.Point(247, 19);
            this.txtIDFunc.Name = "txtIDFunc";
            this.txtIDFunc.Size = new System.Drawing.Size(50, 15);
            this.txtIDFunc.TabIndex = 81;
            this.txtIDFunc.WordWrap = false;
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 513);
            this.Controls.Add(this.lblIDFunc);
            this.Controls.Add(this.txtIDFunc);
            this.Controls.Add(this.cmbEstFunc);
            this.Controls.Add(this.mtxCEPFunc);
            this.Controls.Add(this.lblCEPFunc);
            this.Controls.Add(this.btnAdFotoFunc);
            this.Controls.Add(this.picFotoFunc);
            this.Controls.Add(this.btnCancFunc);
            this.Controls.Add(this.btnSalvarFunc);
            this.Controls.Add(this.txtCidFunc);
            this.Controls.Add(this.txtBairFunc);
            this.Controls.Add(this.lblCidFunc);
            this.Controls.Add(this.lblEstFunc);
            this.Controls.Add(this.lblBairFunc);
            this.Controls.Add(this.txtNumFunc);
            this.Controls.Add(this.lblNumFunc);
            this.Controls.Add(this.mtxTelFunc);
            this.Controls.Add(this.mtxDataFunc);
            this.Controls.Add(this.mtxCPFFunc);
            this.Controls.Add(this.txtSenhaFunc);
            this.Controls.Add(this.txtLoginFunc);
            this.Controls.Add(this.txtEmailFunc);
            this.Controls.Add(this.txtRuaFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblSenhaFunc);
            this.Controls.Add(this.lblLoginFunc);
            this.Controls.Add(this.lblEmailFunc);
            this.Controls.Add(this.lblTelFunc);
            this.Controls.Add(this.lblRuaFunc);
            this.Controls.Add(this.lblDataFunc);
            this.Controls.Add(this.lblNomeFunc);
            this.Controls.Add(this.lblCPFFunc);
            this.MaximizeBox = false;
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbEstFunc;
        private System.Windows.Forms.MaskedTextBox mtxCEPFunc;
        private System.Windows.Forms.Label lblCEPFunc;
        private System.Windows.Forms.Button btnAdFotoFunc;
        private System.Windows.Forms.PictureBox picFotoFunc;
        private System.Windows.Forms.Button btnCancFunc;
        private System.Windows.Forms.Button btnSalvarFunc;
        private System.Windows.Forms.TextBox txtCidFunc;
        private System.Windows.Forms.TextBox txtBairFunc;
        private System.Windows.Forms.Label lblCidFunc;
        private System.Windows.Forms.Label lblEstFunc;
        private System.Windows.Forms.Label lblBairFunc;
        private System.Windows.Forms.TextBox txtNumFunc;
        private System.Windows.Forms.Label lblNumFunc;
        private System.Windows.Forms.MaskedTextBox mtxTelFunc;
        private System.Windows.Forms.MaskedTextBox mtxDataFunc;
        private System.Windows.Forms.MaskedTextBox mtxCPFFunc;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.TextBox txtLoginFunc;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.TextBox txtRuaFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label lblSenhaFunc;
        private System.Windows.Forms.Label lblLoginFunc;
        private System.Windows.Forms.Label lblEmailFunc;
        private System.Windows.Forms.Label lblTelFunc;
        private System.Windows.Forms.Label lblRuaFunc;
        private System.Windows.Forms.Label lblDataFunc;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblCPFFunc;
        private System.Windows.Forms.OpenFileDialog ofdLogo;
        private System.Windows.Forms.Label lblIDFunc;
        private System.Windows.Forms.TextBox txtIDFunc;
    }
}