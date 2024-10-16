namespace exercicio_de_multiplas_janelas
{
    partial class FormCriarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCriarProduto));
            label1 = new Label();
            textBoxNome = new TextBox();
            inputPrecoCompra = new NumericUpDown();
            inputPrecoVenda = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxFabricante = new TextBox();
            buttonOk = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 45);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "𝓝𝓸𝓶𝓮 𝓭𝓸 𝓟𝓻𝓸𝓭𝓾𝓽𝓸";
            label1.Click += label1_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(199, 45);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(114, 27);
            textBoxNome.TabIndex = 1;
            // 
            // inputPrecoCompra
            // 
            inputPrecoCompra.DecimalPlaces = 2;
            inputPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoCompra.Location = new Point(199, 123);
            inputPrecoCompra.Margin = new Padding(3, 4, 3, 4);
            inputPrecoCompra.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            inputPrecoCompra.Name = "inputPrecoCompra";
            inputPrecoCompra.Size = new Size(114, 27);
            inputPrecoCompra.TabIndex = 2;
            inputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            inputPrecoCompra.ValueChanged += inputPrecoCompra_ValueChanged;
            // 
            // inputPrecoVenda
            // 
            inputPrecoVenda.DecimalPlaces = 2;
            inputPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoVenda.Location = new Point(199, 158);
            inputPrecoVenda.Margin = new Padding(3, 4, 3, 4);
            inputPrecoVenda.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            inputPrecoVenda.Name = "inputPrecoVenda";
            inputPrecoVenda.Size = new Size(114, 27);
            inputPrecoVenda.TabIndex = 3;
            inputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            inputPrecoVenda.ValueChanged += InputPrecoVenda_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 0;
            label2.Text = "𝓕𝓪𝓫𝓻𝓲𝓬𝓪𝓷𝓽𝓮";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 121);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 0;
            label3.Text = "𝓟𝓻𝓮ç𝓸 𝓭𝓮 𝓒𝓸𝓶𝓹𝓻𝓪";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 160);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 0;
            label4.Text = "𝓟𝓻𝓮ç𝓸 𝓭𝓮 𝓥𝓮𝓷𝓭𝓪";
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(199, 84);
            textBoxFabricante.Margin = new Padding(3, 4, 3, 4);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(114, 27);
            textBoxFabricante.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(12, 216);
            buttonOk.Margin = new Padding(3, 4, 3, 4);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(71, 31);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "𝓞𝓚";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(290, 216);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(74, 31);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "𝓒𝓪𝓷𝓬𝓮𝓵𝓪𝓻";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormCriarProduto
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = buttonCancelar;
            ClientSize = new Size(376, 264);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Controls.Add(inputPrecoVenda);
            Controls.Add(inputPrecoCompra);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCriarProduto";
            Text = "FormCriarProduto";
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private NumericUpDown inputPrecoCompra;
        private NumericUpDown inputPrecoVenda;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxFabricante;
        private Button buttonOk;
        private Button buttonCancelar;
    }
}