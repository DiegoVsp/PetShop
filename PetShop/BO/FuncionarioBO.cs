using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.MODEL;
using PetShop.DAO;

namespace PetShop.BO
{
    class FuncionarioBO
    {
        public void GravarFuncionario(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            if((funcionario.Nome != "")&&(funcionario.Cpf != "") && (funcionario.Telefone != "")&&(funcionario.Cep != null))
            {
                funcionarioDAO.Insert(funcionario);
            }
        }


        public void Buscar(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            if (funcionario.Codigo >0)
            {
                var funTemp = funcionarioDAO.BuscarPorId(funcionario.Codigo);

                funcionario.Nome = funTemp.Nome;
                funcionario.Cpf = funTemp.Cpf;
                funcionario.Cep = funTemp.Cep;
                funcionario.Endereco = funTemp.Endereco;
                funcionario.Numero = funTemp.Numero;
                funcionario.Cidade = funTemp.Cidade;
                funcionario.Telefone = funTemp.Telefone;
                funcionario.CartTrab = funTemp.CartTrab;
                funcionario.Salario = funTemp.Salario;
            }
        }

        public void Editar(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            if (funcionario.Nome != "")
            {
                funcionarioDAO.Update(funcionario);
            }
        }

        public void Calcular(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            if (funcionario.Salario > 0)
            {
                funcionarioDAO.CalcSalario(funcionario);
            }
        }
    }
}
