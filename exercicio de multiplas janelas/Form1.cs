using System.ComponentModel;

namespace exercicio_de_multiplas_janelas
{
    public partial class Form1 : Form
    {
        private DataGridView dataGrid1;

        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> clientes { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }
        public BindingList<Venda> vendas { get; set; }
        public BindingList<Compra> Compras { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
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
            // A lógica para o clique na célula
            AjustarColunas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            AjustarColunas();

        }

        private void LoadData()
        {

            // Aqui você pode carregar seus dados
            // Exemplo: dataGrid1.DataSource = suaFonteDeDados;

            // Ajusta as colunas após carregar os dados
            AjustarColunas();
        }

        private void AjustarColunas()
        {
            if (dataGrid1 != null) // Verifica se dataGrid1 não é null
            {
                dataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGrid1.AutoResizeColumns();
            }
        }

        private void InitializeDataGridView()
        {
            dataGrid1 = new DataGridView();
            dataGrid1.Dock = DockStyle.Fill; // Para ocupar todo o espaço do formulário
            this.Controls.Add(dataGrid1);

            // Associe o evento
            dataGrid1.CellContentClick += dataGrid1_CellContentClick;
        }

        private void dataGrid1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // A lógica para o clique na célula
            AjustarColunas();
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

        private void buttonAdicionarVendas_Click(object sender, EventArgs e)
        {
            FormCriarVenda fcp = new FormCriarVenda();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Venda venda = new Venda();

                venda.idProduto = fcp.idproduto;
                venda.idCliente = fcp.idcliente;
                venda.quantidade = fcp.quantidade;
                venda.desconto = fcp.desconto;

                vendas.Add(venda);
            }
        }

        private void buttonAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            FormCriarFornecedor fcp = new FormCriarFornecedor();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                fornecedor.nome = fcp.nome;
                fornecedor.fone = fcp.Telefone;
                fornecedor.email = fcp.Email;
                fornecedor.endereço = fcp.Endereco;

                fornecedores.Add(fornecedor);

            }
        }

        private void buttonRemoverFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonRemoverVendas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonAdicionarCompra_Click(object sender, EventArgs e)
        {
            if (fornecedores.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar Fornecedores antes de efetuar uma compra.");
                return;
            }

            if (produtos.Count == 0)
            {
                MessageBox.Show("Voce Precisa Cadastrar Produtos antes de efetuar uma compra.");
                return;
            }

            FormCriarCompra fcc = new FormCriarCompra(fornecedores, produtos);
            var resultado = fcc.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (Compras.Count == 0) compra.idProduto = 1;
                else compra.idProduto = Compras.Max(x => x.idProduto) + 1;

                compra.idProduto = fcc.IdProduto;
                compra.idFornecedor = fcc.IdFornecedor;
                compra.quantidade = (int)fcc.Quantidade;
                compra.desconto = fcc.Desconto;
                compra.dataCompra = DateTime.Now;

                Compras.Add(compra);


            }
        }
    }
}

