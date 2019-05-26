using System;
using System.Collections.Generic;
using System.Text;

namespace BancoWindowsForms
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public int Id { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
    }

    public enum TipoEndereco
    {
        Residencial, Comercial
    }
}
