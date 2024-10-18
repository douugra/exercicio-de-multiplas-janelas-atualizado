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
            buttonOK1 = new Button();
            buttonCANCELAR1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            inputIdProduto = new NumericUpDown();
            inputQuantidadeVendida = new NumericUpDown();
            inputDesconto = new NumericUpDown();
            inputIdCliente = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)inputIdProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputQuantidadeVendida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputIdCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = " Produto :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Fornecedor :";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 111);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Quantidade  :";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 160);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 0;
            label4.Text = " Desconto%  :";
            label4.Click += label1_Click;
            // 
            // buttonOK1
            // 
            buttonOK1.Location = new Point(172, 429);
            buttonOK1.Name = "buttonOK1";
            buttonOK1.Size = new Size(75, 23);
            buttonOK1.TabIndex = 2;
            buttonOK1.Text = "OK";
            buttonOK1.UseVisualStyleBackColor = true;
            // 
            // buttonCANCELAR1
            // 
            buttonCANCELAR1.Location = new Point(301, 429);
            buttonCANCELAR1.Name = "buttonCANCELAR1";
            buttonCANCELAR1.Size = new Size(75, 23);
            buttonCANCELAR1.TabIndex = 2;
            buttonCANCELAR1.Text = "CANCELAR";
            buttonCANCELAR1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 212);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 3;
            label5.Text = "Preço Unitário :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 247);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 3;
            label6.Text = "Valor Total :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 281);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 3;
            label7.Text = "Total Com Desconto :";
            // 
            // inputIdProduto
            // 
            inputIdProduto.Location = new Point(187, 12);
            inputIdProduto.Name = "inputIdProduto";
            inputIdProduto.Size = new Size(120, 23);
            inputIdProduto.TabIndex = 4;
            // 
            // inputQuantidadeVendida
            // 
            inputQuantidadeVendida.Location = new Point(187, 41);
            inputQuantidadeVendida.Name = "inputQuantidadeVendida";
            inputQuantidadeVendida.Size = new Size(120, 23);
            inputQuantidadeVendida.TabIndex = 4;
            // 
            // inputDesconto
            // 
            inputDesconto.Location = new Point(187, 127);
            inputDesconto.Name = "inputDesconto";
            inputDesconto.Size = new Size(120, 23);
            inputDesconto.TabIndex = 4;
            // 
            // inputIdCliente
            // 
            inputIdCliente.Location = new Point(187, 80);
            inputIdCliente.Name = "inputIdCliente";
            inputIdCliente.Size = new Size(120, 23);
            inputIdCliente.TabIndex = 4;
            // 
            // FormCriarVenda
            // 
            AcceptButton = buttonOK1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCANCELAR1;
            ClientSize = new Size(763, 464);
            Controls.Add(inputIdCliente);
            Controls.Add(inputDesconto);
            Controls.Add(inputQuantidadeVendida);
            Controls.Add(inputIdProduto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonCANCELAR1);
            Controls.Add(buttonOK1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCriarVenda";
            Text = "FormCriarVenda";
            Load += FormCriarVenda_Load;
            ((System.ComponentModel.ISupportInitialize)inputIdProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputQuantidadeVendida).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputIdCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonOK1;
        private Button buttonCANCELAR1;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown inputIdProduto;
        private NumericUpDown inputQuantidadeVendida;
        private NumericUpDown inputDesconto;
        private NumericUpDown inputIdCliente;
    }
}