using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prj_invictor;

namespace prj_invictor.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public void CadastrarUsuario()
        {
            for (int i=0;i<2;i++)
            {
                if (i == 0)
                {
                    String cpf = 56;
                    String nome = "";
                    String sobrenome = "";
                    float peso = 50;
                    DateTime nascimento = null;
                    int idade = 18;
                    char sexo = "M";

                    Usuario usuario = new Usuario(cpf, nome, sobrenome, null, peso, nascimento, idade, sexo);
                    StartUp start = new StartUp();
                    //lista.add(usuario);

                } else if (i==1)
                {
                    //String cpf = 56, String nome, String sobrenome, float peso, DateTime nascimento,
            //int idade, char sexo
                }
                else if (i == 2)
                {

                }
            }
            
        }
    }
}