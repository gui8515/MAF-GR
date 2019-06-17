namespace MAF_GR_Locadora_Veículos
{
    partial class frmCadVeiculo
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
            this.txtRenVeiculo = new System.Windows.Forms.TextBox();
            this.cmbUFVeiculo = new System.Windows.Forms.ComboBox();
            this.lblUFVeiculo = new System.Windows.Forms.Label();
            this.txtKilomVeiculo = new System.Windows.Forms.TextBox();
            this.lblKilomVeiculo = new System.Windows.Forms.Label();
            this.cmbStatusVeiculo = new System.Windows.Forms.ComboBox();
            this.lblStatusVeiculo = new System.Windows.Forms.Label();
            this.cmbCategVeiculo = new System.Windows.Forms.ComboBox();
            this.lblCategVeiculo = new System.Windows.Forms.Label();
            this.cmbModVeiculo = new System.Windows.Forms.ComboBox();
            this.lblModVeiculo = new System.Windows.Forms.Label();
            this.cmbFabVeiculo = new System.Windows.Forms.ComboBox();
            this.lblRenVeiculo = new System.Windows.Forms.Label();
            this.lblFabVeiculo = new System.Windows.Forms.Label();
            this.mtxPlacaVeiculo = new System.Windows.Forms.MaskedTextBox();
            this.txtCorVeiculo = new System.Windows.Forms.TextBox();
            this.lblCorVeiculo = new System.Windows.Forms.Label();
            this.btnAdFotoVeiculo = new System.Windows.Forms.Button();
            this.btnCancVeiculo = new System.Windows.Forms.Button();
            this.btnSalvarVeiculo = new System.Windows.Forms.Button();
            this.txtMarcVeiculo = new System.Windows.Forms.TextBox();
            this.lblMarcVeiculo = new System.Windows.Forms.Label();
            this.lblPlacaVeiculo = new System.Windows.Forms.Label();
            this.lblValorLocacao = new System.Windows.Forms.Label();
            this.txtValorLocacao = new System.Windows.Forms.TextBox();
            this.picFotoVeiculo = new System.Windows.Forms.PictureBox();
            this.ofdLogo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRenVeiculo
            // 
            this.txtRenVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRenVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenVeiculo.Location = new System.Drawing.Point(152, 72);
            this.txtRenVeiculo.Name = "txtRenVeiculo";
            this.txtRenVeiculo.Size = new System.Drawing.Size(170, 22);
            this.txtRenVeiculo.TabIndex = 3;
            // 
            // cmbUFVeiculo
            // 
            this.cmbUFVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUFVeiculo.DropDownHeight = 100;
            this.cmbUFVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUFVeiculo.FormattingEnabled = true;
            this.cmbUFVeiculo.IntegralHeight = false;
            this.cmbUFVeiculo.Location = new System.Drawing.Point(372, 23);
            this.cmbUFVeiculo.Name = "cmbUFVeiculo";
            this.cmbUFVeiculo.Size = new System.Drawing.Size(80, 24);
            this.cmbUFVeiculo.TabIndex = 2;
            // 
            // lblUFVeiculo
            // 
            this.lblUFVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUFVeiculo.AutoSize = true;
            this.lblUFVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFVeiculo.Location = new System.Drawing.Point(338, 31);
            this.lblUFVeiculo.Name = "lblUFVeiculo";
            this.lblUFVeiculo.Size = new System.Drawing.Size(28, 16);
            this.lblUFVeiculo.TabIndex = 0;
            this.lblUFVeiculo.Text = "UF";
            // 
            // txtKilomVeiculo
            // 
            this.txtKilomVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKilomVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilomVeiculo.Location = new System.Drawing.Point(152, 348);
            this.txtKilomVeiculo.Name = "txtKilomVeiculo";
            this.txtKilomVeiculo.Size = new System.Drawing.Size(170, 22);
            this.txtKilomVeiculo.TabIndex = 9;
            // 
            // lblKilomVeiculo
            // 
            this.lblKilomVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKilomVeiculo.AutoSize = true;
            this.lblKilomVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilomVeiculo.Location = new System.Drawing.Point(43, 354);
            this.lblKilomVeiculo.Name = "lblKilomVeiculo";
            this.lblKilomVeiculo.Size = new System.Drawing.Size(103, 16);
            this.lblKilomVeiculo.TabIndex = 0;
            this.lblKilomVeiculo.Text = "Kilometragem";
            // 
            // cmbStatusVeiculo
            // 
            this.cmbStatusVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatusVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusVeiculo.FormattingEnabled = true;
            this.cmbStatusVeiculo.Location = new System.Drawing.Point(152, 393);
            this.cmbStatusVeiculo.Name = "cmbStatusVeiculo";
            this.cmbStatusVeiculo.Size = new System.Drawing.Size(170, 24);
            this.cmbStatusVeiculo.TabIndex = 10;
            // 
            // lblStatusVeiculo
            // 
            this.lblStatusVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatusVeiculo.AutoSize = true;
            this.lblStatusVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusVeiculo.Location = new System.Drawing.Point(39, 401);
            this.lblStatusVeiculo.Name = "lblStatusVeiculo";
            this.lblStatusVeiculo.Size = new System.Drawing.Size(107, 16);
            this.lblStatusVeiculo.TabIndex = 0;
            this.lblStatusVeiculo.Text = "Status Veículo";
            // 
            // cmbCategVeiculo
            // 
            this.cmbCategVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategVeiculo.FormattingEnabled = true;
            this.cmbCategVeiculo.Location = new System.Drawing.Point(152, 301);
            this.cmbCategVeiculo.Name = "cmbCategVeiculo";
            this.cmbCategVeiculo.Size = new System.Drawing.Size(170, 24);
            this.cmbCategVeiculo.TabIndex = 8;
            // 
            // lblCategVeiculo
            // 
            this.lblCategVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategVeiculo.AutoSize = true;
            this.lblCategVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategVeiculo.Location = new System.Drawing.Point(70, 309);
            this.lblCategVeiculo.Name = "lblCategVeiculo";
            this.lblCategVeiculo.Size = new System.Drawing.Size(76, 16);
            this.lblCategVeiculo.TabIndex = 0;
            this.lblCategVeiculo.Text = "Categoria";
            // 
            // cmbModVeiculo
            // 
            this.cmbModVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbModVeiculo.DropDownHeight = 100;
            this.cmbModVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModVeiculo.FormattingEnabled = true;
            this.cmbModVeiculo.IntegralHeight = false;
            this.cmbModVeiculo.Location = new System.Drawing.Point(152, 254);
            this.cmbModVeiculo.Name = "cmbModVeiculo";
            this.cmbModVeiculo.Size = new System.Drawing.Size(80, 24);
            this.cmbModVeiculo.TabIndex = 7;
            // 
            // lblModVeiculo
            // 
            this.lblModVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModVeiculo.AutoSize = true;
            this.lblModVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModVeiculo.Location = new System.Drawing.Point(86, 262);
            this.lblModVeiculo.Name = "lblModVeiculo";
            this.lblModVeiculo.Size = new System.Drawing.Size(60, 16);
            this.lblModVeiculo.TabIndex = 0;
            this.lblModVeiculo.Text = "Modelo";
            // 
            // cmbFabVeiculo
            // 
            this.cmbFabVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFabVeiculo.DropDownHeight = 100;
            this.cmbFabVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFabVeiculo.FormattingEnabled = true;
            this.cmbFabVeiculo.IntegralHeight = false;
            this.cmbFabVeiculo.Location = new System.Drawing.Point(152, 207);
            this.cmbFabVeiculo.Name = "cmbFabVeiculo";
            this.cmbFabVeiculo.Size = new System.Drawing.Size(80, 24);
            this.cmbFabVeiculo.TabIndex = 6;
            // 
            // lblRenVeiculo
            // 
            this.lblRenVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRenVeiculo.AutoSize = true;
            this.lblRenVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenVeiculo.Location = new System.Drawing.Point(72, 78);
            this.lblRenVeiculo.Name = "lblRenVeiculo";
            this.lblRenVeiculo.Size = new System.Drawing.Size(74, 16);
            this.lblRenVeiculo.TabIndex = 0;
            this.lblRenVeiculo.Text = "Renavam";
            // 
            // lblFabVeiculo
            // 
            this.lblFabVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFabVeiculo.AutoSize = true;
            this.lblFabVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabVeiculo.Location = new System.Drawing.Point(59, 215);
            this.lblFabVeiculo.Name = "lblFabVeiculo";
            this.lblFabVeiculo.Size = new System.Drawing.Size(87, 16);
            this.lblFabVeiculo.TabIndex = 0;
            this.lblFabVeiculo.Text = "Fabricação";
            // 
            // mtxPlacaVeiculo
            // 
            this.mtxPlacaVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxPlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxPlacaVeiculo.Location = new System.Drawing.Point(152, 25);
            this.mtxPlacaVeiculo.Mask = "AAA-0000";
            this.mtxPlacaVeiculo.Name = "mtxPlacaVeiculo";
            this.mtxPlacaVeiculo.Size = new System.Drawing.Size(80, 22);
            this.mtxPlacaVeiculo.TabIndex = 1;
            // 
            // txtCorVeiculo
            // 
            this.txtCorVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorVeiculo.Location = new System.Drawing.Point(152, 162);
            this.txtCorVeiculo.Name = "txtCorVeiculo";
            this.txtCorVeiculo.Size = new System.Drawing.Size(170, 22);
            this.txtCorVeiculo.TabIndex = 4;
            // 
            // lblCorVeiculo
            // 
            this.lblCorVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorVeiculo.AutoSize = true;
            this.lblCorVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorVeiculo.Location = new System.Drawing.Point(114, 168);
            this.lblCorVeiculo.Name = "lblCorVeiculo";
            this.lblCorVeiculo.Size = new System.Drawing.Size(32, 16);
            this.lblCorVeiculo.TabIndex = 0;
            this.lblCorVeiculo.Text = "Cor";
            // 
            // btnAdFotoVeiculo
            // 
            this.btnAdFotoVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdFotoVeiculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdFotoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdFotoVeiculo.Location = new System.Drawing.Point(651, 232);
            this.btnAdFotoVeiculo.Name = "btnAdFotoVeiculo";
            this.btnAdFotoVeiculo.Size = new System.Drawing.Size(130, 43);
            this.btnAdFotoVeiculo.TabIndex = 14;
            this.btnAdFotoVeiculo.Text = "Adicionar Foto";
            this.btnAdFotoVeiculo.UseVisualStyleBackColor = false;
            this.btnAdFotoVeiculo.Click += new System.EventHandler(this.btnAdFotoVeiculo_Click);
            // 
            // btnCancVeiculo
            // 
            this.btnCancVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancVeiculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancVeiculo.Location = new System.Drawing.Point(759, 458);
            this.btnCancVeiculo.Name = "btnCancVeiculo";
            this.btnCancVeiculo.Size = new System.Drawing.Size(130, 43);
            this.btnCancVeiculo.TabIndex = 13;
            this.btnCancVeiculo.Text = "Cancelar";
            this.btnCancVeiculo.UseVisualStyleBackColor = false;
            this.btnCancVeiculo.Click += new System.EventHandler(this.btnCancVeiculo_Click);
            // 
            // btnSalvarVeiculo
            // 
            this.btnSalvarVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarVeiculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarVeiculo.Location = new System.Drawing.Point(623, 458);
            this.btnSalvarVeiculo.Name = "btnSalvarVeiculo";
            this.btnSalvarVeiculo.Size = new System.Drawing.Size(130, 43);
            this.btnSalvarVeiculo.TabIndex = 12;
            this.btnSalvarVeiculo.Text = "Salvar";
            this.btnSalvarVeiculo.UseVisualStyleBackColor = false;
            this.btnSalvarVeiculo.Click += new System.EventHandler(this.btnSalvarVeiculo_Click);
            // 
            // txtMarcVeiculo
            // 
            this.txtMarcVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarcVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcVeiculo.Location = new System.Drawing.Point(152, 116);
            this.txtMarcVeiculo.Name = "txtMarcVeiculo";
            this.txtMarcVeiculo.Size = new System.Drawing.Size(386, 22);
            this.txtMarcVeiculo.TabIndex = 5;
            // 
            // lblMarcVeiculo
            // 
            this.lblMarcVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarcVeiculo.AutoSize = true;
            this.lblMarcVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcVeiculo.Location = new System.Drawing.Point(95, 122);
            this.lblMarcVeiculo.Name = "lblMarcVeiculo";
            this.lblMarcVeiculo.Size = new System.Drawing.Size(51, 16);
            this.lblMarcVeiculo.TabIndex = 0;
            this.lblMarcVeiculo.Text = "Marca";
            // 
            // lblPlacaVeiculo
            // 
            this.lblPlacaVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlacaVeiculo.AutoSize = true;
            this.lblPlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaVeiculo.Location = new System.Drawing.Point(42, 31);
            this.lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            this.lblPlacaVeiculo.Size = new System.Drawing.Size(104, 16);
            this.lblPlacaVeiculo.TabIndex = 0;
            this.lblPlacaVeiculo.Text = "Placa Veículo";
            // 
            // lblValorLocacao
            // 
            this.lblValorLocacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorLocacao.AutoSize = true;
            this.lblValorLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLocacao.Location = new System.Drawing.Point(37, 447);
            this.lblValorLocacao.Name = "lblValorLocacao";
            this.lblValorLocacao.Size = new System.Drawing.Size(109, 16);
            this.lblValorLocacao.TabIndex = 0;
            this.lblValorLocacao.Text = "Valor Locação";
            // 
            // txtValorLocacao
            // 
            this.txtValorLocacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorLocacao.Location = new System.Drawing.Point(152, 441);
            this.txtValorLocacao.Name = "txtValorLocacao";
            this.txtValorLocacao.Size = new System.Drawing.Size(170, 22);
            this.txtValorLocacao.TabIndex = 11;
            // 
            // picFotoVeiculo
            // 
            this.picFotoVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picFotoVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotoVeiculo.Image = global::MAF_GR_Locadora_Veículos.Properties.Resources.Icone_Foto_Veículo;
            this.picFotoVeiculo.Location = new System.Drawing.Point(544, 12);
            this.picFotoVeiculo.Name = "picFotoVeiculo";
            this.picFotoVeiculo.Size = new System.Drawing.Size(345, 214);
            this.picFotoVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoVeiculo.TabIndex = 105;
            this.picFotoVeiculo.TabStop = false;
            // 
            // ofdLogo
            // 
            this.ofdLogo.FileName = "openFileDialog1";
            this.ofdLogo.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLogo_FileOk);
            // 
            // frmCadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 513);
            this.Controls.Add(this.txtValorLocacao);
            this.Controls.Add(this.lblValorLocacao);
            this.Controls.Add(this.txtRenVeiculo);
            this.Controls.Add(this.cmbUFVeiculo);
            this.Controls.Add(this.lblUFVeiculo);
            this.Controls.Add(this.txtKilomVeiculo);
            this.Controls.Add(this.lblKilomVeiculo);
            this.Controls.Add(this.cmbStatusVeiculo);
            this.Controls.Add(this.lblStatusVeiculo);
            this.Controls.Add(this.cmbCategVeiculo);
            this.Controls.Add(this.lblCategVeiculo);
            this.Controls.Add(this.cmbModVeiculo);
            this.Controls.Add(this.lblModVeiculo);
            this.Controls.Add(this.cmbFabVeiculo);
            this.Controls.Add(this.lblRenVeiculo);
            this.Controls.Add(this.lblFabVeiculo);
            this.Controls.Add(this.mtxPlacaVeiculo);
            this.Controls.Add(this.txtCorVeiculo);
            this.Controls.Add(this.lblCorVeiculo);
            this.Controls.Add(this.btnAdFotoVeiculo);
            this.Controls.Add(this.picFotoVeiculo);
            this.Controls.Add(this.btnCancVeiculo);
            this.Controls.Add(this.btnSalvarVeiculo);
            this.Controls.Add(this.txtMarcVeiculo);
            this.Controls.Add(this.lblMarcVeiculo);
            this.Controls.Add(this.lblPlacaVeiculo);
            this.MaximizeBox = false;
            this.Name = "frmCadVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículo";
            this.Load += new System.EventHandler(this.frmCadVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRenVeiculo;
        private System.Windows.Forms.ComboBox cmbUFVeiculo;
        private System.Windows.Forms.Label lblUFVeiculo;
        private System.Windows.Forms.TextBox txtKilomVeiculo;
        private System.Windows.Forms.Label lblKilomVeiculo;
        private System.Windows.Forms.ComboBox cmbStatusVeiculo;
        private System.Windows.Forms.Label lblStatusVeiculo;
        private System.Windows.Forms.ComboBox cmbCategVeiculo;
        private System.Windows.Forms.Label lblCategVeiculo;
        private System.Windows.Forms.ComboBox cmbModVeiculo;
        private System.Windows.Forms.Label lblModVeiculo;
        private System.Windows.Forms.ComboBox cmbFabVeiculo;
        private System.Windows.Forms.Label lblRenVeiculo;
        private System.Windows.Forms.Label lblFabVeiculo;
        private System.Windows.Forms.MaskedTextBox mtxPlacaVeiculo;
        private System.Windows.Forms.TextBox txtCorVeiculo;
        private System.Windows.Forms.Label lblCorVeiculo;
        private System.Windows.Forms.Button btnAdFotoVeiculo;
        private System.Windows.Forms.PictureBox picFotoVeiculo;
        private System.Windows.Forms.Button btnCancVeiculo;
        private System.Windows.Forms.Button btnSalvarVeiculo;
        private System.Windows.Forms.TextBox txtMarcVeiculo;
        private System.Windows.Forms.Label lblMarcVeiculo;
        private System.Windows.Forms.Label lblPlacaVeiculo;
        private System.Windows.Forms.Label lblValorLocacao;
        private System.Windows.Forms.TextBox txtValorLocacao;
        private System.Windows.Forms.OpenFileDialog ofdLogo;
    }
}