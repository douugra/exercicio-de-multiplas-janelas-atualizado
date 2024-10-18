using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_de_multiplas_janelas
{
    public partial class FormCriarCompra : Form
    {

        private BindingList<Fornecedor> Fornecedores { get; set; }
        private Fornecedor Fornecedor { get { return Fornecedores.FirstOrDefault(f => f.Id == (int)comboBoxFornecedor.SelectedValue); } }
        public int IdFornecedor { get { return (int)comboBoxFornecedor.SelectedValue; } }

        private BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(f => f.Id == (int)comboBoxProduto.SelectedValue); } }
        public int IdProduto { get { return (int)comboBoxProduto.SelectedValue; } }


        public decimal Quantidade { get { return numericUpDownQuantidade.Value; } }
        public decimal Desconto { get { return numericUpDownDeconto.Value; } }

        private decimal PrecoUnitario { get { return Produto.PrecoCompra; } }
        private decimal ValorTotal { get { return PrecoUnitario * Quantidade; } }
        private decimal ValorComDesconto { get { return ValorTotal * (1 - (Desconto / 100)); } }

        public FormCriarCompra(BindingList<Fornecedor> fornecedores, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Fornecedores = fornecedores;
            comboBoxFornecedor.DataSource = Fornecedores;
            comboBoxFornecedor.ValueMember = "Id";
            comboBoxFornecedor.DisplayMember = "NomeEmpresa";

            Produtos = produtos;
            comboBoxProduto.DataSource = produtos;
            comboBoxProduto.ValueMember = "Id";
            comboBoxProduto.DisplayMember = "Nome";
        }

        private void FormCriarCompra_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownDeconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }
        private void AtualizarValores()
        {
            if (Produto != null)
            {
                textBoxPrecoUnitario.Text = PrecoUnitario.ToString("C", CultureInfo.CurrentCulture);
                textBoxValorTotal.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                textBoxTotalComDesconto.Text = ValorComDesconto.ToString("C", CultureInfo.CurrentCulture);

            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
