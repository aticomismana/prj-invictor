using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prj_invictor.Models
{
    public class Aptidao
    {
        public bool apto { get; set; }

        public bool VerificarAptidao(Usuario usuario)
        {
            return true;
        }
    }
}