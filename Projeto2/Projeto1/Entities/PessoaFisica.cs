using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Entities
{
    public sealed class PessoaFisica: Pessoa
    {

        private int idPessoaFisica;
        private string cpf;

        public int IdPessoaFisica
        {
            set{idPessoaFisica = value;}
            get{return idPessoaFisica;}
        }

        public string Cpf
        {
            set { cpf = value; }
            get { return cpf; }
        }
    }
}
