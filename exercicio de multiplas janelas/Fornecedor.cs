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
        private static int _contadorId = 0;
        [DisplayName("Id")] public int Id { get; private set; }
        [DisplayName("Nome do Fornecedor")] public string nome { get; set; }
        [DisplayName("Número de Telefone")] public string fone { get; set; }
        [DisplayName("Endereço de E-mail")] public string email { get; set; }
        [DisplayName("Endereço de Físico")] public string endereço { get; set; }
        public Fornecedor()
        {
            Id = ++_contadorId; // Incrementa o contador e atribui ao Id
        }
    }
}
