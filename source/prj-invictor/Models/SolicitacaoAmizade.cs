using System;

namespace prj_invictor.Models
{
    public class SolicitacaoAmizade 
    {
       public int user1 {get; set;}
       public int user2 {get; set;}
       public int status {get; set;}

       public DateTime data_solicitacao{get; set;}

       public int Buscar_amigos (){
            return 0;
       }

       public int Mostrar_solicitacao (){
                return 0;
       }

       public int Enviar_solicitacao (){
            return 0;
       }

       public int Rejeitar_solicitacao (){
                return 0;
       }

       public int Verifica_localizacao_da_campanha (){
                return 0;
       }



    }
}