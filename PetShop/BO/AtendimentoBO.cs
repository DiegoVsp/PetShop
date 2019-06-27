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
        AtendimentoDAO atendimentoDAO = new AtendimentoDAO(); // <<----

        public void GravarAtendimento(Atendimento atendimento)
        {
            // AtendimentoDAO atendimentoDAO = new AtendimentoDAO() - 

            if ((atendimento.Pet.CodPet != 0) && (atendimento.Servico.CodServico != 0) && (atendimento.Funcionario.Codigo != 0))
            {
                atendimentoDAO.Insert(atendimento);
            }
            //select f.codfunc,(f.salario*0.1*(select count(*) from atendimento a where a.codfunc = f.codfunc)
            //            +f.salario) as comissao from funcionario f where f.codfunc =1;
        }

        public IList<Atendimento> BuscarPorAtendimento(Atendimento atendimento)
        {
            if (atendimento.CodAtendimento > 0)
            {
                IList<Atendimento> atendTemp = atendimentoDAO.BuscarPorAtendimento(atendimento.CodAtendimento);
                return atendTemp;
            }
            else
            {
                return null;
            }

        }
        
        public IList<Atendimento> BuscaPorFuncionario(Atendimento atendimento)
        {
            AtendimentoDAO atendimentoDAO = new AtendimentoDAO();



            if (atendimento.Funcionario.Codigo > 0)

            {
                IList<Atendimento> funcTemp = atendimentoDAO.BuscarPorFuncionario(atendimento.Funcionario.Codigo);

                return funcTemp;
            }
            else
            {
                return null;
            }
        }

        public IList<Atendimento> BuscaPet(Atendimento atendimento)
        {
            AtendimentoDAO atendimentoDAO = new AtendimentoDAO();

            if (atendimento.Pet.CodPet > 0)

            {
                IList<Atendimento> petTemp = atendimentoDAO.BuscaPet(atendimento.Pet.CodPet);

                return petTemp;
            }
            else
            {
                return null;
            }

        }
    }
}

