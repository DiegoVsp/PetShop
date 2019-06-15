using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.MODEL;
using PetShop.DAO;

namespace PetShop.BO
{
    public class AtendimentoBO
    {
        public void GravarAtendimento(Atendimento atendimento)
        {

            AtendimentoDAO atendimentoDAO = new AtendimentoDAO();

            //if ((atendimento.Pet != null) && (atendimento.Servico != null) && (atendimento.Funcionario != null))
           // {
                if ((atendimento.CodAtendimento != 0))
                {
                atendimentoDAO.Insert(atendimento);
                }
           //     else  { }
           // }

        }
    }
}
