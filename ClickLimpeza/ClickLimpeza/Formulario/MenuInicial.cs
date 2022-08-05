using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ClickLimpeza.Formulario;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickLimpeza
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            var menuordem = new MenuOrdem();
            menuordem.ShowDialog();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            var menuservico = new MenuServicos();
            menuservico.ShowDialog();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            var menufuncionario = new MenuFuncionarios();
            menufuncionario.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var menucliente = new MenuClientes();
            menucliente.ShowDialog();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            var menucargo = new MenuCargos();
            menucargo.ShowDialog();
        }
    }
}
