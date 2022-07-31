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
        public DateTime dtnascimento { get; set; }
        public char  sexo { get; set; }
        public string  prontuario { get; set; }
    }
}