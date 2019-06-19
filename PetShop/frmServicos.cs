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
    public partial class frmServicos : Form
    {
        public frmServicos()
        {
            InitializeComponent();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            ServicosBO servicoBO = new ServicosBO();
            try
            {
                servico.Tipo = txtTipo.Text.ToUpper();
                servico.Porte = txtPorte.Text.ToUpper();
                servico.Valor = Convert.ToSingle(txtValor.Text);  //ToSingle == ToFloat

                servicoBO.GravarServico(servico);
                MessageBox.Show("Serviço cadstrado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Digite os dados corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
