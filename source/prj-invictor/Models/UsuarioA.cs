using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_invictor.Models
{
    class Usuario
    {
       
        List<Usuario> lista = new List<Usuario>();

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public float Peso { get; set; }
        public DateTime DataNascimento { get; set; }
	    public char Sexo { get; set; }
	    public int Idade { get; set; }
	
	public void GetAll()
	{
	     if(lista.Count <= 0)
	     {
		Console.WriteLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("Nenhum Usuário Encontrado.");
                Console.WriteLine("==============================================================================");
	      }

	 foreach (var campanha in lista)
         {
                Console.WriteLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("Nome: {0}", usuario.Nome);
                Console.WriteLine("Sobrenome: {0}", usuario.Sobrenome);
		Console.WriteLine("Data de Doação: ", doacao.usuario());
                Console.WriteLine("==============================================================================");
         }
}

	public void Save(string codigo, string nome, string sobrenome, string cpf, float peso, DateTime dataNascimento, char sexo, int idade)
        {
            Random rdn = new Random();

            lista.Add( new Usuario() {
                Codigo = rdn.Next(0, 2000).ToString(),
                Nome = nome,
		Sobrenome = sobrenome,
                Cpf = cpf,
                Peso = peso,
                DataNascimento = dataNascimento,
		Sexo = sexo,
		Idade = idade,
            };
        }
    }
}















