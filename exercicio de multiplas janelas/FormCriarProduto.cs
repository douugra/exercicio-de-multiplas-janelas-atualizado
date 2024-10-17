using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_de_multiplas_janelas
{
    public partial class FormCriarProduto : Form
    {
        public string Nome { get { return this.textBoxNome.Text; } }
        public string Fabricante { get { return this.textBoxFabricante.Text; } }
        public decimal PrecoCompra { get { return this.inputPrecoCompra.Value; } }
        public decimal PrecoVenda { get { return this.inputPrecoVenda.Value; } }
        public FormCriarProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InputPrecoVenda_ValueChanged(object sender, EventArgs e)
        {

        }

        private void inputPrecoCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormCriarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
