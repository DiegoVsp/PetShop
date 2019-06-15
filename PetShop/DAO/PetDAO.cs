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
    class PetDAO
    {
        // Botão Cadastrar
        public void Insert(Pet pet)
        {
            try
            {


                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Pet(codcliente,nome,especie,raca,porte,sexo,cor) values(@codcliente,@nome,@especie,@raca,@porte,@sexo,@cor)";


                comando.Parameters.AddWithValue("@codcliente", pet.Cliente.Codigo);
                comando.Parameters.AddWithValue("@nome", pet.Nome);
                comando.Parameters.AddWithValue("especie", pet.Especie);
                comando.Parameters.AddWithValue("@raca", pet.Raca);
                comando.Parameters.AddWithValue("@porte", pet.Porte);
                comando.Parameters.AddWithValue("@sexo", pet.Sexo);
                comando.Parameters.AddWithValue("@cor", pet.Cor);



                ConexaoBanco.CRUD(comando);//Esta sendo  enviado o comando para  o metodo CRUD
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel se Inserir" + ex.Message);
            }
        }

        //Botão Buscar
        public Pet BuscarPorId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from pet where codPet=@id";

            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Pet pet = new Pet();
            ClienteDAO clienteDAO = new ClienteDAO();
            if (dr.HasRows)
            {
                dr.Read();
                pet.CodPet = (int)dr["codPet"];
                pet.Cliente = clienteDAO.BuscarPorId((int)dr["codcliente"]);
                pet.Nome = (string)dr["nome"];
                pet.Raca = (string)dr["raca"];
                pet.Porte = (string)dr["porte"];
                pet.Sexo = (string)dr["sexo"];
                pet.Cor = (string)dr["cor"];
                pet.Especie = (string)dr["especie"];
            }
            else
            {
                pet.CodPet = 0;
                pet.Cliente.Codigo = 0;
                pet.Nome = "";
                pet.Raca = "";
                pet.Porte = "";
                pet.Sexo = "";
                pet.Cor = "";
                pet.Especie = "";
            }
            return pet;
        }
    }
}
