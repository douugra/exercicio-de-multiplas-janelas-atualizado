using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_de_multiplas_janelas
{
    public partial class FormCriarCliente : Form
    {
        public string nome { get { return textBoxnome.Text; } }
        public string Telefone { get { return textBoxTelefone.Text; } }
        public string Email { get { return textBoxEmail.Text; } }

        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"({textBoxEnderecoCompleto.Text}), ";
                endereco += $"({textBoxEnderecoNumero.Text}), ";
                endereco += $"({textBoxEnderecoComplemento.Text}), ";
                endereco += $"({textBoxEnderecoCidade.Text} - {textBoxEnderecoEstado.Text}), ";
                endereco += $"CEP {textBoxEnderecoCEP.Text}";
                return endereco;
            }
        }
        public FormCriarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCriarCliente_Load(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCANCELAR_Click(object sender, EventArgs e)
        {
            DialogResult =DialogResult.Cancel;
            Close();
        }
    }
}
