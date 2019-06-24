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

        public void Update(Servico servico)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update servico set tipo=@tipo,valor=@valor,porte=@porte where codserv=@codserv";

                comando.Parameters.AddWithValue("@codserv", servico.CodServico);
                comando.Parameters.AddWithValue("@tipo", servico.Tipo);
                comando.Parameters.AddWithValue("@valor", servico.Valor);
                comando.Parameters.AddWithValue("@porte", servico.Porte);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(" Erro ao realizar o update" + ex.Message);
            }
        }

        public Servico BuscarPorId(int id)
        {

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select*from servico where codserv=@id";

            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Servico servico = new Servico();

            if (dr.HasRows)
            {
                dr.Read();

                servico.Tipo = (string)dr["tipo"];
                servico.Valor = Convert.ToSingle((decimal)dr["valor"]);
                servico.Porte = (string)dr["porte"];
            }
            else
            {
                servico.Tipo = "";
                servico.Valor = 0;
                servico.Porte = "";
            }
            return servico;

        }
    }
}
