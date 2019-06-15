using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.MODEL;
using PetShop.BO;

namespace PetShop
{
    public partial class frmAtendimento : Form
    {
        public frmAtendimento()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();

            atendimento.CodAtendimento = Convert.ToInt16(txtCodAtendimento.Text);
            atendimento.Servico.CodServico = Convert.ToInt16(txtCodServico.Text);
            atendimento.Pet.CodPet = Convert.ToInt16(txtCodPet.Text);
            atendimento.Funcionario.Codigo = Convert.ToInt16(txtCodFunc.Text);
          //  atendimento.DataHora = Convert.ToDateTime(txtDataHora.Text);
            atendimento.Situacao = txtSituacao.Text;

            atendimentoBO.GravarAtendimento(atendimento);
        }
    }
}
