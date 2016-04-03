using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Entities
{
    public abstract class Pessoa
    {
        private int idPessoa;
        private string nome;
        private string email;

        public virtual int IdPessoa
        {
            set{idPessoa = value;}
            get{return idPessoa;}
        }

        public virtual string Nome
        {
            set{ nome = value; }
            get{ return nome; }
        }


        public virtual string Email
        {
            set{email = value;}
            get{return email;}
        }
    }
}
