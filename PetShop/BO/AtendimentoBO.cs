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
        public void Gravar(frmAtendimento atendimento)
        {
            AtendimentoDAO livroDao = new AtendimentoDAO();
            // Regra só será gravada se o autor for preenchido, se for nulo não poderá

            

        }
    }
}
