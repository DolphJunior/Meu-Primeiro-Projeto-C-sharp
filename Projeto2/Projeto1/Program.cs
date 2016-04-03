using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Entities;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Nome = "Ana";
            pf.Email = "ana@gmail.com";
            pf.Cpf = "12345689";

            Console.WriteLine("::DADOS DE PESSOAS FISICAS CADASTRADAS:");
            Console.WriteLine("Nome...............: "+ pf.Nome);
            Console.WriteLine("Email..............: " + pf.Email);
            Console.WriteLine("Cpf................: " + pf.Cpf);

            Console.WriteLine("\n.................................");

            PessoaJuridica pj = new PessoaJuridica();
            pj.Nome = "Svd desenvolvimentos";
            pj.Email = "contato@svd.com";
            pj.Cnpj = "123456789/0001-11";

            Console.WriteLine("\n::DADOS DE PESSOAS JURIDICAS CADASTRADAS:");
            Console.WriteLine("Nome...............: " + pj.Nome);
            Console.WriteLine("Email..............: " + pj.Email);
            Console.WriteLine("CNPJ...............: " + pj.Cnpj);


            Console.ReadKey();
            
        }
    }
}
