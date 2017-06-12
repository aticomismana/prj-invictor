using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prj_invictor.Models
{
    public class TipoImpedimento
    {
        public string Nome { get; set; }
        public enum Natureza
        {
            Temporario,
            Definitivo
        }
    }
}