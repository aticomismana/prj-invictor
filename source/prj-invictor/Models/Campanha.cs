using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_invictor.Models
{
    class Campanha
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public string DataPublicacao { get; set; }


        public Campanha()
        {
        }

        public Campanha(int codigo, string local, string nome, string dataInicio, string dataFim, string dataPublicacao)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Local = local;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.DataPublicacao = dataPublicacao;
        }
    }
}
