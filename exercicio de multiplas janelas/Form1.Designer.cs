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
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            buttonAdicionarCliente = new Button();
            buttonvendas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonvendas
            // 
            buttonvendas.Image = (Image)resources.GetObject("buttonvendas.Image");
            buttonvendas.ImageAlign = ContentAlignment.TopLeft;
            buttonvendas.Location = new Point(509, 108);
            buttonvendas.Margin = new Padding(3, 4, 3, 4);
            buttonvendas.Name = "buttonvendas";
            buttonvendas.Size = new Size(110, 53);
            buttonvendas.TabIndex = 4;
            buttonvendas.Text = "Vendas";
            buttonvendas.TextAlign = ContentAlignment.BottomRight;
            buttonvendas.UseVisualStyleBackColor = true;
            buttonvendas.Click += buttonvendas_Click;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackgroundImage = (Image)resources.GetObject("buttonAdicionar.BackgroundImage");
            buttonAdicionar.Location = new Point(200, 167);
            buttonAdicionar.Margin = new Padding(3, 4, 3, 4);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(105, 27);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "𝔸𝕕𝕚𝕔𝕚𝕠𝕟𝕒𝕣";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackgroundImage = (Image)resources.GetObject("buttonRemover.BackgroundImage");
            buttonRemover.Location = new Point(200, 202);
            buttonRemover.Margin = new Padding(3, 4, 3, 4);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(105, 27);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(200, 237);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(723, 513);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonclientes
            // 
            buttonclientes.BackgroundImageLayout = ImageLayout.Center;
            buttonclientes.Image = (Image)resources.GetObject("buttonclientes.Image");
            buttonclientes.ImageAlign = ContentAlignment.TopLeft;
            buttonclientes.Location = new Point(354, 109);
            buttonclientes.Margin = new Padding(3, 4, 3, 4);
            buttonclientes.Name = "buttonclientes";
            buttonclientes.RightToLeft = RightToLeft.No;
            buttonclientes.Size = new Size(109, 51);
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
            buttonfornecedores.Location = new Point(670, 109);
            buttonfornecedores.Margin = new Padding(3, 4, 3, 4);
            buttonfornecedores.Name = "buttonfornecedores";
            buttonfornecedores.Size = new Size(107, 52);
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
            buttonprodutos.Location = new Point(200, 108);
            buttonprodutos.Margin = new Padding(3, 4, 3, 4);
            buttonprodutos.Name = "buttonprodutos";
            buttonprodutos.RightToLeft = RightToLeft.No;
            buttonprodutos.Size = new Size(105, 53);
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
            buttoncompras.Location = new Point(814, 109);
            buttoncompras.Margin = new Padding(3, 4, 3, 4);
            buttoncompras.Name = "buttoncompras";
            buttoncompras.Size = new Size(110, 52);
            buttoncompras.TabIndex = 7;
            buttoncompras.Text = "Compras";
            buttoncompras.TextAlign = ContentAlignment.BottomRight;
            buttoncompras.UseVisualStyleBackColor = true;
            buttoncompras.Click += buttoncompras_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(814, 167);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(110, 27);
            button2.TabIndex = 0;
            button2.Text = "𝔸𝕕𝕚𝕔𝕚𝕠𝕟𝕒𝕣";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonAdicionar_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(509, 167);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(110, 27);
            button3.TabIndex = 0;
            button3.Text = "𝔸𝕕𝕚𝕔𝕚𝕠𝕟𝕒𝕣";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonAdicionar_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Location = new Point(670, 167);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(107, 27);
            button4.TabIndex = 0;
            button4.Text = "𝔸𝕕𝕚𝕔𝕚𝕠𝕟𝕒𝕣";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonAdicionar_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.Location = new Point(509, 202);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(110, 27);
            button6.TabIndex = 1;
            button6.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonRemover_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.Location = new Point(354, 202);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(109, 27);
            button5.TabIndex = 1;
            button5.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonRemover_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.Location = new Point(814, 202);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(110, 27);
            button7.TabIndex = 1;
            button7.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonRemover_Click;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.Location = new Point(670, 202);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(107, 27);
            button8.TabIndex = 1;
            button8.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonRemover_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.Location = new Point(354, 166);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(109, 29);
            buttonAdicionarCliente.TabIndex = 8;
            buttonAdicionarCliente.Text = "Adicionar";
            buttonAdicionarCliente.UseVisualStyleBackColor = true;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1160, 911);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttoncompras);
            Controls.Add(buttonprodutos);
            Controls.Add(buttonfornecedores);
            Controls.Add(buttonvendas);
            Controls.Add(buttonclientes);
            Controls.Add(dataGridView1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(buttonRemover);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonAdicionar);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button buttonAdicionarCliente;
    }
}
