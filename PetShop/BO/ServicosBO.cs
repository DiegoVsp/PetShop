using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.MODEL;
using PetShop.DAO;


namespace PetShop.BO
{
    class ServicosBO
    {
        public void GravarServico(Servico servico)
        {
            ServicosDAO servicoDAO = new ServicosDAO();
            if ((servico.Tipo != "") && (servico.Porte != "") && (servico.Valor != 0))
            {
                servicoDAO.Insert(servico);
            }
        }

        //Update
        public void Editar(Servico servico)
        {
            ServicosDAO servicosDAO = new ServicosDAO();
            if (servico.Tipo != "")
            {
                servicosDAO.Update(servico);
            }
        }

        public void Buscar(Servico servico)
        {
            ServicosDAO servicosDAO = new ServicosDAO();

            if (servico.CodServico > 0)
            {
                var servicoTemp = servicosDAO.BuscarPorId(servico.CodServico);

                servico.Tipo = servicoTemp.Tipo;
                servico.Valor = servicoTemp.Valor;
                servico.Porte = servicoTemp.Porte;
            }
        }

        public IList<Servico> BuscarTipo(Servico servico)
        {
            ServicosDAO servicoDAO = new ServicosDAO();
            if (servico.Tipo != "")
            {
                IList<Servico> servicoTemp = servicoDAO.BuscarPorTipo(servico.Tipo);
                return servicoTemp;
            }
            else
            {
                return null;
            }
        }
    }
}
