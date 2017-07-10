using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_invictor.Models
{
    class HistoricoDoacao
    {
        private List<Doacao> doacoes;

        public bool verificarDtUltDoacao() {

            if( DateTime.Compare(this.doacoes.Last().Data, new DateTime( "Data atual - 6 meses" )) < 0 ){

            }

            return true;
        }
    }
}
