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
    class FuncionarioDAO
    {
        public void Insert(Funcionario funcionario)
        {
            try
            {


                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Funcionario(nome,cpf,cep,endereco,cidade,numero,telefone,carttrab,salario) values(@nome,@cpf,@cep,@endereco,@cidade,@numero,@telefone,@carttrab,@salario)";

                
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("cep", funcionario.Cep);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@carttrab", funcionario.CartTrab);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);


                ConexaoBanco.CRUD(comando);//Esta sendo  enviado o comando para  o metodo CRUD
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel se Inserir" + ex.Message);
            }

        }

        public Funcionario BuscarPorId(int id)
        {

            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Funcionario where codfunc=@id";

            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Funcionario funcionario = new Funcionario();

            if (dr.HasRows)
            {
                dr.Read();
                
                funcionario.Nome = (string)dr["nome"];
                funcionario.Telefone = (string)dr["telefone"];
                funcionario.Cpf = (long)dr["cpf"];
                funcionario.Cep = (string)dr["cep"];
                funcionario.Endereco = (string)dr["endereco"];
                funcionario.Cidade = (string)dr["cidade"];
                funcionario.Numero = (string)dr["numero"];
                funcionario.CartTrab = (string)dr["carttrab"];
                funcionario.Salario = (decimal)dr["salario"];
            }
            else
            {
                funcionario.Codigo = 0;
                funcionario.Nome = "";
                funcionario.Cpf = 0;
                funcionario.Cep = "";
                funcionario.Endereco = "";
                funcionario.Cidade = "";
                funcionario.Numero = "";
                funcionario.Telefone = "";
                funcionario.CartTrab = "";
                funcionario.Salario = 0;
            }
            return funcionario;
        }


        public void Update(Funcionario funcionario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Funcionario set nome=@nome,cpf=@cpf,cep=@cep,endereco=@endereco,cidade=@cidade,numero=@numero,telefone=@telefone,carttrab=@cartTrab,salario=@salario where codfunc=@codfunc";

                comando.Parameters.AddWithValue("@codfunc", funcionario.Codigo);
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@cep", funcionario.Cep);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@cartTrab", funcionario.CartTrab);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);

                ConexaoBanco.CRUD(comando);
            }           

             catch (Exception ex)
            {
                throw new Exception("Não foi possivel realizar o UPDATE" + ex.Message);
            }

        }

    }
}
