using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente form = new frmCliente();
            form.Show();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario form = new frmFuncionario();
            form.Show();
        }

        private void brnAtendimento_Click(object sender, EventArgs e)
        {
            frmAtendimento form = new frmAtendimento();
            form.Show();
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            frmPet form = new frmPet();
            form.Show();
        }

        private void btnServiços_Click(object sender, EventArgs e)
        {
            frmServicos form = new frmServicos();
            form.Show();
        }
    }
}
