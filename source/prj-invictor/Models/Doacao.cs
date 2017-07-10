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

        public string Codigo { get; set;}
		public DateTime data {get; set;}
        public string local { get; set; }
        public string tipoDoacao { get; set; }
  


        public void GetAll()
        {
            if(lista.Count <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("Não existe nenhuma doação cadastrada");
                Console.WriteLine("==============================================================================");
            }

            foreach (var doacao in lista)
            {
                Console.WriteLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("Codigo da doacao: {0}", doacao.Codigo);
                Console.WriteLine("Nome da doação {0}", doacao.Doacao);
                Console.WriteLine("Data da doacao: {0}", doacao.Data);
                Console.WriteLine("Tipo Doacao: {0}" ,doacao.tipoDoacao);
                Console.WriteLine("==============================================================================");
            }
        }
