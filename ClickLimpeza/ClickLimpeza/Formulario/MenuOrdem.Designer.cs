namespace ClickLimpeza.Formulario
{
    partial class MenuOrdem
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
            this.txtClienteLancar = new System.Windows.Forms.TextBox();
            this.txtEnderecoLancar = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.grbTotal = new System.Windows.Forms.GroupBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdOrdem = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.pnlBaixo = new System.Windows.Forms.Panel();
            this.pnlOrdem = new System.Windows.Forms.Panel();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.dgvOrdem = new System.Windows.Forms.DataGridView();
            this.btnTabelaOrdem = new System.Windows.Forms.Button();
            this.btnTabCliente = new System.Windows.Forms.Button();
            this.grbInfos = new System.Windows.Forms.GroupBox();
            this.chbExecutado = new System.Windows.Forms.CheckBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.lblOrdemAtual = new System.Windows.Forms.Label();
            this.grbExecutar = new System.Windows.Forms.GroupBox();
            this.grbTotal.SuspendLayout();
            this.pnlBaixo.SuspendLayout();
            this.pnlOrdem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdem)).BeginInit();
            this.grbInfos.SuspendLayout();
            this.grbExecutar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClienteLancar
            // 
            this.txtClienteLancar.Enabled = false;
            this.txtClienteLancar.Location = new System.Drawing.Point(77, 62);
            this.txtClienteLancar.Multiline = true;
            this.txtClienteLancar.Name = "txtClienteLancar";
            this.txtClienteLancar.Size = new System.Drawing.Size(338, 25);
            this.txtClienteLancar.TabIndex = 3;
            // 
            // txtEnderecoLancar
            // 
            this.txtEnderecoLancar.Enabled = false;
            this.txtEnderecoLancar.Location = new System.Drawing.Point(65, 19);
            this.txtEnderecoLancar.Multiline = true;
            this.txtEnderecoLancar.Name = "txtEnderecoLancar";
            this.txtEnderecoLancar.Size = new System.Drawing.Size(338, 25);
            this.txtEnderecoLancar.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(29, 65);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(3, 22);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço:";
            // 
            // cmbServico
            // 
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(65, 63);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(121, 21);
            this.cmbServico.TabIndex = 7;
            this.cmbServico.SelectedIndexChanged += new System.EventHandler(this.cmbServico_SelectedIndexChanged);
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(282, 63);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(121, 21);
            this.cmbFuncionario.TabIndex = 8;
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(13, 66);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(46, 13);
            this.lblServico.TabIndex = 9;
            this.lblServico.Text = "Serviço:";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(211, 66);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionario.TabIndex = 10;
            this.lblFuncionario.Text = "Funcionario:";
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(65, 114);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(97, 29);
            this.btnLancar.TabIndex = 11;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // grbTotal
            // 
            this.grbTotal.Controls.Add(this.lblValorTotal);
            this.grbTotal.Location = new System.Drawing.Point(568, 20);
            this.grbTotal.Name = "grbTotal";
            this.grbTotal.Size = new System.Drawing.Size(148, 119);
            this.grbTotal.TabIndex = 12;
            this.grbTotal.TabStop = false;
            this.grbTotal.Text = "Total";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(16, 45);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(39, 25);
            this.lblValorTotal.TabIndex = 0;
            this.lblValorTotal.Text = "R$";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(73, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 20);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Lançar Ordem de Serviço";
            // 
            // lblIdOrdem
            // 
            this.lblIdOrdem.AutoSize = true;
            this.lblIdOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdOrdem.Location = new System.Drawing.Point(196, 29);
            this.lblIdOrdem.Name = "lblIdOrdem";
            this.lblIdOrdem.Size = new System.Drawing.Size(0, 20);
            this.lblIdOrdem.TabIndex = 14;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(29, 36);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(97, 29);
            this.btnEncerrar.TabIndex = 15;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // pnlBaixo
            // 
            this.pnlBaixo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBaixo.Controls.Add(this.pnlOrdem);
            this.pnlBaixo.Controls.Add(this.dgvOrdem);
            this.pnlBaixo.Location = new System.Drawing.Point(-2, 256);
            this.pnlBaixo.Name = "pnlBaixo";
            this.pnlBaixo.Size = new System.Drawing.Size(838, 333);
            this.pnlBaixo.TabIndex = 17;
            // 
            // pnlOrdem
            // 
            this.pnlOrdem.Controls.Add(this.dgvOS);
            this.pnlOrdem.Location = new System.Drawing.Point(3, -2);
            this.pnlOrdem.Name = "pnlOrdem";
            this.pnlOrdem.Size = new System.Drawing.Size(791, 210);
            this.pnlOrdem.TabIndex = 19;
            this.pnlOrdem.Visible = false;
            // 
            // dgvOS
            // 
            this.dgvOS.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Location = new System.Drawing.Point(7, 3);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.Size = new System.Drawing.Size(776, 205);
            this.dgvOS.TabIndex = 5;
            this.dgvOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOS_CellClick);
            // 
            // dgvOrdem
            // 
            this.dgvOrdem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrdem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrdem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdem.Location = new System.Drawing.Point(7, 3);
            this.dgvOrdem.Name = "dgvOrdem";
            this.dgvOrdem.Size = new System.Drawing.Size(776, 205);
            this.dgvOrdem.TabIndex = 4;
            this.dgvOrdem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdem_CellClick);
            // 
            // btnTabelaOrdem
            // 
            this.btnTabelaOrdem.Location = new System.Drawing.Point(671, 207);
            this.btnTabelaOrdem.Name = "btnTabelaOrdem";
            this.btnTabelaOrdem.Size = new System.Drawing.Size(97, 29);
            this.btnTabelaOrdem.TabIndex = 18;
            this.btnTabelaOrdem.Text = "Tabela Ordem";
            this.btnTabelaOrdem.UseVisualStyleBackColor = true;
            this.btnTabelaOrdem.Click += new System.EventHandler(this.btnTabelaOrdem_Click);
            // 
            // btnTabCliente
            // 
            this.btnTabCliente.Location = new System.Drawing.Point(671, 207);
            this.btnTabCliente.Name = "btnTabCliente";
            this.btnTabCliente.Size = new System.Drawing.Size(97, 29);
            this.btnTabCliente.TabIndex = 19;
            this.btnTabCliente.Text = "Tabela Cliente";
            this.btnTabCliente.UseVisualStyleBackColor = true;
            this.btnTabCliente.Click += new System.EventHandler(this.btnTabCliente_Click);
            // 
            // grbInfos
            // 
            this.grbInfos.Controls.Add(this.btnLancar);
            this.grbInfos.Controls.Add(this.lblFuncionario);
            this.grbInfos.Controls.Add(this.lblServico);
            this.grbInfos.Controls.Add(this.cmbFuncionario);
            this.grbInfos.Controls.Add(this.cmbServico);
            this.grbInfos.Controls.Add(this.lblEndereco);
            this.grbInfos.Controls.Add(this.txtEnderecoLancar);
            this.grbInfos.Location = new System.Drawing.Point(10, 93);
            this.grbInfos.Name = "grbInfos";
            this.grbInfos.Size = new System.Drawing.Size(426, 156);
            this.grbInfos.TabIndex = 20;
            this.grbInfos.TabStop = false;
            // 
            // chbExecutado
            // 
            this.chbExecutado.AutoSize = true;
            this.chbExecutado.Location = new System.Drawing.Point(8, 19);
            this.chbExecutado.Name = "chbExecutado";
            this.chbExecutado.Size = new System.Drawing.Size(122, 17);
            this.chbExecutado.TabIndex = 16;
            this.chbExecutado.Text = "Trabalho Executado";
            this.chbExecutado.UseVisualStyleBackColor = true;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.Location = new System.Drawing.Point(668, 186);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(105, 18);
            this.lblTabela.TabIndex = 21;
            this.lblTabela.Text = "Tabela Atual:";
            // 
            // lblOrdemAtual
            // 
            this.lblOrdemAtual.AutoSize = true;
            this.lblOrdemAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdemAtual.Location = new System.Drawing.Point(73, 29);
            this.lblOrdemAtual.Name = "lblOrdemAtual";
            this.lblOrdemAtual.Size = new System.Drawing.Size(102, 20);
            this.lblOrdemAtual.TabIndex = 22;
            this.lblOrdemAtual.Text = "Ordem Atual:";
            // 
            // grbExecutar
            // 
            this.grbExecutar.Controls.Add(this.btnEncerrar);
            this.grbExecutar.Controls.Add(this.chbExecutado);
            this.grbExecutar.Location = new System.Drawing.Point(487, 159);
            this.grbExecutar.Name = "grbExecutar";
            this.grbExecutar.Size = new System.Drawing.Size(136, 82);
            this.grbExecutar.TabIndex = 23;
            this.grbExecutar.TabStop = false;
            this.grbExecutar.Visible = false;
            // 
            // MenuOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 468);
            this.Controls.Add(this.grbExecutar);
            this.Controls.Add(this.lblOrdemAtual);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.grbInfos);
            this.Controls.Add(this.btnTabCliente);
            this.Controls.Add(this.btnTabelaOrdem);
            this.Controls.Add(this.pnlBaixo);
            this.Controls.Add(this.lblIdOrdem);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbTotal);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtClienteLancar);
            this.Name = "MenuOrdem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.grbTotal.ResumeLayout(false);
            this.grbTotal.PerformLayout();
            this.pnlBaixo.ResumeLayout(false);
            this.pnlOrdem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdem)).EndInit();
            this.grbInfos.ResumeLayout(false);
            this.grbInfos.PerformLayout();
            this.grbExecutar.ResumeLayout(false);
            this.grbExecutar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtClienteLancar;
        private System.Windows.Forms.TextBox txtEnderecoLancar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.GroupBox grbTotal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdOrdem;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Panel pnlBaixo;
        private System.Windows.Forms.DataGridView dgvOrdem;
        private System.Windows.Forms.Button btnTabelaOrdem;
        private System.Windows.Forms.Panel pnlOrdem;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.Button btnTabCliente;
        private System.Windows.Forms.GroupBox grbInfos;
        private System.Windows.Forms.CheckBox chbExecutado;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label lblOrdemAtual;
        private System.Windows.Forms.GroupBox grbExecutar;
    }
}