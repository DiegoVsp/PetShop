namespace PetShop
{
    partial class frmFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCartTrab = new System.Windows.Forms.TextBox();
            this.lblCartTrab = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCalcularSalário = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpFuncionario = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblFechar = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(127, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalario.Location = new System.Drawing.Point(25, 166);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(56, 13);
            this.lblSalario.TabIndex = 65;
            this.lblSalario.Text = "SALÁRIO:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(127, 159);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(171, 20);
            this.txtSalario.TabIndex = 10;
            // 
            // txtCartTrab
            // 
            this.txtCartTrab.Location = new System.Drawing.Point(127, 129);
            this.txtCartTrab.Name = "txtCartTrab";
            this.txtCartTrab.Size = new System.Drawing.Size(171, 20);
            this.txtCartTrab.TabIndex = 8;
            // 
            // lblCartTrab
            // 
            this.lblCartTrab.AutoSize = true;
            this.lblCartTrab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCartTrab.Location = new System.Drawing.Point(25, 136);
            this.lblCartTrab.Name = "lblCartTrab";
            this.lblCartTrab.Size = new System.Drawing.Size(96, 13);
            this.lblCartTrab.TabIndex = 62;
            this.lblCartTrab.Text = "CARTEIRA TRAB:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(449, 129);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(171, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(127, 104);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(171, 20);
            this.txtNum.TabIndex = 6;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(449, 101);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(171, 20);
            this.txtEnd.TabIndex = 7;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(449, 75);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(171, 20);
            this.txtCep.TabIndex = 5;
            this.txtCep.Leave += new System.EventHandler(this.cep_leave);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(127, 19);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(48, 20);
            this.txtCod.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefone.Location = new System.Drawing.Point(25, 82);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 13);
            this.lblTelefone.TabIndex = 54;
            this.lblTelefone.Text = "TELEFONE:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCidade.Location = new System.Drawing.Point(347, 136);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 53;
            this.lblCidade.Text = "CIDADE:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumero.Location = new System.Drawing.Point(25, 111);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 13);
            this.lblNumero.TabIndex = 52;
            this.lblNumero.Text = "NÚMERO:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCep.Location = new System.Drawing.Point(349, 80);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 51;
            this.lblCep.Text = "CEP:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndereco.Location = new System.Drawing.Point(347, 104);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(70, 13);
            this.lblEndereco.TabIndex = 50;
            this.lblEndereco.Text = "ENDEREÇO:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCpf.Location = new System.Drawing.Point(350, 49);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 49;
            this.lblCpf.Text = "CPF:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCod.Location = new System.Drawing.Point(25, 24);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(52, 13);
            this.lblCod.TabIndex = 48;
            this.lblCod.Text = "CÓDIGO:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(25, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 47;
            this.lblNome.Text = "NOME:";
            // 
            // btnCalcularSalário
            // 
            this.btnCalcularSalário.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSalário.Location = new System.Drawing.Point(539, 224);
            this.btnCalcularSalário.Name = "btnCalcularSalário";
            this.btnCalcularSalário.Size = new System.Drawing.Size(110, 37);
            this.btnCalcularSalário.TabIndex = 14;
            this.btnCalcularSalário.Text = "CALCULAR SALÁRIO";
            this.btnCalcularSalário.UseVisualStyleBackColor = true;
            this.btnCalcularSalário.Click += new System.EventHandler(this.btnCalcularSalário_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(214, 238);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "UPDATE";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(387, 238);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "BUSCAR ID";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 104);
            this.dataGridView1.TabIndex = 66;
            // 
            // grpFuncionario
            // 
            this.grpFuncionario.Controls.Add(this.txtCpf);
            this.grpFuncionario.Controls.Add(this.txtTelefone);
            this.grpFuncionario.Controls.Add(this.txtCod);
            this.grpFuncionario.Controls.Add(this.lblNome);
            this.grpFuncionario.Controls.Add(this.lblCod);
            this.grpFuncionario.Controls.Add(this.txtNome);
            this.grpFuncionario.Controls.Add(this.lblCpf);
            this.grpFuncionario.Controls.Add(this.lblEndereco);
            this.grpFuncionario.Controls.Add(this.lblSalario);
            this.grpFuncionario.Controls.Add(this.lblCep);
            this.grpFuncionario.Controls.Add(this.lblNumero);
            this.grpFuncionario.Controls.Add(this.txtSalario);
            this.grpFuncionario.Controls.Add(this.lblCidade);
            this.grpFuncionario.Controls.Add(this.lblTelefone);
            this.grpFuncionario.Controls.Add(this.txtCartTrab);
            this.grpFuncionario.Controls.Add(this.lblCartTrab);
            this.grpFuncionario.Controls.Add(this.txtCidade);
            this.grpFuncionario.Controls.Add(this.txtCep);
            this.grpFuncionario.Controls.Add(this.txtNum);
            this.grpFuncionario.Controls.Add(this.txtEnd);
            this.grpFuncionario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpFuncionario.Location = new System.Drawing.Point(27, 12);
            this.grpFuncionario.Name = "grpFuncionario";
            this.grpFuncionario.Size = new System.Drawing.Size(632, 194);
            this.grpFuncionario.TabIndex = 67;
            this.grpFuncionario.TabStop = false;
            this.grpFuncionario.Text = "CADASTRO FUNCIONÁRIOS";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(449, 42);
            this.txtCpf.Mask = "000-000-000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 67;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(127, 80);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 66;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechar.Location = new System.Drawing.Point(664, 7);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(14, 13);
            this.lblFechar.TabIndex = 82;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(55, 238);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 22);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNome.Location = new System.Drawing.Point(387, 209);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(112, 23);
            this.btnBuscarNome.TabIndex = 83;
            this.btnBuscarNome.Text = "BUSCAR NOME";
            this.btnBuscarNome.UseVisualStyleBackColor = true;
            this.btnBuscarNome.Click += new System.EventHandler(this.BtnBuscarNome_Click);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(686, 386);
            this.Controls.Add(this.btnBuscarNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.grpFuncionario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCalcularSalário);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpFuncionario.ResumeLayout(false);
            this.grpFuncionario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCartTrab;
        private System.Windows.Forms.Label lblCartTrab;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCalcularSalário;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpFuncionario;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Button btnBuscarNome;
    }
}