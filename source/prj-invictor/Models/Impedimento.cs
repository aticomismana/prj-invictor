using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prj_invictor.Models
{
    public class Impedimento
    {
        public string Pipo { get; set; }
        public DateTime DataOcorrencia { get; set; }

        public bool VerificarImpedimentosExistente(Usuario usuario)
        {
            return true;
        }
        public void ArmazenarImpedimento(Usuario usuario)
        {

        }
    }
}