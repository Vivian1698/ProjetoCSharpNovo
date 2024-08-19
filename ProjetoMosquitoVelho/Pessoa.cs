using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMosquitoVelho
{
    class Pessoa
    {
        //criando atributos ou variáveis globais privadas
        private string nome;
        private string email;
        private string idade;

        //criando métodos get e set
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Idade { get => idade; set => idade = value; }

        
    }
}
