﻿namespace PetShop
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
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCalcularSalário = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(252, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalario.Location = new System.Drawing.Point(447, 275);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(56, 13);
            this.lblSalario.TabIndex = 65;
            this.lblSalario.Text = "SALÁRIO:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(503, 272);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(171, 20);
            this.txtSalario.TabIndex = 10;
            // 
            // txtCartTrab
            // 
            this.txtCartTrab.Location = new System.Drawing.Point(252, 272);
            this.txtCartTrab.Name = "txtCartTrab";
            this.txtCartTrab.Size = new System.Drawing.Size(171, 20);
            this.txtCartTrab.TabIndex = 9;
            // 
            // lblCartTrab
            // 
            this.lblCartTrab.AutoSize = true;
            this.lblCartTrab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCartTrab.Location = new System.Drawing.Point(161, 279);
            this.lblCartTrab.Name = "lblCartTrab";
            this.lblCartTrab.Size = new System.Drawing.Size(96, 13);
            this.lblCartTrab.TabIndex = 62;
            this.lblCartTrab.Text = "CARTEIRA TRAB:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(503, 196);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(171, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(252, 236);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(171, 20);
            this.txtNum.TabIndex = 8;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(252, 198);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(171, 20);
            this.txtEnd.TabIndex = 6;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(254, 161);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(171, 20);
            this.txtCep.TabIndex = 5;
            this.txtCep.Leave += new System.EventHandler(this.cep_leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(252, 127);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(171, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(503, 93);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(117, 20);
            this.txtCpf.TabIndex = 3;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(254, 69);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(48, 20);
            this.txtCod.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefone.Location = new System.Drawing.Point(161, 134);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 13);
            this.lblTelefone.TabIndex = 54;
            this.lblTelefone.Text = "TELEFONE:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCidade.Location = new System.Drawing.Point(447, 201);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 53;
            this.lblCidade.Text = "CIDADE:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumero.Location = new System.Drawing.Point(161, 243);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 13);
            this.lblNumero.TabIndex = 52;
            this.lblNumero.Text = "NÚMERO:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCep.Location = new System.Drawing.Point(163, 168);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 51;
            this.lblCep.Text = "CEP:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndereco.Location = new System.Drawing.Point(161, 203);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(70, 13);
            this.lblEndereco.TabIndex = 50;
            this.lblEndereco.Text = "ENDEREÇO:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCpf.Location = new System.Drawing.Point(448, 100);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 49;
            this.lblCpf.Text = "CPF:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCod.Location = new System.Drawing.Point(163, 74);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(52, 13);
            this.lblCod.TabIndex = 48;
            this.lblCod.Text = "CÓDIGO:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(161, 104);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 47;
            this.lblNome.Text = "NOME:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.btnCalcularSalário);
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.btnCadastrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 331);
            this.panel3.TabIndex = 46;
            // 
            // btnCalcularSalário
            // 
            this.btnCalcularSalário.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSalário.Location = new System.Drawing.Point(12, 106);
            this.btnCalcularSalário.Name = "btnCalcularSalário";
            this.btnCalcularSalário.Size = new System.Drawing.Size(110, 37);
            this.btnCalcularSalário.TabIndex = 22;
            this.btnCalcularSalário.Text = "CALCULAR SALÁRIO";
            this.btnCalcularSalário.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(12, 41);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 23);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(12, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(10, 11);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 23);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.Leave += new System.EventHandler(this.cep_leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 55);
            this.panel1.TabIndex = 45;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechar.Location = new System.Drawing.Point(660, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(14, 13);
            this.lblFechar.TabIndex = 67;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "FUNCIONÁRIOS";
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(686, 386);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCartTrab);
            this.Controls.Add(this.lblCartTrab);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCalcularSalário;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechar;
    }
}