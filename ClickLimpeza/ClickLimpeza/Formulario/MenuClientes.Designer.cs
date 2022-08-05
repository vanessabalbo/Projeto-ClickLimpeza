namespace ClickLimpeza.Formulario
{
    partial class MenuClientes
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txtEnderecoEdi = new System.Windows.Forms.TextBox();
            this.lblEnderecoEdit = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtTelefoneEdi = new System.Windows.Forms.TextBox();
            this.txtEmailEdi = new System.Windows.Forms.TextBox();
            this.txtNomeEdi = new System.Windows.Forms.TextBox();
            this.lblEmailEdi = new System.Windows.Forms.Label();
            this.lblTelefoneEdi = new System.Windows.Forms.Label();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.grbCasdastrar = new System.Windows.Forms.GroupBox();
            this.txtEnderecoCad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTelefoneCad = new System.Windows.Forms.TextBox();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblTelefoneCad = new System.Windows.Forms.Label();
            this.lblNomecad = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblEnderecoApag = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblETelefoneApagar = new System.Windows.Forms.Label();
            this.lblEmailApagar = new System.Windows.Forms.Label();
            this.lblNomeApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.grbEditar.SuspendLayout();
            this.grbCasdastrar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 12);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(560, 426);
            this.dgvCliente.TabIndex = 1;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.txtEnderecoEdi);
            this.grbEditar.Controls.Add(this.lblEnderecoEdit);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txtTelefoneEdi);
            this.grbEditar.Controls.Add(this.txtEmailEdi);
            this.grbEditar.Controls.Add(this.txtNomeEdi);
            this.grbEditar.Controls.Add(this.lblEmailEdi);
            this.grbEditar.Controls.Add(this.lblTelefoneEdi);
            this.grbEditar.Controls.Add(this.lblNomeEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(780, 12);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(187, 243);
            this.grbEditar.TabIndex = 9;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // txtEnderecoEdi
            // 
            this.txtEnderecoEdi.Location = new System.Drawing.Point(9, 166);
            this.txtEnderecoEdi.Name = "txtEnderecoEdi";
            this.txtEnderecoEdi.Size = new System.Drawing.Size(140, 20);
            this.txtEnderecoEdi.TabIndex = 10;
            // 
            // lblEnderecoEdit
            // 
            this.lblEnderecoEdit.AutoSize = true;
            this.lblEnderecoEdit.Location = new System.Drawing.Point(6, 145);
            this.lblEnderecoEdit.Name = "lblEnderecoEdit";
            this.lblEnderecoEdit.Size = new System.Drawing.Size(56, 13);
            this.lblEnderecoEdit.TabIndex = 9;
            this.lblEnderecoEdit.Text = "Endereço:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 192);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 42);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtTelefoneEdi
            // 
            this.txtTelefoneEdi.Location = new System.Drawing.Point(9, 80);
            this.txtTelefoneEdi.Name = "txtTelefoneEdi";
            this.txtTelefoneEdi.Size = new System.Drawing.Size(111, 20);
            this.txtTelefoneEdi.TabIndex = 5;
            // 
            // txtEmailEdi
            // 
            this.txtEmailEdi.Location = new System.Drawing.Point(9, 119);
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
            this.lblEmailEdi.Location = new System.Drawing.Point(6, 103);
            this.lblEmailEdi.Name = "lblEmailEdi";
            this.lblEmailEdi.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEdi.TabIndex = 2;
            this.lblEmailEdi.Text = "Email:";
            // 
            // lblTelefoneEdi
            // 
            this.lblTelefoneEdi.AutoSize = true;
            this.lblTelefoneEdi.Location = new System.Drawing.Point(6, 64);
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
            // grbCasdastrar
            // 
            this.grbCasdastrar.Controls.Add(this.txtEnderecoCad);
            this.grbCasdastrar.Controls.Add(this.label1);
            this.grbCasdastrar.Controls.Add(this.btnCadastrar);
            this.grbCasdastrar.Controls.Add(this.txtTelefoneCad);
            this.grbCasdastrar.Controls.Add(this.txtEmailCad);
            this.grbCasdastrar.Controls.Add(this.txtNomeCad);
            this.grbCasdastrar.Controls.Add(this.lblEmailCad);
            this.grbCasdastrar.Controls.Add(this.lblTelefoneCad);
            this.grbCasdastrar.Controls.Add(this.lblNomecad);
            this.grbCasdastrar.Location = new System.Drawing.Point(587, 12);
            this.grbCasdastrar.Name = "grbCasdastrar";
            this.grbCasdastrar.Size = new System.Drawing.Size(187, 243);
            this.grbCasdastrar.TabIndex = 10;
            this.grbCasdastrar.TabStop = false;
            this.grbCasdastrar.Text = "Cadastrar";
            // 
            // txtEnderecoCad
            // 
            this.txtEnderecoCad.Location = new System.Drawing.Point(9, 166);
            this.txtEnderecoCad.Name = "txtEnderecoCad";
            this.txtEnderecoCad.Size = new System.Drawing.Size(140, 20);
            this.txtEnderecoCad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Endereço:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 192);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(175, 42);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTelefoneCad
            // 
            this.txtTelefoneCad.Location = new System.Drawing.Point(9, 80);
            this.txtTelefoneCad.Name = "txtTelefoneCad";
            this.txtTelefoneCad.Size = new System.Drawing.Size(111, 20);
            this.txtTelefoneCad.TabIndex = 5;
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.Location = new System.Drawing.Point(9, 119);
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
            this.lblEmailCad.Location = new System.Drawing.Point(6, 103);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 2;
            this.lblEmailCad.Text = "Email:";
            // 
            // lblTelefoneCad
            // 
            this.lblTelefoneCad.AutoSize = true;
            this.lblTelefoneCad.Location = new System.Drawing.Point(6, 64);
            this.lblTelefoneCad.Name = "lblTelefoneCad";
            this.lblTelefoneCad.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneCad.TabIndex = 1;
            this.lblTelefoneCad.Text = "Telefone:";
            // 
            // lblNomecad
            // 
            this.lblNomecad.AutoSize = true;
            this.lblNomecad.Location = new System.Drawing.Point(6, 25);
            this.lblNomecad.Name = "lblNomecad";
            this.lblNomecad.Size = new System.Drawing.Size(85, 13);
            this.lblNomecad.TabIndex = 0;
            this.lblNomecad.Text = "Nome Completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.lblEnderecoApag);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblETelefoneApagar);
            this.grbApagar.Controls.Add(this.lblEmailApagar);
            this.grbApagar.Controls.Add(this.lblNomeApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(587, 285);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(380, 129);
            this.grbApagar.TabIndex = 11;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblEnderecoApag
            // 
            this.lblEnderecoApag.AutoSize = true;
            this.lblEnderecoApag.Location = new System.Drawing.Point(6, 99);
            this.lblEnderecoApag.Name = "lblEnderecoApag";
            this.lblEnderecoApag.Size = new System.Drawing.Size(0, 13);
            this.lblEnderecoApag.TabIndex = 8;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(278, 88);
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
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 441);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCasdastrar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.dgvCliente);
            this.Name = "MenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbCasdastrar.ResumeLayout(false);
            this.grbCasdastrar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.TextBox txtEnderecoEdi;
        private System.Windows.Forms.Label lblEnderecoEdit;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtTelefoneEdi;
        private System.Windows.Forms.TextBox txtEmailEdi;
        private System.Windows.Forms.TextBox txtNomeEdi;
        private System.Windows.Forms.Label lblEmailEdi;
        private System.Windows.Forms.Label lblTelefoneEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.GroupBox grbCasdastrar;
        private System.Windows.Forms.TextBox txtEnderecoCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtTelefoneCad;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblTelefoneCad;
        private System.Windows.Forms.Label lblNomecad;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblEnderecoApag;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblETelefoneApagar;
        private System.Windows.Forms.Label lblEmailApagar;
        private System.Windows.Forms.Label lblNomeApagar;
    }
}