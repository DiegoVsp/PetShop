using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.MODEL
{
    public class Funcionario:Pessoa
    {
        
        private string cartTrab;
        private decimal salario;

        public string CartTrab { get => cartTrab; set => cartTrab = value; }
        public decimal Salario { get => salario; set => salario = value; }
        

    }
}
