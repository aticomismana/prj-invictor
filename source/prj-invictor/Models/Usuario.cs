using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prj_invictor.Models
{
    public class Usuario
    {
        public String nome { get; set; }
        public String sobrenome { get; set; }
        public String cpf { get; set; }
        public List<HistoricoDoacao> historico;
        public List<Impedimento> impedimentos;
        public float peso { get; set; }
        public DateTime nascimento { get; set; }
        public char sexo { get; set; }
        public int idade { get; set; }

        public Boolean verificarPeso(float peso)
        {
            if(peso >= 50)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public Boolean verificarIdade(int idade)
        {
            if(idade >= 16)
            {
                return true;
            }else
            {
                return false;
            }
            
        }

        public Boolean verificarCpf(String cpf)
        {
            return false;
        }
        public char verificarSexo()
        {
            return sexo;
        }

        public void atualizarUsuario(String nome, String sobrenome,List<Impedimento> impedimentos, float peso, int idade,char sexo)
        {


        }
<<<<<<< HEAD
        public void exibirCadastroUsr(String nome, String sobrenome, String cpf, List<Impedimento> impedimentos)
=======
        public void exibirCadastroUsr()
>>>>>>> 444b6a4cfe59d6b87879fe6d983d882afac96ce0
        {

        }
        public void consultarCadastroUsr(String email, String senha)
        {

        }
        public Usuario()
        {

        }
        public Usuario(String cpf , String nome, String sobrenome, List<Impedimento> impedimentos, float peso, DateTime nascimento, int idade, char sexo)
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

    }
}