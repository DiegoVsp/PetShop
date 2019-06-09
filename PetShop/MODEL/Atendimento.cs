using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.MODEL
{
    public class Atendimento
    {
        private int codAtendimento;
        private Servico servico;
        private Pet pet;
        private Funcionario funcionario;
        private DateTime dataHora;
        private string situacao;

        public Atendimento()
        {
            Servico = new Servico();
            Funcionario = new Funcionario();
            Pet = new Pet();
        }

        public int CodAtendimento { get => codAtendimento; set => codAtendimento = value; }
        public Servico Servico { get => servico; set => servico = value; }
        public Pet Pet { get => pet; set => pet = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        public DateTime DataHora { get => dataHora; set => dataHora = value; }
        public string Situacao { get => situacao; set => situacao = value; }
    }
}
