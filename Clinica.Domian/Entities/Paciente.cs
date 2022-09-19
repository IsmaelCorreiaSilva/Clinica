using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Domian.Entities
{
    public class Paciente
    {
        public int Id { get; set; }
//public string Nome { get; set; }
        public DateTime Dtnascimento { get; set; }
        public char  Sexo { get; set; }
        
    }
}