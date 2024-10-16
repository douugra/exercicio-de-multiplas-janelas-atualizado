namespace exercicio_de_multiplas_janelas
{
    partial class FormCriarCliente
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
            groupBox1 = new GroupBox();
            textBoxEnderecoComplemento = new TextBox();
            textBoxEnderecoNumero = new TextBox();
            textBoxEnderecoCEP = new TextBox();
            label10 = new Label();
            textBoxEnderecoEstado = new TextBox();
            textBoxEnderecoCidade = new TextBox();
            textBoxEnderecoCompleto = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxnome = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxEmail = new TextBox();
            buttonOK = new Button();
            buttonCANCELAR = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxEnderecoComplemento);
            groupBox1.Controls.Add(textBoxEnderecoNumero);
            groupBox1.Controls.Add(textBoxEnderecoCEP);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBoxEnderecoEstado);
            groupBox1.Controls.Add(textBoxEnderecoCidade);
            groupBox1.Controls.Add(textBoxEnderecoCompleto);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBoxEnderecoComplemento
            // 
            textBoxEnderecoComplemento.Location = new Point(135, 105);
            textBoxEnderecoComplemento.Name = "textBoxEnderecoComplemento";
            textBoxEnderecoComplemento.Size = new Size(125, 27);
            textBoxEnderecoComplemento.TabIndex = 2;
            // 
            // textBoxEnderecoNumero
            // 
            textBoxEnderecoNumero.Location = new Point(135, 62);
            textBoxEnderecoNumero.Name = "textBoxEnderecoNumero";
            textBoxEnderecoNumero.Size = new Size(125, 27);
            textBoxEnderecoNumero.TabIndex = 2;
            textBoxEnderecoNumero.TextChanged += textBox5_TextChanged;
            // 
            // textBoxEnderecoCEP
            // 
            textBoxEnderecoCEP.Location = new Point(135, 242);
            textBoxEnderecoCEP.Name = "textBoxEnderecoCEP";
            textBoxEnderecoCEP.Size = new Size(125, 27);
            textBoxEnderecoCEP.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 1;
            label10.Text = " Endereço:  ";
            label10.Click += label1_Click;
            // 
            // textBoxEnderecoEstado
            // 
            textBoxEnderecoEstado.Location = new Point(135, 196);
            textBoxEnderecoEstado.Name = "textBoxEnderecoEstado";
            textBoxEnderecoEstado.Size = new Size(125, 27);
            textBoxEnderecoEstado.TabIndex = 2;
            // 
            // textBoxEnderecoCidade
            // 
            textBoxEnderecoCidade.Location = new Point(135, 150);
            textBoxEnderecoCidade.Name = "textBoxEnderecoCidade";
            textBoxEnderecoCidade.Size = new Size(125, 27);
            textBoxEnderecoCidade.TabIndex = 2;
            // 
            // textBoxEnderecoCompleto
            // 
            textBoxEnderecoCompleto.Location = new Point(135, 20);
            textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            textBoxEnderecoCompleto.Size = new Size(125, 27);
            textBoxEnderecoCompleto.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 150);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 1;
            label8.Text = "Cidade:";
            label8.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 242);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 1;
            label9.Text = "CEP:";
            label9.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 196);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 1;
            label7.Text = "UF(estado):";
            label7.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 105);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 1;
            label6.Text = "Complemento:";
            label6.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 65);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 1;
            label5.Text = "Número:";
            label5.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 23);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 1;
            label4.Text = "Lougradoro (Rua):";
            label4.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome do Cliente:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 1;
            label2.Text = "Número de Telefone:";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 1;
            label3.Text = " E-mail:";
            label3.Click += label1_Click;
            // 
            // textBoxnome
            // 
            textBoxnome.Location = new Point(176, 33);
            textBoxnome.Name = "textBoxnome";
            textBoxnome.Size = new Size(125, 27);
            textBoxnome.TabIndex = 2;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(176, 66);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(125, 27);
            textBoxTelefone.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(176, 99);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(2, 483);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCANCELAR
            // 
            buttonCANCELAR.Location = new Point(207, 483);
            buttonCANCELAR.Name = "buttonCANCELAR";
            buttonCANCELAR.Size = new Size(94, 29);
            buttonCANCELAR.TabIndex = 3;
            buttonCANCELAR.Text = "CANCELAR";
            buttonCANCELAR.UseVisualStyleBackColor = true;
            buttonCANCELAR.Click += buttonCANCELAR_Click;
            // 
            // FormCriarCliente
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCANCELAR;
            ClientSize = new Size(312, 583);
            Controls.Add(buttonCANCELAR);
            Controls.Add(buttonOK);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxnome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormCriarCliente";
            Text = "FormCriarCliente";
            Load += FormCriarCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxEnderecoComplemento;
        private TextBox textBoxEnderecoNumero;
        private TextBox textBoxEnderecoCEP;
        private TextBox textBoxEnderecoEstado;
        private TextBox textBoxEnderecoCidade;
        private TextBox textBoxEnderecoCompleto;
        private Label label8;
        private Label label9;
        private TextBox textBoxnome;
        private TextBox textBoxTelefone;
        private TextBox textBoxEmail;
        private Label label10;
        private Button buttonOK;
        private Button buttonCANCELAR;
    }
}