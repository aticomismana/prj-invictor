using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_invictor.Models
{
    class Impedimento
    {
        enum Tipos
        {
            Gravidez
        }

        public DateTime DataOcorrencia { get; set; }

        public bool VerificarImpedimentosExistente(Usuario usuario)
        {
            return true;
        }
        public void cadastrarImpedimento(Usuario usuario)
        {

        }
    }
}
