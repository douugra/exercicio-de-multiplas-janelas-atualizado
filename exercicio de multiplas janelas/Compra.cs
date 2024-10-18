using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_de_multiplas_janelas
{
    public class Compra
    {
        [DisplayName("Id do Produto")] public int idProduto { get; set; }
        [DisplayName("Id do Fornecedor")] public int idFornecedor { get; set; }
        [DisplayName("Quantidade Comprada")] public int quantidade { get; set; }
        [DisplayName("Porcentagem de desconto")] public decimal desconto { get; set; }
        [DisplayName("data de compra")] public DateTime dataCompra {  get; set; }
    }
}
