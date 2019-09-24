using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPage
{
    public class PessoaFisica : Pessoa
    {
        public DateTime Nascimento { get; set; }

        public String CPF { get; set; }

    }
}
