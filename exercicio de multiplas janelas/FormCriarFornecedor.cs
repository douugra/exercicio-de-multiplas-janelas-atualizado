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
    public partial class FormCriarFornecedor : Form
    {
        public string nome { get { return textBoxNomeEmpresa.Text; } }
        public string Telefone { get { return textBoxTelefone.Text; } }
        public string Email { get { return textBoxEmail.Text; } }
        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"({textBoxEnderecoCompleto.Text}), ";
                endereco += $"({textBoxNumero.Text}), ";
                endereco += $"({textBoxComplemento.Text}), ";
                endereco += $"({textBoxCidade.Text} - {textBoxEstado.Text}), ";
                endereco += $"CEP {textBoxCEP.Text}";
                return endereco;
            }
        }
        public FormCriarFornecedor()
        {
            InitializeComponent();
        }

        private void FormCriarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCANCELAR2_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }
    }
}
