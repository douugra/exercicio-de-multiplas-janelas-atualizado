using System.ComponentModel;

namespace exercicio_de_multiplas_janelas
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> clientes { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }
        public BindingList<Venda> vendas { get; set; }
        public BindingList<Compra> Compras { get; set; }

        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            clientes = new BindingList<Cliente>();
            fornecedores = new BindingList<Fornecedor>();
            vendas = new BindingList<Venda>();
            Compras = new BindingList<Compra>();
            this.dataGridView1.DataSource = produtos;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormCriarProduto fcp = new FormCriarProduto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();

                produto.Nome = fcp.Nome;
                produto.Fabricante = fcp.Fabricante;
                produto.PrecoVenda = fcp.PrecoVenda;
                produto.PrecoCompra = fcp.PrecoCompra;

                produtos.Add(produto);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clientes;
        }

        private void buttoncompras_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Compras;
        }

        private void buttonprodutos_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = produtos;
        }

        private void buttonvendas_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = vendas;
        }

        private void buttonfornecedores_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = fornecedores;
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormCriarCliente fcp = new FormCriarCliente();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                cliente.nome = fcp.nome;
                cliente.fone = fcp.Telefone;
                cliente.email = fcp.Email;
                cliente.endereco = fcp.Endereco;

                clientes.Add(cliente);
            }
        }
    }
}

