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
    class ClienteDAO
    {
        public void Insert(Cliente cliente)
        {
            try
            {


                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Cliente(nome,cpf,cep,endereco,cidade,numero,telefone,email) values(@nome,@cpf,@cep,@endereco,@cidade,@numero,@telefone,@email)";

                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                comando.Parameters.AddWithValue("@cep", cliente.Cep);
                comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                comando.Parameters.AddWithValue("@numero", cliente.Numero);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);


                ConexaoBanco.CRUD(comando);//Esta sendo  enviado o comando para  o metodo CRUD
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel se conectar" + ex.Message);
            }

        }

        public void Update(Cliente cliente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Cliente set nome=@nome,cpf=@cpf,endereco=@endereco,cep=@cep,cidade=@cidade,numero=@numero,telefone=@telefone,email=@email where codcli=@codcli";

                comando.Parameters.AddWithValue("@codcli", cliente.Codigo);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                comando.Parameters.AddWithValue("@cep", cliente.Cep);
                comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                comando.Parameters.AddWithValue("@numero", cliente.Numero);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);


                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel realizar o update" + ex.Message);
            }
        }

        public Cliente BuscarPorId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Cliente Where codcli=@id";

            comando.Parameters.AddWithValue("@id", id);

            //MySqlDataReader retorna uma tabela do BD
            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);


            Cliente cliente = new Cliente();

            if (dr.HasRows)
            {
                dr.Read();

                cliente.Codigo = (int)dr["codcli"];
                cliente.Nome = (string)dr["nome"];
                cliente.Telefone = (string)dr["telefone"];
                cliente.Cpf = (string)dr["cpf"];
                cliente.Cep = (string)dr["cep"];
                cliente.Endereco = (string)dr["endereco"];
                cliente.Cidade = (string)dr["cidade"];
                cliente.Numero = (string)dr["numero"];
                cliente.Email = (string)dr["email"];
                
                
            }
            else
            {
                cliente.Codigo = 0;
                cliente.Nome = "";
                cliente.Cpf = "";
                cliente.Cep = "";
                cliente.Endereco = "";
                cliente.Cidade = "";
                cliente.Numero = "";
                cliente.Telefone = "";
                cliente.Email = "";
            }
            return cliente;
        }

        public IList<Cliente> BuscarPorNome(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from cliente where nome like @nome";

            comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Cliente> clientes = new List<Cliente>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.Codigo = (int)dr["CodCli"];
                    cliente.Nome = (string)dr["Nome"];
                    cliente.Cpf = (string)dr["Cpf"];
                    cliente.Cep = (string)dr["Cep"];
                    cliente.Endereco = (string)dr["Endereco"];
                    cliente.Cidade = (string)dr["Cidade"];
                    cliente.Numero = (string)dr["Numero"];
                    cliente.Telefone = (string)dr["Telefone"];
                    cliente.Email = (string)dr["Email"];

                    clientes.Add(cliente);
                }
            }
            else
            {
                clientes = null;
            }
            return clientes;
        }
    }
}

