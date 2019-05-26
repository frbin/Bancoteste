using System;
using System.Collections.Generic;
using System.Text;

namespace BancoWindowsForms
{
    public class Cliente
    {
        public Conta Conta { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public List<Endereco> Endereco { get; set; }

        public Cliente()
        {
            Conta = new Conta();
            Endereco = new List<Endereco>();
        }
    }
}
