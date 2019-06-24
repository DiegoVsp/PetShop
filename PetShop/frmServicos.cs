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

        // instanciado em todos os botões
        Servico servico = new Servico();
        ServicosBO servicoBO = new ServicosBO();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                servico.CodServico = Convert.ToInt16(txtCodServico.Text);
                servico.Porte = txtPorte.Text.ToUpper();
                servico.Tipo = txtTipo.Text.ToUpper();
                servico.Valor = Convert.ToSingle(txtValor.Text);

                servicoBO.Editar(servico);
                MessageBox.Show("Update Realizado Com sucesso!");
            }
            catch
            {
                MessageBox.Show("Preencha corretamente os campos necessarios", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            servico.CodServico = Convert.ToInt16(txtCodServico.Text);
            servicoBO.Buscar(servico);
            
            if(servico.Tipo=="")
            {
                MessageBox.Show("Servico não cadastrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPorte.Text = servico.Porte;
                txtTipo.Text = servico.Tipo;
                txtValor.Text = Convert.ToString(servico.Valor.ToString("C"));
            }
        }
    }
}
