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
using Correios;

namespace PetShop
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            cliente.Nome = txtNomeCliente.Text;
            cliente.Cpf = Convert.ToInt32(txtCpfCliente.Text);
            cliente.Cep = txtCepCliente.Text;
            cliente.Endereco = txtEndCliente.Text;
            cliente.Cidade = txtCidadeCliente.Text;
            cliente.Numero = txtNumCliente.Text;
            cliente.Telefone = txtTelCliente.Text;
            cliente.Email = txtEmailCliente.Text;

            clienteBO.GravarCliente(cliente);
            MessageBox.Show("Cliente Cadastrado com sucesso!!!");

            txtNomeCliente.Clear();
            txtCpfCliente.Clear();
            txtCepCliente.Clear();
            txtEndCliente.Clear();
            txtCidadeCliente.Clear();
            txtNumCliente.Clear();
            txtTelCliente.Clear();
            txtEmailCliente.Clear();

        }

        private void cep_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCepCliente.Text))
                MessageBox.Show("O campo de CEP esta vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                CorreiosApi correiosApi = new CorreiosApi();
                var retorno = correiosApi.consultaCEP(txtCepCliente.Text);

                if(retorno is null)
                {
                    MessageBox.Show("CEP não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                txtEndCliente.Text = retorno.end;
                txtCidadeCliente.Text = retorno.cidade;
                txtCepCliente.Text = retorno.cep;
                
            }
        }
    }
}
