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
    public partial class MenuCargos : Form
    {
        private int _idSelecionado;
        public MenuCargos()
        {
            InitializeComponent();
            AtualizarDgv();
        }

        private void AtualizarDgv()
        {
            dgvCargo.DataSource = Banco.CargoDAO.ListarTudoSalario();
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var c = new Cargo();

            var valida = txtCargoCad.Text.Length > 3 &&
                txtSalarioCad.Text.Length > 2;


            if (valida)
            {
                c.Nome = txtCargoCad.Text;
                c.Salario = double.Parse(txtSalarioCad.Text);

                if (Banco.CargoDAO.Cadastrar(c) == true)
                {


                    MessageBox.Show("Cargo cadastrado!");
                    // Limpar os campos:
                    txtCargoCad.Clear();
                    txtSalarioCad.Clear();
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

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ativar o grb de editar:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;


            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvCargo.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvCargo.Rows[numeroLinha];

            //Variaveis que irão receber os valores da linha selecionada:
            string cargoSelecionado = linha.Cells[1].Value.ToString();
            string salarioSelecionado = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

            // Atribuir o valores das células aos txb do editar:
            txtCargoEdi.Text = cargoSelecionado;
            txtSalarioEdi.Text = salarioSelecionado;



            //Definir o Texto da lblApagar:
            lblNomeApagar.Text = cargoSelecionado;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = new Cargo();
            c.Nome = txtCargoEdi.Text;
            c.Salario = double.Parse(txtSalarioEdi.Text);
            c.Id = _idSelecionado;

            // Chamar a Modificar:
            if (Banco.CargoDAO.Modificar(c))
            {
                MessageBox.Show("Cargo modificado com sucesso!");
                // Limpar os campos:
                txtCargoEdi.Clear();
                txtSalarioEdi.Clear();
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
                Banco.CargoDAO.ApagarPorId(_idSelecionado);
            }


            //Atualizar o DGV
            AtualizarDgv();
            //Limpar label "lblApagar"
            lblNomeApagar.Text = "";
            grbEditar.Enabled = false;

        }
    }
}
