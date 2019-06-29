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
            comando.CommandText = "Select * from Atendimento Where codAtend=@codAt";

            //" select a.codatend as Codigo,s.tipo as Servico,f.nome as Funcionario, " +
            //"p.nome as Pet, a.datahora as Data_Hora, a.situacao Situacao from atendimento a " +
            //"inner join funcionario f on a.codfunc=f.codfunc inner join servico s on a.codserv=s.codserv inner join " +
            //"pet P on a.codPet=p.codPet where a.codatend like @codAt";

            comando.Parameters.AddWithValue("@codAt", codAt);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Atendimento> atendimentos = new List<Atendimento>();
            

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Atendimento atendimento = new Atendimento();

                    atendimento.CodAtendimento = (int)dr["codAtend"];
                    atendimento.Servico.CodServico = (int)dr["codServ"];
                    atendimento.Pet.CodPet = (int)dr["codPet"];
                    atendimento.Funcionario.Codigo = (int)dr["codFunc"];
                    atendimento.DataHora = (DateTime)dr["DataHora"];
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

        public IList<Atendimento> BuscarPorFuncionario(int codF)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Atendimento Where codFunc=@codF";
            //"select f.codfunc, f.nome, a.codatend, s.tipo, p.nome, a.datahora, a.situacao from atendimento 
            //a inner join funcionario f on a.codfunc=f.codfunc inner join servico s on s.codserv = a.codserv inner join pet p on 
            //p.codPet = a.codPet where f.codfunc like @codF";


            comando.Parameters.AddWithValue("@codF", codF);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Atendimento> atendimentos = new List<Atendimento>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Atendimento atendimento = new Atendimento();


                    atendimento.CodAtendimento = (int)dr["codAtend"];
                    atendimento.Servico.CodServico = (int)dr["codServ"];
                    atendimento.Pet.CodPet = (int)dr["codPet"];
                    atendimento.Funcionario.Codigo = (int)dr["codFunc"];
                    atendimento.DataHora = (DateTime)dr["DataHora"];
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

        public IList<Atendimento> BuscaPet(int codPet)
        {

            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select *from Atendimento Where codpet=@codpet";

            comando.Parameters.AddWithValue("@codpet", codPet);



            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Atendimento> atendimentos = new List<Atendimento>();


            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    Atendimento atendimento = new Atendimento();

                    atendimento.CodAtendimento = (int)dr["codatend"];
                    atendimento.Servico.CodServico = (int)dr["codserv"];
                    atendimento.Pet.CodPet = (int)dr["codpet"];
                    atendimento.Funcionario.Codigo = (int)dr["codfunc"];
                    atendimento.DataHora = (DateTime)dr["datahora"];
                    atendimento.Situacao = (string)dr["situacao"];

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


