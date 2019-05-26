using System;
using System.Collections.Generic;
using System.Text;

namespace BancoWindowsForms
{
    public class ClientePF:Cliente
    {
        public string Genero { get; set; }
        public string Cpf { get; set; }
        public DateTime DatadeNascimento { get; set; }

    }
}
