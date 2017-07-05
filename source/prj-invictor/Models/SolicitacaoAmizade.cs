using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_invictor.Models
{
    class SolicitacaoAmizade
    {
        public int User1 { get; set; }
        public int User2 { get; set; }
        public int Status { get; set; }

        public DateTime dataSolicitacao { get; set; }

        public int BuscarAmigos()
        {
            return 0;
        }

        public int MostrarSolicitacao()
        {
            return 0;
        }

        public int EnviarSolicitacao()
        {
            return 0;
        }

        public int RejeitarSolicitacao()
        {
            return 0;
        }

        public int VerificaLocalizacaoCampanha()
        {
            return 0;
        }
    }
}
