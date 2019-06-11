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

            cliente.Nome = txtNome.Text;
            cliente.Cpf = Convert.ToInt32(txtCpf.Text);
            cliente.Cep = txtCep.Text;
            cliente.Endereco = txtEnd.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Numero = txtNum.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;

            clienteBO.GravarCliente(cliente);
            MessageBox.Show("Cliente Cadastrado com sucesso!!!");

            txtNome.Clear();
            txtCpf.Clear();
            txtCep.Clear();
            txtEnd.Clear();
            txtCidade.Clear();
            txtNum.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();

        }

        private void cep_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCep.Text))
                MessageBox.Show("O campo de CEP esta vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(txtCep.Text);

                    if (retorno is null)
                    {
                        MessageBox.Show("CEP não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    txtEnd.Text = retorno.end;
                    txtCidade.Text = retorno.cidade;
                    txtCep.Text = retorno.cep;
                }
                catch
                {
                    MessageBox.Show("CEP NÃO ENCONTRADO", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }



            }
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            cliente.Codigo = Convert.ToInt16(txtCod.Text);
            cliente.Nome = txtNome.Text;
            cliente.Cpf = Convert.ToInt32(txtCpf.Text);
            cliente.Cep = txtCep.Text;
            cliente.Endereco = txtEnd.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Numero = txtNum.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;

            clienteBO.Editar(cliente);
            MessageBox.Show("Update Realizado Com sucesso!");

            txtCod.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtCep.Clear();
            txtEnd.Clear();
            txtCidade.Clear();
            txtNum.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            try
            {
                cliente.Codigo = Convert.ToInt16(txtCod.Text);
                clienteBO.Buscar(cliente);
                if (cliente.Nome == "")
                {
                    MessageBox.Show("Cliente não encontrado");

                    txtCod.Clear();
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtCep.Clear();
                    txtEnd.Clear();
                    txtCidade.Clear();
                    txtNum.Clear();
                    txtTelefone.Clear();
                    txtEmail.Clear();

                }
                else
                {
                    txtNome.Text = cliente.Nome;
                    txtCpf.Text = Convert.ToString(cliente.Cpf);
                    txtCep.Text = cliente.Cep;
                    txtEnd.Text = cliente.Endereco;
                    txtCidade.Text = cliente.Cidade;
                    txtNum.Text = cliente.Numero;
                    txtTelefone.Text = cliente.Telefone;
                    txtEmail.Text = cliente.Email;
                }
            }
            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
