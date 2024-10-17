namespace exercicio_de_multiplas_janelas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button buttonvendas;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            dataGridView1 = new DataGridView();
            buttonclientes = new Button();
            buttonfornecedores = new Button();
            buttonprodutos = new Button();
            buttoncompras = new Button();
            button2 = new Button();
            button7 = new Button();
            buttonAdicionarCliente = new Button();
            buttonAdicionarVendas = new Button();
            buttonAdicionarFornecedor = new Button();
            buttonRemoverFornecedor = new Button();
            buttonRemoverVendas = new Button();
            buttonRemoverCliente = new Button();
            buttonvendas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonvendas
            // 
            buttonvendas.Image = (Image)resources.GetObject("buttonvendas.Image");
            buttonvendas.ImageAlign = ContentAlignment.TopLeft;
            buttonvendas.Location = new Point(427, 81);
            buttonvendas.Name = "buttonvendas";
            buttonvendas.Size = new Size(114, 40);
            buttonvendas.TabIndex = 4;
            buttonvendas.Text = "Vendas";
            buttonvendas.TextAlign = ContentAlignment.BottomRight;
            buttonvendas.UseVisualStyleBackColor = true;
            buttonvendas.Click += buttonvendas_Click;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackgroundImage = (Image)resources.GetObject("buttonAdicionar.BackgroundImage");
            buttonAdicionar.Location = new Point(155, 122);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(92, 25);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackgroundImage = (Image)resources.GetObject("buttonRemover.BackgroundImage");
            buttonRemover.Location = new Point(155, 149);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(92, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(155, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(653, 385);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonclientes
            // 
            buttonclientes.BackgroundImageLayout = ImageLayout.Center;
            buttonclientes.Image = (Image)resources.GetObject("buttonclientes.Image");
            buttonclientes.ImageAlign = ContentAlignment.TopLeft;
            buttonclientes.Location = new Point(292, 82);
            buttonclientes.Name = "buttonclientes";
            buttonclientes.RightToLeft = RightToLeft.No;
            buttonclientes.Size = new Size(113, 39);
            buttonclientes.TabIndex = 3;
            buttonclientes.Text = "    Clientes";
            buttonclientes.TextAlign = ContentAlignment.BottomRight;
            buttonclientes.UseVisualStyleBackColor = true;
            buttonclientes.Click += button1_Click;
            // 
            // buttonfornecedores
            // 
            buttonfornecedores.Image = (Image)resources.GetObject("buttonfornecedores.Image");
            buttonfornecedores.ImageAlign = ContentAlignment.TopLeft;
            buttonfornecedores.Location = new Point(564, 82);
            buttonfornecedores.Name = "buttonfornecedores";
            buttonfornecedores.Size = new Size(116, 39);
            buttonfornecedores.TabIndex = 5;
            buttonfornecedores.Text = "Fornecedores";
            buttonfornecedores.TextAlign = ContentAlignment.BottomRight;
            buttonfornecedores.UseVisualStyleBackColor = true;
            buttonfornecedores.Click += buttonfornecedores_Click;
            // 
            // buttonprodutos
            // 
            buttonprodutos.BackgroundImageLayout = ImageLayout.None;
            buttonprodutos.Image = (Image)resources.GetObject("buttonprodutos.Image");
            buttonprodutos.ImageAlign = ContentAlignment.TopLeft;
            buttonprodutos.Location = new Point(155, 81);
            buttonprodutos.Name = "buttonprodutos";
            buttonprodutos.RightToLeft = RightToLeft.No;
            buttonprodutos.Size = new Size(112, 40);
            buttonprodutos.TabIndex = 6;
            buttonprodutos.Text = "       Produtos";
            buttonprodutos.TextAlign = ContentAlignment.BottomRight;
            buttonprodutos.UseVisualStyleBackColor = true;
            buttonprodutos.Click += buttonprodutos_Click;
            // 
            // buttoncompras
            // 
            buttoncompras.Image = (Image)resources.GetObject("buttoncompras.Image");
            buttoncompras.ImageAlign = ContentAlignment.TopLeft;
            buttoncompras.Location = new Point(696, 82);
            buttoncompras.Name = "buttoncompras";
            buttoncompras.Size = new Size(112, 39);
            buttoncompras.TabIndex = 7;
            buttoncompras.Text = "Compras";
            buttoncompras.TextAlign = ContentAlignment.BottomRight;
            buttoncompras.UseVisualStyleBackColor = true;
            buttoncompras.Click += buttoncompras_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(696, 127);
            button2.Name = "button2";
            button2.Size = new Size(96, 20);
            button2.TabIndex = 0;
            button2.Text = "𝔸𝕕𝕚𝕔𝕚𝕠𝕟𝕒𝕣";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonAdicionar_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.Location = new Point(696, 153);
            button7.Name = "button7";
            button7.Size = new Size(96, 20);
            button7.TabIndex = 1;
            button7.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonRemover_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.Location = new Point(292, 122);
            buttonAdicionarCliente.Margin = new Padding(3, 2, 3, 2);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(95, 25);
            buttonAdicionarCliente.TabIndex = 8;
            buttonAdicionarCliente.Text = "Adicionar";
            buttonAdicionarCliente.UseVisualStyleBackColor = true;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonAdicionarVendas
            // 
            buttonAdicionarVendas.Location = new Point(427, 122);
            buttonAdicionarVendas.Name = "buttonAdicionarVendas";
            buttonAdicionarVendas.Size = new Size(96, 25);
            buttonAdicionarVendas.TabIndex = 9;
            buttonAdicionarVendas.Text = "Adicionar";
            buttonAdicionarVendas.UseVisualStyleBackColor = true;
            buttonAdicionarVendas.Click += buttonAdicionarVendas_Click;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.Location = new Point(564, 123);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(94, 24);
            buttonAdicionarFornecedor.TabIndex = 10;
            buttonAdicionarFornecedor.Text = "Adicionar";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = true;
            buttonAdicionarFornecedor.Click += buttonAdicionarFornecedor_Click;
            // 
            // buttonRemoverFornecedor
            // 
            buttonRemoverFornecedor.Location = new Point(564, 149);
            buttonRemoverFornecedor.Name = "buttonRemoverFornecedor";
            buttonRemoverFornecedor.Size = new Size(94, 23);
            buttonRemoverFornecedor.TabIndex = 11;
            buttonRemoverFornecedor.Text = "Remover";
            buttonRemoverFornecedor.UseVisualStyleBackColor = true;
            buttonRemoverFornecedor.Click += buttonRemoverFornecedor_Click;
            // 
            // buttonRemoverVendas
            // 
            buttonRemoverVendas.Location = new Point(427, 149);
            buttonRemoverVendas.Name = "buttonRemoverVendas";
            buttonRemoverVendas.Size = new Size(96, 23);
            buttonRemoverVendas.TabIndex = 12;
            buttonRemoverVendas.Text = "Remover";
            buttonRemoverVendas.UseVisualStyleBackColor = true;
            buttonRemoverVendas.Click += buttonRemoverVendas_Click;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.Location = new Point(292, 149);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(95, 23);
            buttonRemoverCliente.TabIndex = 13;
            buttonRemoverCliente.Text = "Remover";
            buttonRemoverCliente.UseVisualStyleBackColor = true;
            buttonRemoverCliente.Click += buttonRemoverCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1015, 661);
            Controls.Add(buttonRemoverCliente);
            Controls.Add(buttonRemoverVendas);
            Controls.Add(buttonRemoverFornecedor);
            Controls.Add(buttonAdicionarFornecedor);
            Controls.Add(buttonAdicionarVendas);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttoncompras);
            Controls.Add(buttonprodutos);
            Controls.Add(buttonfornecedores);
            Controls.Add(buttonvendas);
            Controls.Add(buttonclientes);
            Controls.Add(dataGridView1);
            Controls.Add(button7);
            Controls.Add(buttonRemover);
            Controls.Add(button2);
            Controls.Add(buttonAdicionar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private DataGridView dataGridView1;
        private Button buttonclientes;
        private Button buttonvendas;
        private Button buttonfornecedores;
        private Button buttonprodutos;
        private Button buttoncompras;
        private Button button2;
        private Button button7;
        private Button buttonAdicionarCliente;
        private Button buttonAdicionarVendas;
        private Button buttonAdicionarFornecedor;
        private Button buttonRemoverFornecedor;
        private Button buttonRemoverVendas;
        private Button buttonRemoverCliente;
    }
}
