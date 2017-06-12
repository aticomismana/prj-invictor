using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prj_invictor.Models
{
    public class Roteiro
    {
        public string PosicaoInicial { get; set; }
        public string PosicaoFinal { get; set; }
        public string Distancia { get; set; }

        public List buscarLocaisDoacao(Local localUsuario, List locais)
        {

            return localUsuario;
        }

        public Local criarRoteiro(string posicaoInicial, string posicaoFinal)
        {
            return Local;
        }
    }
}