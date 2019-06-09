using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.MODEL
{
    public class Funcionario:Pessoa
    {
        private int codFunc;
        private string cartTrab;
        private float salario;

        public string CartTrab { get => cartTrab; set => cartTrab = value; }
        public float Salario { get => salario; set => salario = value; }
        public int CodFunc { get => codFunc; set => codFunc = value; }

    }
}
