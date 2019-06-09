using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.MODEL;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace PetShop.DAO
{
    class AtendimentoDAO
    {
        public void Insert(Atendimento atendimento)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Atendimento(codserv,codpet,codfunc,datahora,situacao) values(@codServ,@codPet,@codFunc,@dataHora,@situacao)";

                

                comando.Parameters.AddWithValue("@codServ", atendimento.Servico.CodServico);
                comando.Parameters.AddWithValue("@codPet", atendimento.Pet.CodPet);
                comando.Parameters.AddWithValue("@codFunc", atendimento.Funcionario.CodFunc);
                comando.Parameters.AddWithValue("@dataHora", atendimento.DataHora);
                comando.Parameters.AddWithValue("@situacao", atendimento.Situacao);

                ConexaoBanco.CRUD(comando);//Esta sendo  enviado o comando para  o metodo CRUD
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel se conectar" + ex.Message);
            }

        }
    }
}


