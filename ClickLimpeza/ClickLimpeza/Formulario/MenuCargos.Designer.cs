namespace ClickLimpeza.Formulario
{
    partial class MenuCargos
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
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblNomeApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtSalarioEdi = new System.Windows.Forms.TextBox();
            this.lblSalariodi = new System.Windows.Forms.Label();
            this.txtCargoEdi = new System.Windows.Forms.TextBox();
            this.lblCargoEdi = new System.Windows.Forms.Label();
            this.grdCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSalarioCad = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtCargoCad = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.dgvCargo = new System.Windows.Forms.DataGridView();
            this.grbApagar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grdCadastrar.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.lblNomeApagar);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(77, 480);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(267, 47);
            this.grbApagar.TabIndex = 17;
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
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txtSalarioEdi);
            this.grbEditar.Controls.Add(this.lblSalariodi);
            this.grbEditar.Controls.Add(this.txtCargoEdi);
            this.grbEditar.Controls.Add(this.lblCargoEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(229, 337);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(133, 140);
            this.grbEditar.TabIndex = 16;
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
            // txtSalarioEdi
            // 
            this.txtSalarioEdi.Location = new System.Drawing.Point(15, 85);
            this.txtSalarioEdi.Name = "txtSalarioEdi";
            this.txtSalarioEdi.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioEdi.TabIndex = 5;
            // 
            // lblSalariodi
            // 
            this.lblSalariodi.AutoSize = true;
            this.lblSalariodi.Location = new System.Drawing.Point(12, 69);
            this.lblSalariodi.Name = "lblSalariodi";
            this.lblSalariodi.Size = new System.Drawing.Size(42, 13);
            this.lblSalariodi.TabIndex = 4;
            this.lblSalariodi.Text = "Salario:";
            // 
            // txtCargoEdi
            // 
            this.txtCargoEdi.Location = new System.Drawing.Point(15, 42);
            this.txtCargoEdi.Name = "txtCargoEdi";
            this.txtCargoEdi.Size = new System.Drawing.Size(100, 20);
            this.txtCargoEdi.TabIndex = 3;
            // 
            // lblCargoEdi
            // 
            this.lblCargoEdi.AutoSize = true;
            this.lblCargoEdi.Location = new System.Drawing.Point(12, 26);
            this.lblCargoEdi.Name = "lblCargoEdi";
            this.lblCargoEdi.Size = new System.Drawing.Size(38, 13);
            this.lblCargoEdi.TabIndex = 2;
            this.lblCargoEdi.Text = "Cargo:";
            // 
            // grdCadastrar
            // 
            this.grdCadastrar.Controls.Add(this.btnCadastrar);
            this.grdCadastrar.Controls.Add(this.txtSalarioCad);
            this.grdCadastrar.Controls.Add(this.lblSalario);
            this.grdCadastrar.Controls.Add(this.txtCargoCad);
            this.grdCadastrar.Controls.Add(this.lblCargo);
            this.grdCadastrar.Location = new System.Drawing.Point(62, 337);
            this.grdCadastrar.Name = "grdCadastrar";
            this.grdCadastrar.Size = new System.Drawing.Size(133, 140);
            this.grdCadastrar.TabIndex = 15;
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
            // txtSalarioCad
            // 
            this.txtSalarioCad.Location = new System.Drawing.Point(15, 85);
            this.txtSalarioCad.Name = "txtSalarioCad";
            this.txtSalarioCad.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioCad.TabIndex = 5;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 69);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario:";
            // 
            // txtCargoCad
            // 
            this.txtCargoCad.Location = new System.Drawing.Point(15, 42);
            this.txtCargoCad.Name = "txtCargoCad";
            this.txtCargoCad.Size = new System.Drawing.Size(100, 20);
            this.txtCargoCad.TabIndex = 3;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(12, 26);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo:";
            // 
            // pnlTopo
            // 
            this.pnlTopo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTopo.Controls.Add(this.dgvCargo);
            this.pnlTopo.Location = new System.Drawing.Point(3, -18);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(403, 349);
            this.pnlTopo.TabIndex = 14;
            // 
            // dgvCargo
            // 
            this.dgvCargo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCargo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargo.Location = new System.Drawing.Point(-7, 16);
            this.dgvCargo.Name = "dgvCargo";
            this.dgvCargo.Size = new System.Drawing.Size(408, 331);
            this.dgvCargo.TabIndex = 2;
            this.dgvCargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargo_CellClick);
            // 
            // MenuCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 534);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grdCadastrar);
            this.Controls.Add(this.pnlTopo);
            this.Name = "MenuCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCargos";
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grdCadastrar.ResumeLayout(false);
            this.grdCadastrar.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblNomeApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtSalarioEdi;
        private System.Windows.Forms.Label lblSalariodi;
        private System.Windows.Forms.TextBox txtCargoEdi;
        private System.Windows.Forms.Label lblCargoEdi;
        private System.Windows.Forms.GroupBox grdCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSalarioCad;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtCargoCad;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.DataGridView dgvCargo;
    }
}