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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.Endereco = txtEnd.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Numero = txtNum.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.CartTrab = txtCartTrab.Text;
            funcionario.Salario = Convert.ToDecimal(txtSalario.Text);

            funcionarioBO.GravarFuncionario(funcionario);
            MessageBox.Show("Funcionário Cadastrado com sucesso!!!");


            txtCod.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtCep.Clear();
            txtEnd.Clear();
            txtCidade.Clear();
            txtNum.Clear();
            txtTelefone.Clear();
            txtSalario.Clear();
            txtCartTrab.Clear();
        }

        private void cep_leave(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();
            try
            {
                funcionario.Codigo = Convert.ToInt16(txtCod.Text);
                funcionarioBO.Buscar(funcionario);

                if (funcionario.Nome == "")
                {
                    MessageBox.Show("Funcionário não encontrado!");

                    txtCod.Clear();
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtEnd.Clear();
                    txtCep.Clear();
                    txtNum.Clear();
                    txtCidade.Clear();
                    txtTelefone.Clear();
                    txtCartTrab.Clear();
                    txtSalario.Clear();
                }
                else
                {
                    txtNome.Text = funcionario.Nome;
                    txtCpf.Text = Convert.ToString(funcionario.Cpf);
                    txtCep.Text = funcionario.Cep;
                    txtEnd.Text = funcionario.Endereco;
                    txtCidade.Text = funcionario.Cidade;
                    txtNum.Text = funcionario.Numero;
                    txtTelefone.Text = funcionario.Telefone;
                    txtCartTrab.Text = funcionario.CartTrab;
                    txtSalario.Text = Convert.ToString(funcionario.Salario);

                }

            }
            catch
            {
                MessageBox.Show("Preencha os dados corretamente");
            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            funcionario.Codigo = Convert.ToInt16(txtCod.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.Endereco = txtEnd.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Numero = txtNum.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.CartTrab = txtCartTrab.Text;
            funcionario.Salario = Convert.ToDecimal(txtSalario.Text);

            funcionarioBO.Editar(funcionario);
            MessageBox.Show("Update Realizado com sucesso!");

            txtCod.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtCep.Clear();
            txtEnd.Clear();
            txtCidade.Clear();
            txtNum.Clear();
            txtTelefone.Clear();
            txtSalario.Clear();
            txtCartTrab.Clear();

        }

        private void btnCalcularSalário_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            funcionario.Codigo = Convert.ToInt16(txtCod.Text);
            funcionario.Salario = Convert.ToDecimal(txtSalario.Text);
            funcionarioBO.Calcular(funcionario);

            txtSalario.Text = Convert.ToString(funcionario.Salario);
        }

        private void lblFechar_Click_1(object sender, EventArgs e)
        {

            {
                this.Close();
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.Endereco = txtEnd.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Numero = txtNum.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.CartTrab = txtCartTrab.Text;
            funcionario.Salario = Convert.ToDecimal(txtSalario.Text);

            funcionarioBO.GravarFuncionario(funcionario);
            MessageBox.Show("Funcionário Cadastrado com sucesso!!!");


            txtCod.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtCep.Clear();
            txtEnd.Clear();
            txtCidade.Clear();
            txtNum.Clear();
            txtTelefone.Clear();
            txtSalario.Clear();
            txtCartTrab.Clear();
        }
    }
}
