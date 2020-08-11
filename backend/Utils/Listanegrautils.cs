 using System;
 using System.Collections.Generic;
namespace backend.Utils
{
    public class Listanegrautils
    {
        public Models.TbListaNegra ParaTabela(Models.Request.ListaNegraRequest request)
        {
            Models.TbListaNegra ln = new Models.TbListaNegra();
            ln.NmPessoa = request.nome;
            ln.DsMotivo = request.motivo;
            ln.DtInclusao = DateTime.Now;

            return ln;
        }

        public Models.Response.Listanegraresponse ParaResponse(Models.TbListaNegra ln)
        {
            Models.Response.Listanegraresponse resp =new Models.Response.Listanegraresponse();
            resp.Id = ln.IdListaNegra;
            resp.Nome = ln.NmPessoa;
            resp.Motivo = ln.DsMotivo;
            resp.Inclusao = ln.DtInclusao;
            return resp;
        }

        public List<Models.Response.Listanegraresponse> ParaResponse(List<Models.TbListaNegra> lns)
        {
            List<Models.Response.Listanegraresponse> resp = new List<Models.Response.Listanegraresponse>();
            foreach (Models.TbListaNegra item in lns)
            {
                resp.Add(
                    this.ParaResponse(item));
            }
            return resp;
        }
    }
}