using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClickLimpeza.Classes;
using System.Windows.Forms;

namespace ClickLimpeza.Formulario
{
    public partial class MenuClientes : Form
    {
        // Objetos globais:
        private int _idSelecionado;

        public MenuClientes()
        {
            InitializeComponent();
            // Carregar dados do bd para o dgv:
            AtualizarDgv();
        }
        private void AtualizarDgv()
        {
            dgvCliente.DataSource = Banco.ClienteDAO.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var c = new Cliente();

            var valida = txtNomeCad.Text.Length > 5 &&
                txtEmailCad.Text.Length >= 6 &&
                txtTelefoneCad.Text.Length >= 6;

            if (valida)
            {
                c.NomeCompleto = txtNomeCad.Text;
                c.Telefone = txtTelefoneCad.Text;
                c.Email = txtEmailCad.Text;
                c.Endereco = txtEnderecoCad.Text;

                if (Banco.ClienteDAO.Cadastrar(c) == true)
                {


                    MessageBox.Show("Cliente cadastrado!");
                    // Limpar os campos:
                    txtNomeCad.Clear();
                    txtEmailCad.Clear();
                    txtTelefoneCad.Clear();
                    txtEnderecoCad.Clear();
                    // Atualizar o dgv:
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Houve um erro no cadastro." +
                        "Verifique as informações digitadas!");
                }

            }
        }


        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ativar o grb de editar:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;


            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvCliente.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvCliente.Rows[numeroLinha];

            //Variaveis que irão receber os valores da linha selecionada:
            string nomeSelecionado = linha.Cells[1].Value.ToString();
            string telefoneSelecionado = linha.Cells[2].Value.ToString();
            string emailSelecionado = linha.Cells[3].Value.ToString();
            string enderecoSelecionado = linha.Cells[4].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

            // Atribuir o valores das células aos txb do editar:
            txtNomeEdi.Text = nomeSelecionado;
            txtTelefoneEdi.Text = telefoneSelecionado;
            txtEmailEdi.Text = emailSelecionado;
            txtEnderecoEdi.Text = enderecoSelecionado;

            //Definir o Texto da lblApagar:
            lblNomeApagar.Text = nomeSelecionado;
            lblEmailApagar.Text = emailSelecionado;
            lblETelefoneApagar.Text = telefoneSelecionado;
            lblEnderecoApag.Text = enderecoSelecionado;



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = new Cliente();
            c.NomeCompleto = txtNomeEdi.Text;
            c.Telefone = txtTelefoneEdi.Text;
            c.Email = txtEmailEdi.Text;
            c.Endereco = txtEnderecoEdi.Text;
            c.Id = _idSelecionado;

            // Chamar a Modificar:
            if (Banco.ClienteDAO.Modificar(c))
            {
                MessageBox.Show("Cliente modificado com sucesso!");
                // Limpar os campos:
                txtNomeEdi.Clear();
                txtEmailEdi.Clear();
                txtTelefoneEdi.Clear();
                txtEnderecoEdi.Clear();
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //Confirmar remoção:
            var r = MessageBox.Show("Deseja Realmente Apagar?", "Cuidado!!", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Banco.ClienteDAO.ApagarPorId(_idSelecionado);
            }


            //Atualizar o DGV
            AtualizarDgv();
            //Limpar label "lblApagar"
            lblNomeApagar.Text = "";
            lblEmailApagar.Text = "";
            lblETelefoneApagar.Text = "";
            lblEnderecoApag.Text = "";
            txtNomeEdi.Clear();
            txtEmailEdi.Clear();
            txtTelefoneEdi.Clear();
            txtEnderecoEdi.Clear();
            grbEditar.Enabled = false;

        }
    }
}
