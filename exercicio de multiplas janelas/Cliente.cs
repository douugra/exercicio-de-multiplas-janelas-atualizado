using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_de_multiplas_janelas
{
    public class Cliente
    {
        private static int _contadorId = 0;
        [DisplayName("Id")] public int ID { get; private set; }
        [DisplayName("Nome do Cliente")] public string nome { get; set; }
        [DisplayName("Número de Telefone")] public string fone { get; set; }
        [DisplayName("Endereço de E-mail")] public string email { get; set; }
        [DisplayName("Endereço Físico")] public string endereco { get; set; }
        public Cliente()
        {
            ID = ++_contadorId; // Incrementa o contador e atribui ao Id
        }
    }
}
