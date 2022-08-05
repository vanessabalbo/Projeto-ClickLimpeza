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
    public partial class MenuServicos : Form
    {
        private int _idSelecionado;
        public MenuServicos()
        {
            InitializeComponent();
            AtualizarDgv();
        }


        private void AtualizarDgv()
        {
            dgvServico.DataSource = Banco.ServicoDAO.ListarTudoComValores();
        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var s = new Servico();

            var valida = txtServicoCad.Text.Length > 3 &&
                txtValorCad.Text.Length > 2;
               

            if (valida)
            {
                s.Nome =  txtServicoCad.Text;
                s.Valor = double.Parse(txtValorCad.Text);

                if (Banco.ServicoDAO.Cadastrar(s) == true)
                {


                    MessageBox.Show("Serviço cadastrado!");
                    // Limpar os campos:
                    txtServicoCad.Clear();
                    txtValorCad.Clear();
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

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ativar o grb de editar:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;


            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvServico.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvServico.Rows[numeroLinha];

            //Variaveis que irão receber os valores da linha selecionada:
            string nomeSelecionado = linha.Cells[1].Value.ToString();
            string valorSelecionado = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

            // Atribuir o valores das células aos txb do editar:
            txtServicoEdi.Text = nomeSelecionado;
            txtValorEdi.Text = valorSelecionado;

   

            //Definir o Texto da lblApagar:
            lblNomeApagar.Text = nomeSelecionado;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            var s = new Servico();
            s.Nome = txtServicoEdi.Text;
            s.Valor = double.Parse(txtValorEdi.Text);
            s.Id = _idSelecionado;

            // Chamar a Modificar:
            if (Banco.ServicoDAO.Modificar(s))
            {
                MessageBox.Show("Serviço modificado com sucesso!");
                // Limpar os campos:
                txtServicoEdi.Clear();
                txtValorEdi.Clear();
                lblNomeApagar.Text = "";
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
                Banco.ServicoDAO.ApagarPorId(_idSelecionado);
            }


            //Atualizar o DGV
            AtualizarDgv();
            //Limpar label "lblApagar"
            lblNomeApagar.Text = "";
            grbEditar.Enabled = false;

        }
    }
}
