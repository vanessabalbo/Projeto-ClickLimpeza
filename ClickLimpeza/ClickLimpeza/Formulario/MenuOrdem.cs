using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ClickLimpeza.Classes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ClickLimpeza.Formulario
{
    public partial class MenuOrdem : Form
    {
        //Variavel Global
        private int _idSelecionado;

        private void AtualizarcmbServico()
        {
            var r = Banco.ServicoDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            foreach (DataRow datarow in r.Rows)
            {
                rows.Add(string.Join(" - ", datarow.ItemArray.Select(item => item.ToString())));
            }
            cmbServico.DataSource = rows;
            

        }

        private void AtualizarCmbFuncionario()
        {
            var r = Banco.FuncionarioDAO.ListarNome();
            ArrayList rows = new ArrayList();
            foreach (DataRow datarow in r.Rows)
            {
                rows.Add(string.Join(" - ", datarow.ItemArray.Select(item => item.ToString())));
            }
            cmbFuncionario.DataSource = rows;

        }
        public MenuOrdem()
        {
            InitializeComponent();
            AtualizarDgv();
            AtualizarcmbServico();
            AtualizarCmbFuncionario();
            IdOrdem();
            AtualizarDgvOS();


        }
        private int obterIDdaString(string texto)
        {
            /* Ao chamar obterIDdaString("12 - Alimentação")
             * o resultador será 12
             * Show?
             */
            return int.Parse(texto.Split(' ')[0]);
        }


        private void AtualizarDgv()
        {
            dgvOrdem.DataSource = Banco.OrdemDAO.ListarTudo();
        }
        private void AtualizarDgvOS()
        {
            dgvOS.DataSource = Banco.OrdemDAO.ListarOrdens();
        }

        private void dgvOrdem_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvOrdem.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvOrdem.Rows[numeroLinha];

            //Variaveis que irão receber os valores da linha selecionada:
            string nomeSelecionado = linha.Cells[1].Value.ToString();
            string enderecoSelecionado = linha.Cells[4].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

            // Atribuir o valores das células aos txb do editar:
            txtClienteLancar.Text = nomeSelecionado;
            txtEnderecoLancar.Text = enderecoSelecionado;







        }

        private void dgvOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvOS.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvOS.Rows[numeroLinha];

            //Variaveis que irão receber os valores da linha selecionada:
            string nomeSelecionado = linha.Cells[1].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

            // Atribuir o valores das células aos txb do editar:
            txtClienteLancar.Text = nomeSelecionado;








        }
        private void btnLancar_Click(object sender, EventArgs e)
        {
            var o = new Ordem();



            o.ClienteId = _idSelecionado;
            o.ServicoId = obterIDdaString(cmbServico.Text);
            o.FuncionarioId = obterIDdaString(cmbFuncionario.Text);


            if (Banco.OrdemDAO.Lancar(o) == true)
            {


                MessageBox.Show("Ordem Lançada ");
                // Limpar os campos:
                txtClienteLancar.Clear();
                txtEnderecoLancar.Clear();
                // Atualizar o dgv:
                AtualizarDgv();


            }
            else
            {
                MessageBox.Show("Houve um erro no cadastro." +
                    "Verifique as informações digitadas!");
            }



        }

        private void cmbServico_SelectedIndexChanged(object sender, EventArgs e)
        {

            var id = obterIDdaString(cmbServico.Text);
            lblValorTotal.Text = "R$: " + Banco.OrdemDAO.BuscarValorID(id).Rows[0][0];

        }


        private void IdOrdem()
        {

            lblIdOrdem.Text = Banco.OrdemDAO.UltimaOrdem().Rows[0][0].ToString();
        }

        private void btnTabelaOrdem_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Lançar Ordem de Serviço";
            pnlOrdem.Visible = true;
            btnTabelaOrdem.Visible = false;
            btnTabCliente.Visible = true;
            grbInfos.Visible = true;
            IdOrdem();
            lblOrdemAtual.Visible = true;
            grbExecutar.Visible = false;
            
            

        }

        private void btnTabCliente_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Encerramento de Ordem";
            pnlOrdem.Visible = false;
            btnTabelaOrdem.Visible = true;
            btnTabCliente.Visible = false;
            grbInfos.Visible = false;
            lblIdOrdem.Text = "";
            lblOrdemAtual.Visible = false;
            grbExecutar.Visible = true;
            

        }

        private void chbExecutado_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = chbExecutado.Checked;
        }
        private void btnEncerrar_Click(object sender, EventArgs e)
        {

            if (Banco.OrdemDAO.Encerrar(_idSelecionado))
            {
                MessageBox.Show("Ordem Encerrada com Sucesso");
                lblValorTotal.Text = "";
                txtClienteLancar.Clear();
                chbExecutado.Checked = false;
                AtualizarDgvOS();
                
            }
            else
            {
                MessageBox.Show("Houve um Erro!!!");
            }
        }
    }
}
