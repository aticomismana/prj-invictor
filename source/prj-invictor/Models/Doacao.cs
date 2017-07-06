using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_invictor.Models
{
    class Doacao
    {
       
        List<Doacao> lista = new List<Doacao>();

        public string Codigo { get; set; }
        public DateTime DataDoacao { get; set; }
	
	public void GetAll()
	{
	     if(lista.Count <= 0) 
	     {
		return 0;
	     }

	 foreach (var campanha in lista)
         {
          	return (Usuario.(doacao.DataDoacao));
         }
}

	public void Save(string codigo, DateTime dataDoacao)
        {
            Random rdn = new Random();

            lista.Add( new Doacao() {
                Codigo = rdn.Next(0, 2000).ToString(),
                DataDoacao = dataDoacao,
            };
        }
    }
}















