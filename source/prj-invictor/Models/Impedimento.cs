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

        public string TipoImpedimento { get; set; }
        public DateTime DataOcorrencia { get; set; }

        public bool VerificarImpedimentosExistente(Usuario usuario, String tipoImpedimento, DateTime dataImpedimento)
        {
            bool existeImpedimento = false;
            foreach (Impedimento impedimento in usuario.impedimentos)
            {
                if (String.Compare(tipoImpedimento, impedimento.TipoImpedimento, false) == 0 && dataImpedimento == impedimento.DataOcorrencia)
                {
                    existeImpedimento = true;
                    break;
                }
            }
            return existeImpedimento;
        }
        public void cadastrarImpedimento(Usuario usuario, String tipoImpedimento, DateTime dataImpedimento)
        {
            Impedimento impedimento = new Impedimento();
            impedimento.TipoImpedimento = tipoImpedimento;
            impedimento.DataOcorrencia = dataImpedimento;
            usuario.impedimentos.Add(impedimento);
        }
    }
}
