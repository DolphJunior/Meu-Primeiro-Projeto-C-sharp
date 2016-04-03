using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Entities
{
    public sealed class PessoaJuridica: Pessoa
    {
        public int idPessoaJuridica;
        public string cnpj;

        public int IdPessoaJuridica
        {
            set {idPessoaJuridica = value; }
            get{return idPessoaJuridica;}
        }
        
        
        public string Cnpj
        {
            set{cnpj = value;}
            get {return cnpj;}
        }

        public override string Nome
        {
            get
            {
                return base.Nome.ToUpper();
            }
            set
            {
                base.Nome = value;
            }
        }
    }
}
