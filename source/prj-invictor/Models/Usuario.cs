using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_invictor.Models
{
    class Usuario
    {
        public String nome { get; set; }
        public String sobrenome { get; set; }
        public String cpf { get; set; }
        public HistoricoDoacao historico;
        public List<Impedimento> impedimentos;
        public float peso { get; set; }
        public DateTime nascimento { get; set; }
        public char sexo { get; set; }
        public int idade { get; set; }
        public Login login { get; set; }
        public Aptidao aptidao;
        public bool apto { get; set; }

        public bool VerificarAptidao() {
            this.apto = verificarPeso(peso) && verificarIdade(idade) && verificarSexo();
            return this.apto;
        }

        public Boolean verificarPeso(float peso)
        {
            this.peso = peso;
            if (peso >= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean verificarIdade(int idade)
        {
            this.idade = idade;
            if (idade >= 16)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean verificarCpf(String cpf)
        {
            return false;
        }

        public bool verificarSexo()
        {
            return true;
        }

        public void atualizarUsuario(String nome, String sobrenome, List<Impedimento> impedimentos, float peso, int idade, char sexo)
        {


        }

        public void exibirCadastroUsr(String nome, String sobrenome, String cpf, List<Impedimento> impedimentos)
        {

        }

        public void exibirCadastroUsr()
        {

        }
        public void consultarCadastroUsr(String email, String senha)
        {

        }
        public Usuario()
        {

        }
        public Usuario(String cpf, String nome, String sobrenome, List<Impedimento> impedimentos, float peso, DateTime nascimento, int idade, char sexo)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.impedimentos = impedimentos;
            this.peso = peso;
            this.nascimento = nascimento;
            this.idade = idade;
            this.sexo = sexo;

            this.historico = new List<HistoricoDoacao>();
            this.impedimentos = new List<Impedimento>();
        }
        public void CadastrarUsuario()
        {

        }
    }
}
