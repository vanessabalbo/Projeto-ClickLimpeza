namespace ClickLimpeza.Formulario
{
    partial class MenuServicos
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
            this.lblServico = new System.Windows.Forms.Label();
            this.txtServicoCad = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorCad = new System.Windows.Forms.TextBox();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.grdCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtValorEdi = new System.Windows.Forms.TextBox();
            this.lblValorEdi = new System.Windows.Forms.Label();
            this.txtServicoEdi = new System.Windows.Forms.TextBox();
            this.lblServicoEdi = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblNomeApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.grdCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(12, 26);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(46, 13);
            this.lblServico.TabIndex = 2;
            this.lblServico.Text = "Serviço:";
            // 
            // txtServicoCad
            // 
            this.txtServicoCad.Location = new System.Drawing.Point(15, 42);
            this.txtServicoCad.Name = "txtServicoCad";
            this.txtServicoCad.Size = new System.Drawing.Size(100, 20);
            this.txtServicoCad.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 69);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // txtValorCad
            // 
            this.txtValorCad.Location = new System.Drawing.Point(15, 85);
            this.txtValorCad.Name = "txtValorCad";
            this.txtValorCad.Size = new System.Drawing.Size(100, 20);
            this.txtValorCad.TabIndex = 5;
            // 
            // pnlTopo
            // 
            this.pnlTopo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTopo.Controls.Add(this.dgvServico);
            this.pnlTopo.Location = new System.Drawing.Point(-12, -10);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(403, 340);
            this.pnlTopo.TabIndex = 10;
            // 
            // dgvServico
            // 
            this.dgvServico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServico.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvServico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(3, 13);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.Size = new System.Drawing.Size(398, 325);
            this.dgvServico.TabIndex = 2;
            this.dgvServico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellClick);
            // 
            // grdCadastrar
            // 
            this.grdCadastrar.Controls.Add(this.btnCadastrar);
            this.grdCadastrar.Controls.Add(this.txtValorCad);
            this.grdCadastrar.Controls.Add(this.lblValor);
            this.grdCadastrar.Controls.Add(this.txtServicoCad);
            this.grdCadastrar.Controls.Add(this.lblServico);
            this.grdCadastrar.Location = new System.Drawing.Point(41, 336);
            this.grdCadastrar.Name = "grdCadastrar";
            this.grdCadastrar.Size = new System.Drawing.Size(133, 140);
            this.grdCadastrar.TabIndex = 11;
            this.grdCadastrar.TabStop = false;
            this.grdCadastrar.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 111);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 26);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txtValorEdi);
            this.grbEditar.Controls.Add(this.lblValorEdi);
            this.grbEditar.Controls.Add(this.txtServicoEdi);
            this.grbEditar.Controls.Add(this.lblServicoEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(208, 336);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(133, 140);
            this.grbEditar.TabIndex = 12;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(15, 111);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 26);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtValorEdi
            // 
            this.txtValorEdi.Location = new System.Drawing.Point(15, 85);
            this.txtValorEdi.Name = "txtValorEdi";
            this.txtValorEdi.Size = new System.Drawing.Size(100, 20);
            this.txtValorEdi.TabIndex = 5;
            // 
            // lblValorEdi
            // 
            this.lblValorEdi.AutoSize = true;
            this.lblValorEdi.Location = new System.Drawing.Point(12, 69);
            this.lblValorEdi.Name = "lblValorEdi";
            this.lblValorEdi.Size = new System.Drawing.Size(34, 13);
            this.lblValorEdi.TabIndex = 4;
            this.lblValorEdi.Text = "Valor:";
            // 
            // txtServicoEdi
            // 
            this.txtServicoEdi.Location = new System.Drawing.Point(15, 42);
            this.txtServicoEdi.Name = "txtServicoEdi";
            this.txtServicoEdi.Size = new System.Drawing.Size(100, 20);
            this.txtServicoEdi.TabIndex = 3;
            // 
            // lblServicoEdi
            // 
            this.lblServicoEdi.AutoSize = true;
            this.lblServicoEdi.Location = new System.Drawing.Point(12, 26);
            this.lblServicoEdi.Name = "lblServicoEdi";
            this.lblServicoEdi.Size = new System.Drawing.Size(46, 13);
            this.lblServicoEdi.TabIndex = 2;
            this.lblServicoEdi.Text = "Serviço:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.lblNomeApagar);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(56, 479);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(267, 47);
            this.grbApagar.TabIndex = 13;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblNomeApagar
            // 
            this.lblNomeApagar.AutoSize = true;
            this.lblNomeApagar.Location = new System.Drawing.Point(24, 21);
            this.lblNomeApagar.Name = "lblNomeApagar";
            this.lblNomeApagar.Size = new System.Drawing.Size(0, 13);
            this.lblNomeApagar.TabIndex = 8;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(161, 19);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(96, 22);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // MenuServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 556);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grdCadastrar);
            this.Controls.Add(this.pnlTopo);
            this.Name = "MenuServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuServicos";
            this.pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.grdCadastrar.ResumeLayout(false);
            this.grdCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.TextBox txtServicoCad;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValorCad;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.GroupBox grdCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtValorEdi;
        private System.Windows.Forms.Label lblValorEdi;
        private System.Windows.Forms.TextBox txtServicoEdi;
        private System.Windows.Forms.Label lblServicoEdi;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblNomeApagar;
    }
}