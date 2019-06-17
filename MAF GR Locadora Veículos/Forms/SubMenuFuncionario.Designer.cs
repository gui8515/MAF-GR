namespace MAF_GR_Locadora_Veículos.Forms
{
    partial class frmSubMenuFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.btnAltFuncionario = new System.Windows.Forms.Button();
            this.btnExcFuncionario = new System.Windows.Forms.Button();
            this.dgvTab_Funcionario = new System.Windows.Forms.DataGridView();
            this.btnAtualizarTabela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_Funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFuncionario.Location = new System.Drawing.Point(463, 458);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(130, 43);
            this.btnCadFuncionario.TabIndex = 1;
            this.btnCadFuncionario.Text = "Cadastrar";
            this.btnCadFuncionario.UseVisualStyleBackColor = false;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // btnAltFuncionario
            // 
            this.btnAltFuncionario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAltFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltFuncionario.ForeColor = System.Drawing.Color.Green;
            this.btnAltFuncionario.Location = new System.Drawing.Point(611, 458);
            this.btnAltFuncionario.Name = "btnAltFuncionario";
            this.btnAltFuncionario.Size = new System.Drawing.Size(130, 43);
            this.btnAltFuncionario.TabIndex = 2;
            this.btnAltFuncionario.Text = "Alterar";
            this.btnAltFuncionario.UseVisualStyleBackColor = false;
            this.btnAltFuncionario.Click += new System.EventHandler(this.btnAltFuncionario_Click);
            // 
            // btnExcFuncionario
            // 
            this.btnExcFuncionario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcFuncionario.ForeColor = System.Drawing.Color.Red;
            this.btnExcFuncionario.Location = new System.Drawing.Point(759, 458);
            this.btnExcFuncionario.Name = "btnExcFuncionario";
            this.btnExcFuncionario.Size = new System.Drawing.Size(130, 43);
            this.btnExcFuncionario.TabIndex = 3;
            this.btnExcFuncionario.Text = "Excluir";
            this.btnExcFuncionario.UseVisualStyleBackColor = false;
            this.btnExcFuncionario.Click += new System.EventHandler(this.btnExcFuncionario_Click);
            // 
            // dgvTab_Funcionario
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTab_Funcionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTab_Funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab_Funcionario.Location = new System.Drawing.Point(12, 12);
            this.dgvTab_Funcionario.Name = "dgvTab_Funcionario";
            this.dgvTab_Funcionario.Size = new System.Drawing.Size(877, 440);
            this.dgvTab_Funcionario.TabIndex = 4;
            // 
            // btnAtualizarTabela
            // 
            this.btnAtualizarTabela.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtualizarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarTabela.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarTabela.Location = new System.Drawing.Point(12, 458);
            this.btnAtualizarTabela.Name = "btnAtualizarTabela";
            this.btnAtualizarTabela.Size = new System.Drawing.Size(130, 43);
            this.btnAtualizarTabela.TabIndex = 5;
            this.btnAtualizarTabela.Text = "Atualizar";
            this.btnAtualizarTabela.UseVisualStyleBackColor = false;
            this.btnAtualizarTabela.Click += new System.EventHandler(this.btnAtualizarTabela_Click);
            // 
            // frmSubMenuFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(901, 513);
            this.Controls.Add(this.btnAtualizarTabela);
            this.Controls.Add(this.dgvTab_Funcionario);
            this.Controls.Add(this.btnExcFuncionario);
            this.Controls.Add(this.btnAltFuncionario);
            this.Controls.Add(this.btnCadFuncionario);
            this.MaximizeBox = false;
            this.Name = "frmSubMenuFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frmSubMenuFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab_Funcionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.Button btnAltFuncionario;
        private System.Windows.Forms.Button btnExcFuncionario;
        private System.Windows.Forms.DataGridView dgvTab_Funcionario;
        private System.Windows.Forms.Button btnAtualizarTabela;
    }
}