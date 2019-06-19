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
    }
}
