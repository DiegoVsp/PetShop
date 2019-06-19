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
    class ServicosDAO
    {
        public void Insert(Servico servico)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Servico(tipo,porte,valor) values(@tipo,@porte,@valor)";

                comando.Parameters.AddWithValue("@tipo", servico.Tipo);
                comando.Parameters.AddWithValue("@porte", servico.Porte);
                comando.Parameters.AddWithValue("@valor", servico.Valor);

                ConexaoBanco.CRUD(comando);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Inserir" + ex.Message);
            }
        }
    }
}
