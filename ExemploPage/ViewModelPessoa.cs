using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPage
{
    public class ViewModelPessoa
    {
        public IList<Pessoa> Pessoas { get; set; }
        = new List<Pessoa>();

        public Pessoa PessoaSelecionada { get; set; }

        public ViewModelPessoa()
        {
                      
            Pessoas.Add(new PessoaFisica()
            {
                Nome = "Alex Pinheiro",
                Nascimento = new DateTime(1983, 12, 15),
                CPF = "111.111.111-33"
            });
            Pessoas.Add(new PessoaFisica()
            {
                Nome = "Rodrigo Pinheiro",
                Nascimento = new DateTime(1988, 12, 24),
                CPF = "111.111.333-33"
            });
            Pessoas.Add(new PessoaJuridica()
            {
                Nome = "Mr Micro",
                CNPJ = "10001.11011001/55"
            });
            Pessoas.Add(new PessoaJuridica()
            {
                Nome = "Apple",
                CNPJ = "99999.88811001/55"
            });
            PessoaSelecionada = Pessoas.FirstOrDefault();
        }
    }
}
