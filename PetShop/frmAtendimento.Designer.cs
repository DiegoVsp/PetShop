namespace PetShop
{
    partial class frmAtendimento
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
            this.btnBuscarPet = new System.Windows.Forms.Button();
            this.btnBuscarAtendimento = new System.Windows.Forms.Button();
            this.btnBuscarPorPeriodo = new System.Windows.Forms.Button();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCodServico = new System.Windows.Forms.TextBox();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.txtCodPet = new System.Windows.Forms.TextBox();
            this.txtCodAtendimento = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblNomePet = new System.Windows.Forms.Label();
            this.lblCodPet = new System.Windows.Forms.Label();
            this.lblCodAtendimento = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MtxtDataHora = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFechar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarPet
            // 
            this.btnBuscarPet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPet.Location = new System.Drawing.Point(559, 196);
            this.btnBuscarPet.Name = "btnBuscarPet";
            this.btnBuscarPet.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarPet.TabIndex = 25;
            this.btnBuscarPet.Text = "PET";
            this.btnBuscarPet.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAtendimento
            // 
            this.btnBuscarAtendimento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAtendimento.Location = new System.Drawing.Point(169, 196);
            this.btnBuscarAtendimento.Name = "btnBuscarAtendimento";
            this.btnBuscarAtendimento.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarAtendimento.TabIndex = 24;
            this.btnBuscarAtendimento.Text = "ATENDIMENTO";
            this.btnBuscarAtendimento.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPorPeriodo
            // 
            this.btnBuscarPorPeriodo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorPeriodo.Location = new System.Drawing.Point(295, 196);
            this.btnBuscarPorPeriodo.Name = "btnBuscarPorPeriodo";
            this.btnBuscarPorPeriodo.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarPorPeriodo.TabIndex = 23;
            this.btnBuscarPorPeriodo.Text = "PERIODO";
            this.btnBuscarPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(423, 196);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarFuncionario.TabIndex = 22;
            this.btnBuscarFuncionario.Text = "FUNCIONÁRIO";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(33, 196);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 23);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCodServico
            // 
            this.txtCodServico.Location = new System.Drawing.Point(511, 30);
            this.txtCodServico.Name = "txtCodServico";
            this.txtCodServico.Size = new System.Drawing.Size(88, 20);
            this.txtCodServico.TabIndex = 2;
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(511, 70);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(88, 20);
            this.txtCodFunc.TabIndex = 4;
            // 
            // txtCodPet
            // 
            this.txtCodPet.Location = new System.Drawing.Point(169, 69);
            this.txtCodPet.Name = "txtCodPet";
            this.txtCodPet.Size = new System.Drawing.Size(84, 20);
            this.txtCodPet.TabIndex = 3;
            // 
            // txtCodAtendimento
            // 
            this.txtCodAtendimento.Location = new System.Drawing.Point(169, 29);
            this.txtCodAtendimento.Name = "txtCodAtendimento";
            this.txtCodAtendimento.Size = new System.Drawing.Size(84, 20);
            this.txtCodAtendimento.TabIndex = 1;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRaca.Location = new System.Drawing.Point(354, 77);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(129, 13);
            this.lblRaca.TabIndex = 83;
            this.lblRaca.Text = "CÓDIGO FUNCIONARIO:";
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomePet.Location = new System.Drawing.Point(30, 78);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(76, 13);
            this.lblNomePet.TabIndex = 82;
            this.lblNomePet.Text = "CODIGO PET:";
            // 
            // lblCodPet
            // 
            this.lblCodPet.AutoSize = true;
            this.lblCodPet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodPet.Location = new System.Drawing.Point(354, 33);
            this.lblCodPet.Name = "lblCodPet";
            this.lblCodPet.Size = new System.Drawing.Size(83, 13);
            this.lblCodPet.TabIndex = 80;
            this.lblCodPet.Text = "COD SERVIÇO:";
            // 
            // lblCodAtendimento
            // 
            this.lblCodAtendimento.AutoSize = true;
            this.lblCodAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodAtendimento.Location = new System.Drawing.Point(30, 32);
            this.lblCodAtendimento.Name = "lblCodAtendimento";
            this.lblCodAtendimento.Size = new System.Drawing.Size(134, 13);
            this.lblCodAtendimento.TabIndex = 81;
            this.lblCodAtendimento.Text = "CÓDIGO ATENDIMENTO:";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDataHora.Location = new System.Drawing.Point(30, 119);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(75, 13);
            this.lblDataHora.TabIndex = 88;
            this.lblDataHora.Text = "DATA/HORA:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSituacao.Location = new System.Drawing.Point(354, 117);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(64, 13);
            this.lblSituacao.TabIndex = 89;
            this.lblSituacao.Text = "SITUAÇÃO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 135);
            this.dataGridView1.TabIndex = 92;
            // 
            // MtxtDataHora
            // 
            this.MtxtDataHora.Location = new System.Drawing.Point(169, 112);
            this.MtxtDataHora.Mask = "00/00/0000 90:00";
            this.MtxtDataHora.Name = "MtxtDataHora";
            this.MtxtDataHora.Size = new System.Drawing.Size(97, 20);
            this.MtxtDataHora.TabIndex = 5;
            this.MtxtDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PAGO",
            "EM ABERTO"});
            this.comboBox1.Location = new System.Drawing.Point(511, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechar.Location = new System.Drawing.Point(660, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(14, 13);
            this.lblFechar.TabIndex = 93;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodServico);
            this.groupBox1.Controls.Add(this.lblCodAtendimento);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblCodPet);
            this.groupBox1.Controls.Add(this.MtxtDataHora);
            this.groupBox1.Controls.Add(this.lblNomePet);
            this.groupBox1.Controls.Add(this.lblRaca);
            this.groupBox1.Controls.Add(this.txtCodAtendimento);
            this.groupBox1.Controls.Add(this.txtCodPet);
            this.groupBox1.Controls.Add(this.txtCodFunc);
            this.groupBox1.Controls.Add(this.lblSituacao);
            this.groupBox1.Controls.Add(this.lblDataHora);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(33, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 148);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CADASTRO ATENDIMENTO";
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(686, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarPet);
            this.Controls.Add(this.btnBuscarAtendimento);
            this.Controls.Add(this.btnBuscarPorPeriodo);
            this.Controls.Add(this.btnBuscarFuncionario);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarPet;
        private System.Windows.Forms.Button btnBuscarAtendimento;
        private System.Windows.Forms.Button btnBuscarPorPeriodo;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCodServico;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.TextBox txtCodPet;
        private System.Windows.Forms.TextBox txtCodAtendimento;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblNomePet;
        private System.Windows.Forms.Label lblCodPet;
        private System.Windows.Forms.Label lblCodAtendimento;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox MtxtDataHora;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}