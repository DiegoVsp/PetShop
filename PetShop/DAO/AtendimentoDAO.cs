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
                comando.Parameters.AddWithValue("@codFunc", atendimento.Funcionario.Codigo);
                comando.Parameters.AddWithValue("@dataHora", atendimento.DataHora);
                comando.Parameters.AddWithValue("@situacao", atendimento.Situacao);

                ConexaoBanco.CRUD(comando);//Esta sendo  enviado o comando para  o metodo CRUD
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel se conectar" + ex.Message);
            }

        }

        public IList<Atendimento> BuscarPorAtendimento(int codAt)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = " select a.codatend as Codigo,s.tipo as Servico,f.nome as Funcionario, " +
                "p.nome as Pet, a.datahora as Data_Hora, a.situacao Situacao from atendimento a " +
                "inner join funcionario f on a.codfunc=f.codfunc inner join servico s on a.codserv=s.codserv inner join " +
                "pet P on a.codPet=p.codPet where a.codatend like @codAt;";

            comando.Parameters.AddWithValue("@codAt", "%" + codAt + "%");

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Atendimento> atendimentos = new List<Atendimento>();
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            ServicosDAO servicosDAO = new ServicosDAO();
            PetDAO petDAO = new PetDAO();

            if (dr.HasRows)
            {
                while (dr.Read());
                {
                    Atendimento atendimento = new Atendimento();

                    atendimento.CodAtendimento = (int)dr["Codigo"];
                    atendimento.Servico.Tipo = (string)dr["Servico"];
                    atendimento.Funcionario.Nome = (string)dr["Funcionario"];
                    atendimento.Pet.Nome = (string)dr["Pet"];
                    atendimento.DataHora = (DateTime)dr["Data_Hora"];
                    atendimento.Situacao = (string)dr["Situacao"];

                    atendimentos.Add(atendimento);
                }

            }
            else
            {
                atendimentos = null;
            }
            return atendimentos;


        }
        public IList<Atendimento> BuscarPorPeriodo(DateTime Per)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select a.DATAHORA as Periodo,a.codatend as Codigo,s.tipo as Servico, f.nome as Funcionario," +
                "p.nome as Pet,  a.situacao Situacao from atendimento a inner join funcionario f on a.codfunc=f.codfunc inner join servico s on a.codserv=s.codserv inner join pet p on a.codpet = p.codpet" +
                " where a.datahora like @Per";

            comando.Parameters.AddWithValue("@Per", "%" + Per + "%");

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Atendimento> atendimentos = new List<Atendimento>();
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            ServicosDAO servicosDAO = new ServicosDAO();
            PetDAO petDAO = new PetDAO();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Atendimento atendimento = new Atendimento();

                    atendimento.CodAtendimento = (int)dr["Codigo"];
                    atendimento.Servico.Tipo = (string)dr["Servico"];
                    atendimento.Funcionario.Nome = (string)dr["Funcionario"];
                    atendimento.Pet.Nome = (string)dr["Pet"];
                    atendimento.DataHora = (DateTime)dr["Periodo"];
                    atendimento.Situacao = (string)dr["Situacao"];

                    atendimentos.Add(atendimento);
                }

            }
            else
            {
                atendimentos = null;
            }
            return atendimentos;

        }
    }
}


