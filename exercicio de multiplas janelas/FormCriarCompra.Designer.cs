namespace exercicio_de_multiplas_janelas
{
    partial class FormCriarCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxProduto = new ComboBox();
            comboBoxFornecedor = new ComboBox();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownDeconto = new NumericUpDown();
            textBoxPrecoUnitario = new TextBox();
            textBoxValorTotal = new TextBox();
            textBoxTotalComDesconto = new TextBox();
            buttonOK = new Button();
            buttonCANCELAR = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeconto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 70);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 99);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Fornecedor :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 122);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 0;
            label3.Text = "Quantidade :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 151);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 0;
            label4.Text = "Desconto%  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 186);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 0;
            label5.Text = "Preço Unitário  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 217);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 0;
            label6.Text = "Valor Total  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 246);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 0;
            label7.Text = " Total com Desconto  :";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(138, 67);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(121, 23);
            comboBoxProduto.TabIndex = 1;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(138, 93);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(121, 23);
            comboBoxFornecedor.TabIndex = 1;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(138, 122);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 23);
            numericUpDownQuantidade.TabIndex = 2;
            numericUpDownQuantidade.ValueChanged += numericUpDownQuantidade_ValueChanged;
            // 
            // numericUpDownDeconto
            // 
            numericUpDownDeconto.Location = new Point(138, 151);
            numericUpDownDeconto.Name = "numericUpDownDeconto";
            numericUpDownDeconto.Size = new Size(120, 23);
            numericUpDownDeconto.TabIndex = 2;
            numericUpDownDeconto.ValueChanged += numericUpDownDeconto_ValueChanged;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.BackColor = SystemColors.ActiveBorder;
            textBoxPrecoUnitario.ForeColor = SystemColors.Window;
            textBoxPrecoUnitario.Location = new Point(138, 180);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.ReadOnly = true;
            textBoxPrecoUnitario.Size = new Size(121, 23);
            textBoxPrecoUnitario.TabIndex = 3;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.BackColor = SystemColors.ActiveBorder;
            textBoxValorTotal.ForeColor = SystemColors.Window;
            textBoxValorTotal.Location = new Point(138, 209);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.ReadOnly = true;
            textBoxValorTotal.Size = new Size(121, 23);
            textBoxValorTotal.TabIndex = 3;
            // 
            // textBoxTotalComDesconto
            // 
            textBoxTotalComDesconto.BackColor = SystemColors.ActiveBorder;
            textBoxTotalComDesconto.ForeColor = SystemColors.Window;
            textBoxTotalComDesconto.Location = new Point(138, 238);
            textBoxTotalComDesconto.Name = "textBoxTotalComDesconto";
            textBoxTotalComDesconto.ReadOnly = true;
            textBoxTotalComDesconto.Size = new Size(121, 23);
            textBoxTotalComDesconto.TabIndex = 3;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(15, 281);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCANCELAR
            // 
            buttonCANCELAR.Location = new Point(184, 281);
            buttonCANCELAR.Name = "buttonCANCELAR";
            buttonCANCELAR.Size = new Size(75, 23);
            buttonCANCELAR.TabIndex = 4;
            buttonCANCELAR.Text = "CANCELAR";
            buttonCANCELAR.UseVisualStyleBackColor = false;
            buttonCANCELAR.Click += buttonCANCELAR_Click;
            // 
            // FormCriarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 317);
            Controls.Add(buttonCANCELAR);
            Controls.Add(buttonOK);
            Controls.Add(textBoxTotalComDesconto);
            Controls.Add(textBoxValorTotal);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(numericUpDownDeconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(comboBoxFornecedor);
            Controls.Add(comboBoxProduto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCriarCompra";
            Text = "FormCriarCompra";
            Load += FormCriarCompra_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxFornecedor;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownDeconto;
        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxValorTotal;
        private TextBox textBoxTotalComDesconto;
        private Button buttonOK;
        private Button buttonCANCELAR;
    }
}