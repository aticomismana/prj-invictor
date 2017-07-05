using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_invictor.Models
{
    class TempoImpedimento
    {
        public string Nome { get; set; }
        public enum Natureza
        {
            Temporario,
            Definitivo
        }
    }
}
