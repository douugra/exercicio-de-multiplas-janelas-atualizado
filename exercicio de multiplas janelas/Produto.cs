using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_de_multiplas_janelas
{
    public class Produto
    {
        private static int _contadorId = 0;
        public int Id { get; private set; }

        [DisplayName("Produto")]
        public string Nome { get; set; }

        public string Fabricante { get; set; }

        [DisplayName("Preço de Compra")]
        public decimal PrecoCompra { get; set; }

        [DisplayName("Preço de Venda")]
        public decimal PrecoVenda { get; set; }

        public Produto()
        {
            Id = ++_contadorId; // Incrementa o contador e atribui ao Id
        }
    }
}
 