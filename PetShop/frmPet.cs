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
    public partial class frmPet : Form
    {
        public frmPet()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();
            try
            {
                pet.Cliente.Codigo = Convert.ToInt16(txtCod.Text);
                pet.Nome = txtNome.Text.ToUpper();
                pet.Porte = txtPorte.Text.ToUpper();
                pet.Cor = txtCor.Text.ToUpper();
                pet.Raca = txtRaca.Text.ToUpper();
                pet.Sexo = txtSexo.Text.ToUpper();
                pet.Especie = txtEspecie.Text.ToUpper();

                petBO.GravarPet(pet);
                MessageBox.Show("Pet Cadastrado com sucesso!");

                txtCod.Clear();
                txtNome.Clear();
                txtPorte.Clear();
                txtCor.Clear();
                txtRaca.Clear();
                txtSexo.Clear();
                txtEspecie.Clear();
            }
            catch
            {
                // MessageBox.Show("Preencha  corretamente as informações!!", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                MessageBox.Show("Preencha os dados corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();

            try
            {
                pet.CodPet = Convert.ToInt16(txtCodP.Text);
                petBO.BuscarPorId(pet);

                if (pet.Nome == "")
                {
                    MessageBox.Show("Pet não encontrado!");

                    txtCod.Clear();
                    txtCodP.Clear();
                    txtNome.Clear();
                    txtPorte.Clear();
                    txtCor.Clear();
                    txtRaca.Clear();
                    txtSexo.Clear();
                    txtEspecie.Clear();

                }
                else
                {

                    txtCod.Text = Convert.ToString(pet.Cliente.Codigo);
                    txtNome.Text = pet.Nome; // colocar .ToUpper() puxa toda informação em maiuscula
                    txtPorte.Text = pet.Porte;
                    txtCor.Text = pet.Cor;
                    txtRaca.Text = pet.Raca;
                    txtSexo.Text = pet.Sexo;
                    txtEspecie.Text = pet.Especie;
                }
            }
            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();

            pet.CodPet= Convert.ToInt16(txtCodP.Text);
            pet.Cliente.Codigo = Convert.ToInt16(txtCod.Text);
            pet.Nome = txtNome.Text.ToUpper();
            pet.Raca = txtRaca.Text.ToUpper();
            pet.Porte = txtPorte.Text.ToUpper();
            pet.Sexo = txtSexo.Text.ToUpper();
            pet.Cor = txtCor.Text.ToUpper();
            pet.Especie = txtEspecie.Text.ToUpper();

            petBO.Editar(pet);
                MessageBox.Show("Dados atualizados com sucesso!!");
           

        }



        private void grpCadastroPets_Enter(object sender, EventArgs e)
        {
            txtCodP.Enabled = true;
        }

        private void frmPet_Load_1(object sender, EventArgs e)
        {

        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarNome_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();
            try
            {
                pet.Nome = txtNome.Text;
                dataGridView1.DataSource = petBO.BuscarNPet(pet);
            }
            catch
            {
                MessageBox.Show("Preencha os dados Corretamente!!");
            }
        }
    }
}
