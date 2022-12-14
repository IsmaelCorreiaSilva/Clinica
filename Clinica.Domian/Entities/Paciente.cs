using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Domian.Entities
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public char  Sexo { get; set; }
        public string Email { get; set; }
        public DateTime Criacao { get; set; }
        public string Telefone { get; set; }
        public DateTime? UltimaAtualiacao { get; set;  }

    }
}