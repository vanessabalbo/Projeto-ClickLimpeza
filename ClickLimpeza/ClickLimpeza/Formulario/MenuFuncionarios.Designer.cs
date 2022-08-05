namespace ClickLimpeza
{
    partial class MenuFuncionarios
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
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblCargoCad = new System.Windows.Forms.Label();
            this.cmbCargoCad = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTelefoneCad = new System.Windows.Forms.TextBox();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblTelefoneCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.lblCargoEdit = new System.Windows.Forms.Label();
            this.cmbCargoEdit = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtTelefoneEdi = new System.Windows.Forms.TextBox();
            this.txtEmailEdi = new System.Windows.Forms.TextBox();
            this.txtNomeEdi = new System.Windows.Forms.TextBox();
            this.lblEmailEdi = new System.Windows.Forms.Label();
            this.lblTelefoneEdi = new System.Windows.Forms.Label();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblETelefoneApagar = new System.Windows.Forms.Label();
            this.lblEmailApagar = new System.Windows.Forms.Label();
            this.lblNomeApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(12, 12);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(560, 308);
            this.dgvFuncionario.TabIndex = 0;
            this.dgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.lblCargoCad);
            this.grbCadastro.Controls.Add(this.cmbCargoCad);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txtTelefoneCad);
            this.grbCadastro.Controls.Add(this.txtEmailCad);
            this.grbCadastro.Controls.Add(this.txtNomeCad);
            this.grbCadastro.Controls.Add(this.lblEmailCad);
            this.grbCadastro.Controls.Add(this.lblTelefoneCad);
            this.grbCadastro.Controls.Add(this.lblNomeCad);
            this.grbCadastro.Location = new System.Drawing.Point(588, 12);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(187, 244);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblCargoCad
            // 
            this.lblCargoCad.AutoSize = true;
            this.lblCargoCad.Location = new System.Drawing.Point(6, 142);
            this.lblCargoCad.Name = "lblCargoCad";
            this.lblCargoCad.Size = new System.Drawing.Size(38, 13);
            this.lblCargoCad.TabIndex = 8;
            this.lblCargoCad.Text = "Cargo:";
            // 
            // cmbCargoCad
            // 
            this.cmbCargoCad.FormattingEnabled = true;
            this.cmbCargoCad.Location = new System.Drawing.Point(9, 158);
            this.cmbCargoCad.Name = "cmbCargoCad";
            this.cmbCargoCad.Size = new System.Drawing.Size(121, 21);
            this.cmbCargoCad.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 196);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(175, 42);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTelefoneCad
            // 
            this.txtTelefoneCad.Location = new System.Drawing.Point(9, 119);
            this.txtTelefoneCad.Name = "txtTelefoneCad";
            this.txtTelefoneCad.Size = new System.Drawing.Size(111, 20);
            this.txtTelefoneCad.TabIndex = 5;
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.Location = new System.Drawing.Point(9, 80);
            this.txtEmailCad.Name = "txtEmailCad";
            this.txtEmailCad.Size = new System.Drawing.Size(140, 20);
            this.txtEmailCad.TabIndex = 4;
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Location = new System.Drawing.Point(9, 41);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(140, 20);
            this.txtNomeCad.TabIndex = 3;
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(6, 64);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 2;
            this.lblEmailCad.Text = "Email:";
            // 
            // lblTelefoneCad
            // 
            this.lblTelefoneCad.AutoSize = true;
            this.lblTelefoneCad.Location = new System.Drawing.Point(6, 103);
            this.lblTelefoneCad.Name = "lblTelefoneCad";
            this.lblTelefoneCad.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneCad.TabIndex = 1;
            this.lblTelefoneCad.Text = "Telefone:";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(3, 25);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome Completo:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.lblCargoEdit);
            this.grbEditar.Controls.Add(this.cmbCargoEdit);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txtTelefoneEdi);
            this.grbEditar.Controls.Add(this.txtEmailEdi);
            this.grbEditar.Controls.Add(this.txtNomeEdi);
            this.grbEditar.Controls.Add(this.lblEmailEdi);
            this.grbEditar.Controls.Add(this.lblTelefoneEdi);
            this.grbEditar.Controls.Add(this.lblNomeEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(588, 256);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(187, 243);
            this.grbEditar.TabIndex = 8;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // lblCargoEdit
            // 
            this.lblCargoEdit.AutoSize = true;
            this.lblCargoEdit.Location = new System.Drawing.Point(6, 145);
            this.lblCargoEdit.Name = "lblCargoEdit";
            this.lblCargoEdit.Size = new System.Drawing.Size(38, 13);
            this.lblCargoEdit.TabIndex = 9;
            this.lblCargoEdit.Text = "Cargo:";
            // 
            // cmbCargoEdit
            // 
            this.cmbCargoEdit.FormattingEnabled = true;
            this.cmbCargoEdit.Location = new System.Drawing.Point(9, 163);
            this.cmbCargoEdit.Name = "cmbCargoEdit";
            this.cmbCargoEdit.Size = new System.Drawing.Size(121, 21);
            this.cmbCargoEdit.TabIndex = 8;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 192);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 42);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Enter += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtTelefoneEdi
            // 
            this.txtTelefoneEdi.Location = new System.Drawing.Point(9, 120);
            this.txtTelefoneEdi.Name = "txtTelefoneEdi";
            this.txtTelefoneEdi.Size = new System.Drawing.Size(111, 20);
            this.txtTelefoneEdi.TabIndex = 5;
            // 
            // txtEmailEdi
            // 
            this.txtEmailEdi.Location = new System.Drawing.Point(9, 80);
            this.txtEmailEdi.Name = "txtEmailEdi";
            this.txtEmailEdi.Size = new System.Drawing.Size(140, 20);
            this.txtEmailEdi.TabIndex = 4;
            // 
            // txtNomeEdi
            // 
            this.txtNomeEdi.Location = new System.Drawing.Point(9, 41);
            this.txtNomeEdi.Name = "txtNomeEdi";
            this.txtNomeEdi.Size = new System.Drawing.Size(140, 20);
            this.txtNomeEdi.TabIndex = 3;
            // 
            // lblEmailEdi
            // 
            this.lblEmailEdi.AutoSize = true;
            this.lblEmailEdi.Location = new System.Drawing.Point(6, 64);
            this.lblEmailEdi.Name = "lblEmailEdi";
            this.lblEmailEdi.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEdi.TabIndex = 2;
            this.lblEmailEdi.Text = "Email:";
            // 
            // lblTelefoneEdi
            // 
            this.lblTelefoneEdi.AutoSize = true;
            this.lblTelefoneEdi.Location = new System.Drawing.Point(6, 103);
            this.lblTelefoneEdi.Name = "lblTelefoneEdi";
            this.lblTelefoneEdi.Size = new System.Drawing.Size(81, 13);
            this.lblTelefoneEdi.TabIndex = 1;
            this.lblTelefoneEdi.Text = "Novo Telefone:";
            // 
            // lblNomeEdi
            // 
            this.lblNomeEdi.AutoSize = true;
            this.lblNomeEdi.Location = new System.Drawing.Point(6, 25);
            this.lblNomeEdi.Name = "lblNomeEdi";
            this.lblNomeEdi.Size = new System.Drawing.Size(85, 13);
            this.lblNomeEdi.TabIndex = 0;
            this.lblNomeEdi.Text = "Nome Completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblETelefoneApagar);
            this.grbApagar.Controls.Add(this.lblEmailApagar);
            this.grbApagar.Controls.Add(this.lblNomeApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(12, 343);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(559, 120);
            this.grbApagar.TabIndex = 9;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(443, 68);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(96, 35);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblETelefoneApagar
            // 
            this.lblETelefoneApagar.AutoSize = true;
            this.lblETelefoneApagar.Location = new System.Drawing.Point(6, 79);
            this.lblETelefoneApagar.Name = "lblETelefoneApagar";
            this.lblETelefoneApagar.Size = new System.Drawing.Size(0, 13);
            this.lblETelefoneApagar.TabIndex = 2;
            // 
            // lblEmailApagar
            // 
            this.lblEmailApagar.AutoSize = true;
            this.lblEmailApagar.Location = new System.Drawing.Point(6, 58);
            this.lblEmailApagar.Name = "lblEmailApagar";
            this.lblEmailApagar.Size = new System.Drawing.Size(0, 13);
            this.lblEmailApagar.TabIndex = 1;
            // 
            // lblNomeApagar
            // 
            this.lblNomeApagar.AutoSize = true;
            this.lblNomeApagar.Location = new System.Drawing.Point(6, 35);
            this.lblNomeApagar.Name = "lblNomeApagar";
            this.lblNomeApagar.Size = new System.Drawing.Size(0, 13);
            this.lblNomeApagar.TabIndex = 0;
            // 
            // MenuFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 502);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvFuncionario);
            this.Name = "MenuFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtTelefoneCad;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblTelefoneCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtTelefoneEdi;
        private System.Windows.Forms.TextBox txtEmailEdi;
        private System.Windows.Forms.TextBox txtNomeEdi;
        private System.Windows.Forms.Label lblEmailEdi;
        private System.Windows.Forms.Label lblTelefoneEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblETelefoneApagar;
        private System.Windows.Forms.Label lblEmailApagar;
        private System.Windows.Forms.Label lblNomeApagar;
        private System.Windows.Forms.ComboBox cmbCargoCad;
        private System.Windows.Forms.Label lblCargoCad;
        private System.Windows.Forms.Label lblCargoEdit;
        private System.Windows.Forms.ComboBox cmbCargoEdit;
    }
}