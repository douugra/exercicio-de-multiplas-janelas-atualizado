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
    public partial class FormCriarVenda : Form
    {
        public int idproduto { get { return (int)this.inputIdProduto.Value; } }
        public int idcliente { get { return (int)this.inputIdCliente.Value; } }
        public int quantidade { get { return (int)this.inputQuantidadeVendida.Value; } }
        public float desconto { get { return (float)this.inputDesconto.Value; } }
        public FormCriarVenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FormCriarVenda_Load(object sender, EventArgs e)
        {

        }

        private void inputIdProduto_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
