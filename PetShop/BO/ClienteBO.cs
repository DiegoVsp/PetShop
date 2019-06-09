using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.MODEL;
using PetShop.DAO;

namespace PetShop.BO
{
    public class ClienteBO
    {
        public void GravarCliente(Cliente cliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            if((cliente.Nome != "")&&(cliente.Cpf != 0)&&(cliente.Telefone != ""))
            {
                clienteDAO.Insert(cliente);
            }
        }
    }
}
