using System;

namespace prj_invictor.Models
{
    public class CampanhaModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public string DataPublicacao { get; set; }


        public CampanhaModel()
        {
        }

        public CampanhaModel(int codigo, string local, string nome, string dataInicio, string dataFim, string dataPublicacao )
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