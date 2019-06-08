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
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnCadVeiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadFuncionario.Location = new System.Drawing.Point(252, 112);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(142, 67);
            this.btnCadFuncionario.TabIndex = 0;
            this.btnCadFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadFuncionario.UseVisualStyleBackColor = true;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadCliente.Location = new System.Drawing.Point(457, 112);
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
            this.btnCadVeiculo.Location = new System.Drawing.Point(252, 238);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(142, 67);
            this.btnCadVeiculo.TabIndex = 2;
            this.btnCadVeiculo.Text = "Cadastrar Veículo";
            this.btnCadVeiculo.UseVisualStyleBackColor = true;
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 513);
            this.Controls.Add(this.btnCadVeiculo);
            this.Controls.Add(this.btnCadCliente);
            this.Controls.Add(this.btnCadFuncionario);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnCadVeiculo;
    }
}