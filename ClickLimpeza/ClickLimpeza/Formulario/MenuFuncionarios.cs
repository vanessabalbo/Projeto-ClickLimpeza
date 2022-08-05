using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickLimpeza
{
    //=================================================================================
    public partial class MenuFuncionarios : Form
    {
        // Objetos globais:
        private int _idSelecionado;

        public MenuFuncionarios()
        {
            InitializeComponent();
            // Carregar dados do bd para o dgv:
            AtualizarDgv();

            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Banco.CargoDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter esse objeto para array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbCargoCad.DataSource = rows;
            cmbCargoEdit.DataSource = rows.Clone();
           
            
        }
        
        private void AtualizarDgv()
        {
            dgvFuncionario.DataSource = Banco.FuncionarioDAO.ListarTudo();
        }

        private int obterIDdaString(string texto)
        {
            /* Ao chamar obterIDdaString("12 - Alimentação")
             * o resultador será 12
             * Show?
             */
            return int.Parse(texto.Split(' ')[0]);
        }

        //=================================================================================
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var f = new Funcionario();

            var valida = txtNomeCad.Text.Length > 5 &&
                txtEmailCad.Text.Length >= 6 &&
                txtTelefoneCad.Text.Length >= 6;

            if (valida)
            {
                f.NomeCompleto = txtNomeCad.Text;
                f.Email = txtEmailCad.Text;
                f.Telefone = txtTelefoneCad.Text;
                f.IdCargo = obterIDdaString(cmbCargoCad.Text);

                if (Banco.FuncionarioDAO.Cadastrar(f) == true)
                {


                    MessageBox.Show("Funcionario cadastrado!");
                    // Limpar os campos:
                    txtNomeCad.Clear();
                    txtEmailCad.Clear();
                    txtTelefoneCad.Clear();
                    // Atualizar o dgv:
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Houve um erro no cadastro." +
                        "Verifique as informações digitadas!");
                }

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }

        }
        //=================================================================================

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ativar o grb de editar:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;


            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvFuncionario.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvFuncionario.Rows[numeroLinha];

            //Variaveis que irão receber os valores da linha selecionada:
            string nomeSelecionado = linha.Cells[1].Value.ToString();
            string emailSelecionado = linha.Cells[2].Value.ToString();
            string telefoneSelecionado = linha.Cells[3].Value.ToString();
            string cargoSelecionado = linha.Cells[4].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

            // Atribuir o valores das células aos txb do editar:
            txtNomeEdi.Text = nomeSelecionado;
            txtEmailEdi.Text = emailSelecionado;
            txtTelefoneEdi.Text = telefoneSelecionado;
            cmbCargoEdit.Text = cargoSelecionado;

            //Definir o Texto da lblApagar:
            lblNomeApagar.Text = nomeSelecionado;
            lblEmailApagar.Text = emailSelecionado;
            lblETelefoneApagar.Text = telefoneSelecionado;



        }
        //=================================================================================

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var f = new Funcionario();
            f.NomeCompleto = txtNomeEdi.Text;
            f.Email = txtEmailEdi.Text;
            f.Telefone = txtTelefoneEdi.Text;
            f.IdCargo = obterIDdaString(cmbCargoEdit.Text);
            f.Id = _idSelecionado;

            // Chamar a Modificar:
            if (Banco.FuncionarioDAO.Modificar(f))
            {
                MessageBox.Show("Usuário modificado com sucesso!");
                // Limpar os campos:
                txtNomeEdi.Clear();
                txtEmailEdi.Clear();
                txtTelefoneEdi.Clear();
                // Atualizar o dgv:
                AtualizarDgv();
                // Esconder o grb de editar:
                //grbEditar.Visible = false;
                grbEditar.Enabled = false;
                grbApagar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }

        }
        //=================================================================================


        private void btnApagar_Click(object sender, EventArgs e)
        {
            //Confirmar remoção:
            var r = MessageBox.Show("Deseja Realmente Apagar?", "Cuidado!!", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Banco.FuncionarioDAO.ApagarPorId(_idSelecionado);
            }


            //Atualizar o DGV
            AtualizarDgv();
            //Limpar label "lblApagar"
            lblNomeApagar.Text = "";
            lblEmailApagar.Text = "";
            lblETelefoneApagar.Text = "";
            txtNomeEdi.Clear();
            txtEmailEdi.Clear();
            txtTelefoneEdi.Clear();
            grbEditar.Enabled = false;

        }
    }

}
