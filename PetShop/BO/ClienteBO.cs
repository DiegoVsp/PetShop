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
        public void Editar(Cliente cliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            if(cliente.Nome != "")
            {
                clienteDAO.Update(cliente);

            }
        }
        public void Buscar(Cliente cliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            if (cliente.Codigo >0)
            {
                var clienteTemp = clienteDAO.BuscarPorId(cliente.Codigo);

                
                cliente.Nome = clienteTemp.Nome;
                cliente.Cpf = clienteTemp.Cpf;
                cliente.Cep = clienteTemp.Cep;
                cliente.Endereco = clienteTemp.Endereco;
                cliente.Cidade = clienteTemp.Cidade;
                cliente.Numero = clienteTemp.Numero;
                cliente.Telefone = clienteTemp.Telefone;
                cliente.Email = clienteTemp.Email;
            }
        }
    }
}
