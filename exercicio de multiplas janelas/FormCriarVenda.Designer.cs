namespace exercicio_de_multiplas_janelas
{
    partial class FormCriarVenda
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
            inputIdProduto = new NumericUpDown();
            inputIdCliente = new NumericUpDown();
            inputQuantidadeVendida = new NumericUpDown();
            inputDesconto = new NumericUpDown();
            buttonOK1 = new Button();
            buttonCANCELAR1 = new Button();
            ((System.ComponentModel.ISupportInitialize)inputIdProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputIdCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputQuantidadeVendida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputDesconto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Id do Produto :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "Id do Cliente :";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 111);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 0;
            label3.Text = "Quantidade Vendida :";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 160);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 0;
            label4.Text = "Porcentagem de Desconto :";
            label4.Click += label1_Click;
            // 
            // inputIdProduto
            // 
            inputIdProduto.Location = new Point(172, 16);
            inputIdProduto.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            inputIdProduto.Name = "inputIdProduto";
            inputIdProduto.Size = new Size(38, 23);
            inputIdProduto.TabIndex = 1;
            inputIdProduto.TextAlign = HorizontalAlignment.Right;
            inputIdProduto.ValueChanged += inputIdProduto_ValueChanged;
            // 
            // inputIdCliente
            // 
            inputIdCliente.Location = new Point(172, 56);
            inputIdCliente.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            inputIdCliente.Name = "inputIdCliente";
            inputIdCliente.Size = new Size(38, 23);
            inputIdCliente.TabIndex = 1;
            inputIdCliente.TextAlign = HorizontalAlignment.Right;
            // 
            // inputQuantidadeVendida
            // 
            inputQuantidadeVendida.Location = new Point(172, 103);
            inputQuantidadeVendida.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            inputQuantidadeVendida.Name = "inputQuantidadeVendida";
            inputQuantidadeVendida.Size = new Size(38, 23);
            inputQuantidadeVendida.TabIndex = 1;
            inputQuantidadeVendida.TextAlign = HorizontalAlignment.Right;
            // 
            // inputDesconto
            // 
            inputDesconto.DecimalPlaces = 2;
            inputDesconto.Location = new Point(172, 152);
            inputDesconto.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            inputDesconto.Name = "inputDesconto";
            inputDesconto.Size = new Size(48, 23);
            inputDesconto.TabIndex = 1;
            inputDesconto.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonOK1
            // 
            buttonOK1.Location = new Point(3, 209);
            buttonOK1.Name = "buttonOK1";
            buttonOK1.Size = new Size(75, 23);
            buttonOK1.TabIndex = 2;
            buttonOK1.Text = "OK";
            buttonOK1.UseVisualStyleBackColor = true;
            // 
            // buttonCANCELAR1
            // 
            buttonCANCELAR1.Location = new Point(145, 209);
            buttonCANCELAR1.Name = "buttonCANCELAR1";
            buttonCANCELAR1.Size = new Size(75, 23);
            buttonCANCELAR1.TabIndex = 2;
            buttonCANCELAR1.Text = "CANCELAR";
            buttonCANCELAR1.UseVisualStyleBackColor = true;
            // 
            // FormCriarVenda
            // 
            AcceptButton = buttonOK1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCANCELAR1;
            ClientSize = new Size(228, 240);
            Controls.Add(buttonCANCELAR1);
            Controls.Add(buttonOK1);
            Controls.Add(inputDesconto);
            Controls.Add(inputQuantidadeVendida);
            Controls.Add(inputIdCliente);
            Controls.Add(inputIdProduto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCriarVenda";
            Text = "FormCriarVenda";
            Load += FormCriarVenda_Load;
            ((System.ComponentModel.ISupportInitialize)inputIdProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputIdCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputQuantidadeVendida).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown inputIdProduto;
        private NumericUpDown inputIdCliente;
        private NumericUpDown inputQuantidadeVendida;
        private NumericUpDown inputDesconto;
        private Button buttonOK1;
        private Button buttonCANCELAR1;
    }
}