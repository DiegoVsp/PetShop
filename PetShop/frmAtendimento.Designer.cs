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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscarPet = new System.Windows.Forms.Button();
            this.btnBuscarAtendimento = new System.Windows.Forms.Button();
            this.btnBuscarPorPeriodo = new System.Windows.Forms.Button();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.btnBuscarPet);
            this.panel3.Controls.Add(this.btnBuscarAtendimento);
            this.panel3.Controls.Add(this.btnBuscarPorPeriodo);
            this.panel3.Controls.Add(this.btnBuscarFuncionario);
            this.panel3.Controls.Add(this.btnCadastrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 331);
            this.panel3.TabIndex = 25;
            // 
            // btnBuscarPet
            // 
            this.btnBuscarPet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPet.Location = new System.Drawing.Point(10, 127);
            this.btnBuscarPet.Name = "btnBuscarPet";
            this.btnBuscarPet.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarPet.TabIndex = 25;
            this.btnBuscarPet.Text = "PET";
            this.btnBuscarPet.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAtendimento
            // 
            this.btnBuscarAtendimento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAtendimento.Location = new System.Drawing.Point(11, 40);
            this.btnBuscarAtendimento.Name = "btnBuscarAtendimento";
            this.btnBuscarAtendimento.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarAtendimento.TabIndex = 24;
            this.btnBuscarAtendimento.Text = "ATENDIMENTO";
            this.btnBuscarAtendimento.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPorPeriodo
            // 
            this.btnBuscarPorPeriodo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorPeriodo.Location = new System.Drawing.Point(10, 69);
            this.btnBuscarPorPeriodo.Name = "btnBuscarPorPeriodo";
            this.btnBuscarPorPeriodo.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarPorPeriodo.TabIndex = 23;
            this.btnBuscarPorPeriodo.Text = "PERIODO";
            this.btnBuscarPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(10, 98);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarFuncionario.TabIndex = 22;
            this.btnBuscarFuncionario.Text = "FUNCIONÁRIO";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(10, 11);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 23);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 55);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATENDIMENTO";
            // 
            // txtCodServico
            // 
            this.txtCodServico.Location = new System.Drawing.Point(498, 66);
            this.txtCodServico.Name = "txtCodServico";
            this.txtCodServico.Size = new System.Drawing.Size(58, 20);
            this.txtCodServico.TabIndex = 87;
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(498, 95);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(58, 20);
            this.txtCodFunc.TabIndex = 86;
            // 
            // txtCodPet
            // 
            this.txtCodPet.Location = new System.Drawing.Point(282, 98);
            this.txtCodPet.Name = "txtCodPet";
            this.txtCodPet.Size = new System.Drawing.Size(58, 20);
            this.txtCodPet.TabIndex = 85;
            // 
            // txtCodAtendimento
            // 
            this.txtCodAtendimento.Location = new System.Drawing.Point(282, 66);
            this.txtCodAtendimento.Name = "txtCodAtendimento";
            this.txtCodAtendimento.Size = new System.Drawing.Size(58, 20);
            this.txtCodAtendimento.TabIndex = 84;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRaca.Location = new System.Drawing.Point(359, 104);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(129, 13);
            this.lblRaca.TabIndex = 83;
            this.lblRaca.Text = "CÓDIGO FUNCIONARIO:";
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomePet.Location = new System.Drawing.Point(143, 107);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(76, 13);
            this.lblNomePet.TabIndex = 82;
            this.lblNomePet.Text = "CODIGO PET:";
            // 
            // lblCodPet
            // 
            this.lblCodPet.AutoSize = true;
            this.lblCodPet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodPet.Location = new System.Drawing.Point(359, 69);
            this.lblCodPet.Name = "lblCodPet";
            this.lblCodPet.Size = new System.Drawing.Size(83, 13);
            this.lblCodPet.TabIndex = 80;
            this.lblCodPet.Text = "COD SERVIÇO:";
            // 
            // lblCodAtendimento
            // 
            this.lblCodAtendimento.AutoSize = true;
            this.lblCodAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodAtendimento.Location = new System.Drawing.Point(143, 69);
            this.lblCodAtendimento.Name = "lblCodAtendimento";
            this.lblCodAtendimento.Size = new System.Drawing.Size(134, 13);
            this.lblCodAtendimento.TabIndex = 81;
            this.lblCodAtendimento.Text = "CÓDIGO ATENDIMENTO:";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDataHora.Location = new System.Drawing.Point(143, 133);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(75, 13);
            this.lblDataHora.TabIndex = 88;
            this.lblDataHora.Text = "DATA/HORA:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSituacao.Location = new System.Drawing.Point(393, 130);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(64, 13);
            this.lblSituacao.TabIndex = 89;
            this.lblSituacao.Text = "SITUAÇÃO:";
            // 
            // txtDataHora
            // 
            this.txtDataHora.Location = new System.Drawing.Point(282, 127);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.Size = new System.Drawing.Size(84, 20);
            this.txtDataHora.TabIndex = 90;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(475, 126);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(130, 20);
            this.txtSituacao.TabIndex = 91;
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(686, 386);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtDataHora);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.txtCodServico);
            this.Controls.Add(this.txtCodFunc);
            this.Controls.Add(this.txtCodPet);
            this.Controls.Add(this.txtCodAtendimento);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.lblNomePet);
            this.Controls.Add(this.lblCodPet);
            this.Controls.Add(this.lblCodAtendimento);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscarPet;
        private System.Windows.Forms.Button btnBuscarAtendimento;
        private System.Windows.Forms.Button btnBuscarPorPeriodo;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.TextBox txtSituacao;
    }
}