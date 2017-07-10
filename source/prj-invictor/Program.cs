﻿using System;
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
            List<Usuario> usuarioLista = new List<Usuario>();

            do
            {
                Console.WriteLine("[ 1 ] Cadastrar campanha");
                Console.WriteLine("[ 2 ] Listar campanhas");
                Console.WriteLine("[ 3 ] Apagar campanha");
                Console.WriteLine("[ 4 ] Cadastrar Usuario");
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

                    case 4:
                        Console.WriteLine("Informe o nome do usuario: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe o sobrenome do usuario");
                        string sobrenome = Console.ReadLine();
                        Console.WriteLine("Informe o CPF do usuario");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Informe o historico de doação do usuario");
                        string historico = Console.ReadLine();
                        Console.WriteLine("Informe o peso do usuario");
                        float peso =  float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a data de nascimento do usuario");
                        DateTime nascimento = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a idade do usuario");
                        int idade =  int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o sexo do usuario");
                        char sexo = char.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o login do usuario");
                        string login =  Console.ReadLine();

                        Usuario usuario = new Usuario(cpf,nome,sobrenome,null,peso,nascimento,idade,sexo);
                        if(usuario.verificarCpf(cpf,usuarioLista) == false) {
                            usuarioLista.Add(usuario);
                        }
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
