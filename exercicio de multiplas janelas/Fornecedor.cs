using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_de_multiplas_janelas
{
    public class Fornecedor
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Nome do Fornecedor")] public string nome { get; set; }
        [DisplayName("Número de Telefone")] public string fone { get; set; }
        [DisplayName("Endereço de E-mail")] public string email { get; set; }
        [DisplayName("Endereço de Físico")] public string endereço { get; set; }
    }
}
