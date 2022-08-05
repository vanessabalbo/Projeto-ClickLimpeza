namespace ClickLimpeza
{
    partial class MenuInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrdem = new System.Windows.Forms.Button();
            this.grbGerenciar = new System.Windows.Forms.GroupBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCargo = new System.Windows.Forms.Button();
            this.grbGerenciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrdem
            // 
            this.btnOrdem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOrdem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdem.ForeColor = System.Drawing.Color.White;
            this.btnOrdem.Location = new System.Drawing.Point(34, 161);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Size = new System.Drawing.Size(319, 48);
            this.btnOrdem.TabIndex = 1;
            this.btnOrdem.Text = "ORDEM DE SERVIÇO";
            this.btnOrdem.UseVisualStyleBackColor = false;
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // grbGerenciar
            // 
            this.grbGerenciar.Controls.Add(this.btnCargo);
            this.grbGerenciar.Controls.Add(this.btnCliente);
            this.grbGerenciar.Controls.Add(this.btnFuncionario);
            this.grbGerenciar.Controls.Add(this.btnServico);
            this.grbGerenciar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGerenciar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grbGerenciar.Location = new System.Drawing.Point(34, 229);
            this.grbGerenciar.Name = "grbGerenciar";
            this.grbGerenciar.Size = new System.Drawing.Size(319, 214);
            this.grbGerenciar.TabIndex = 2;
            this.grbGerenciar.TabStop = false;
            this.grbGerenciar.Text = "GERENCIAR";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(25, 167);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(258, 31);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(25, 121);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(258, 31);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "FUNCIONÁRIOS";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnServico
            // 
            this.btnServico.Location = new System.Drawing.Point(25, 34);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(258, 31);
            this.btnServico.TabIndex = 0;
            this.btnServico.Text = "SERVIÇOS";
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClickLimpeza.Properties.Resources.copia;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 143);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCargo
            // 
            this.btnCargo.Location = new System.Drawing.Point(25, 75);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(258, 31);
            this.btnCargo.TabIndex = 3;
            this.btnCargo.Text = "CARGOS";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(389, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbGerenciar);
            this.Controls.Add(this.btnOrdem);
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clik Limpeza";
            this.grbGerenciar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOrdem;
        private System.Windows.Forms.GroupBox grbGerenciar;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnServico;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCargo;
    }
}

