using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prj_invictor.Models
{
    public class Usuario
    {
        protected String nome { get; set; }
        protected String sobrenome { get; set; }
        protected String cpf { get; set; }
        protected List<Impedimento> impedimentos;
        protected float peso { get; set; }
        protected DateTime nascimento { get; set; }
        protected char sexo { get; set; }

        public Boolean verificarPeso(char sexo)
        {
            return false;
        }
        public Boolean verificarIdade(char sexo)
        {
            return false;
        }

        public Boolean verificarCpf()
        {
            return false;
        }
        public Boolean verificarSexo(char sexo)
        {
            return false;

        }
        public void atualizarUsuario()
        {

        }
        public void exibirCadastroUsr()
        {

        }
        public void consultarCadastroUsr()
        {

        }
        public void cadastroUsuario()
        {

        }

    }
}