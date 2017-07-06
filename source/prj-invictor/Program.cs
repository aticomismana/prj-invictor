using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_invictor.Models;


namespace prj_invictor
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Campanha campanha = new Campanha();
            do
            {
                Console.WriteLine("[ 1 ] Cadastrar campanha");
                Console.WriteLine("[ 2 ] Listar campanhas");
                Console.WriteLine("[ 3 ] Apagar campanha");
                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite uma opção: ");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o nome do local: ");
                        string Local = Console.ReadLine();
                        Console.WriteLine("Informe o nome da campanha: ");
                        string Nome = Console.ReadLine();
                        Console.WriteLine("Informe a data de inicio da campanha: ");
                        string DataInicio = Console.ReadLine();
                        Console.WriteLine("Informe a data final dacampanha: ");
                        string DataFim = Console.ReadLine();

                        campanha.Save(
                            Local,
                            Nome,
                            DataInicio,
                            DataFim,
                            DateTime.Now
                        );
                        break;
                    case 2:
                        campanha.GetAll();
                        break;
                    case 3:
                        campanha.GetAll();
                        campanha.Remove();
                        break;
                    default:
                        SaiPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);

        }

        private static void SaiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Bye Bye, vc saiu do Programa. Clique qq tecla para sair...");
        }
    }
}
