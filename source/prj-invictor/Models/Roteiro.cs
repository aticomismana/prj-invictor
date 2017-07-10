using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_invictor.Models;

namespace prj_invictor.Models
{
    class Roteiro
    {
        public double Distancia { get; set; }
        public PostoDoacao PostoDoacaoIni { get; set; }
        public PostoDoacao PostoDoacaoFim { get; set; }

        public Roteiro( PostoDoacao p1, PostoDoacao p2 ) {
            this.PostoDoacaoFim = p2;
            this.PostoDoacaoIni = p1;
        }

        public bool buscarLocaisDoacao()
        {

            

            return true;
        }

        public bool criarRoteiro(string posicaoInicial, string posicaoFinal)
        {
            return true;
        }

        public void calcularDistancia()
        {
            double R = 6371e3; // metres
            double l1 = this.PostoDoacaoIni.Latitude;
            double l2 = this.PostoDoacaoFim.Latitude;
            double df = l2 - l1;
            double dl = this.PostoDoacaoFim.Longitude - this.PostoDoacaoFim.Longitude;

            double a = Math.Sin(df / 2) * Math.Sin(df / 2) +
                       Math.Cos(l1) * Math.Cos(l2) *
                       Math.Sin(dl / 2) * Math.Sin(dl / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double d = R * c;

            this.Distancia = d;

        }

    }
}
