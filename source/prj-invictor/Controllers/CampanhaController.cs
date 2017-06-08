using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using prj_invictor.Models;

namespace prj_invictor.Controllers
{

    [RoutePrefix("api/campanha")]
    public class campanhaController : ApiController
    {
        private static List<CampanhaModel> listacampanhas = new List<CampanhaModel>();

        [AcceptVerbs("POST")]
        [Route("Cadastrarcampanha")]
        public string CadastrarCampanha(CampanhaModel campanha)
        {

            listacampanhas.Add(campanha);

            return "Usuário cadastrado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("Alterarcampanha")]
        public string AlterarCampanha(CampanhaModel campanha)
        {

            listacampanhas.Where(n => n.Codigo == campanha.Codigo)
                         .Select(s =>
                         {
                             s.Codigo = campanha.Codigo;
                             s.Nome = campanha.Nome;
                             s.Local = campanha.Local;
                             s.DataInicio = campanha.DataInicio;
                             s.DataFim = campanha.DataFim;
                             s.DataPublicacao = campanha.DataPublicacao;

                             return s;

                         }).ToList();



            return "Usuário alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("Excluircampanha/{codigo}")]
        public string ExcluirCampanha(int codigo)
        {

            CampanhaModel campanha = listacampanhas.Where(n => n.Codigo == codigo)
                                                .Select(n => n)
                                                .First();

            listacampanhas.Remove(campanha);

            return "Registro excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarcampanhaPorCodigo/{codigo}")]
        public CampanhaModel ConsultarCampanhaPorCodigo(int codigo)
        {

            CampanhaModel campanha = listacampanhas.Where(n => n.Codigo == codigo)
                                                .Select(n => n)
                                                .FirstOrDefault();

            return campanha;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarCampanhas")]
        public List<CampanhaModel> ConsultarCampanhas()
        {
            return listacampanhas;
        }
    }
}