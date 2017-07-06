using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_invictor.Models
{
    class Campanha
    {
       
        List<Campanha> lista = new List<Campanha>();

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public DateTime DataPublicacao { get; set; }


        public void GetAll()
        {
            if(lista.Count <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("Não existe nenhuma campanha cadastrada");
                Console.WriteLine("==============================================================================");
            }

            foreach (var campanha in lista)
            {
                Console.WriteLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("Codigo da campanha: {0}", campanha.Codigo);
                Console.WriteLine("Nome da campanha {0}", campanha.Nome);
                Console.WriteLine("Data de inicio: {0}", campanha.DataInicio);
                Console.WriteLine("Data final {0}", campanha.DataFim);
                Console.WriteLine("==============================================================================");
            }
        }

        public void Save(string local, string nome, string dataInicio, string dataFim, DateTime dataPublicacao)
        {
            Random rdn = new Random();

            lista.Add( new Campanha() {
                Codigo = rdn.Next(0, 2000).ToString(),
                Local = local,
                Nome = nome,
                DataInicio = dataInicio,
                DataFim = dataFim,
                DataPublicacao = dataPublicacao
            });

            Console.WriteLine("Campanha cadastrada com sucesso!");

        }

        public void Remove()
        {
            Console.WriteLine("Informe o codigo da campanha: ");
            string codigo = Console.ReadLine();
            foreach (var campanha in lista)
            {
                if(campanha.Codigo == codigo)
                {
                    lista.Remove(campanha);
                    Console.WriteLine("Campanha removida com sucesso!");

                    break;

                }
            }
        }
    }
}
