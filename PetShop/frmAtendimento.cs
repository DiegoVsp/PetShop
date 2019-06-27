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

        Atendimento atendimento = new Atendimento();
        AtendimentoBO atendimentoBO = new AtendimentoBO();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            try
            {
                atendimento.Servico.CodServico = Convert.ToInt16(txtCodServico.Text);
                atendimento.Pet.CodPet = Convert.ToInt16(txtCodPet.Text);
                atendimento.Funcionario.Codigo = Convert.ToInt16(txtCodFunc.Text);
                atendimento.DataHora = Convert.ToDateTime(MtxtDataHora.Text);
                atendimento.Situacao = comboBox1.Text;

                atendimentoBO.GravarAtendimento(atendimento);

                MessageBox.Show("Atendimento Cadastrado com Sucesso!");
            }
            catch
            {
                MessageBox.Show("Insira os dados Corretamente", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarAtendimento_Click(object sender, EventArgs e)
        {

            try
            {
                atendimento.CodAtendimento = Convert.ToInt16(txtCodAtendimento.Text);
                dataGridView1.DataSource = atendimentoBO.BuscarPorAtendimento(atendimento);
                txtCodAtendimento.Clear();
            }
            catch
            {
                MessageBox.Show("Preencha corretamente!!");
            }
            

        }

        private void frmAtendimento_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBuscarPorPeriodo_Click(object sender, EventArgs e)
        {
           
           
        }

        private void BtnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();


            try
            { 
                atendimento.Funcionario.Codigo = Convert.ToInt16(txtCodFunc.Text);

                dataGridView1.DataSource = atendimentoBO.BuscaPorFuncionario(atendimento);
                txtCodFunc.Clear();
            }

            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!");
            }

            



        }

        private void BtnBuscarPet_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();


            try
            {


                atendimento.Pet.CodPet = Convert.ToInt16(txtCodPet.Text);

                dataGridView1.DataSource = atendimentoBO.BuscaPet(atendimento);

                txtCodPet.Clear();


            }
            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!");
            }
            
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
