namespace PetShop
{
    partial class frmPet
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
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtPorte = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPorte = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblNomePet = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblCodPet = new System.Windows.Forms.Label();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.txtCodP = new System.Windows.Forms.TextBox();
            this.grpCadastroPets = new System.Windows.Forms.GroupBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpCadastroPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(354, 97);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(171, 22);
            this.txtEspecie.TabIndex = 78;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(104, 99);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(158, 22);
            this.txtCor.TabIndex = 77;
            // 
            // txtPorte
            // 
            this.txtPorte.Location = new System.Drawing.Point(104, 73);
            this.txtPorte.Name = "txtPorte";
            this.txtPorte.Size = new System.Drawing.Size(158, 22);
            this.txtPorte.TabIndex = 75;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(354, 45);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(171, 22);
            this.txtRaca.TabIndex = 74;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 22);
            this.txtNome.TabIndex = 73;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(354, 21);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(41, 22);
            this.txtCod.TabIndex = 72;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEspecie.Location = new System.Drawing.Point(273, 104);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(69, 16);
            this.lblEspecie.TabIndex = 71;
            this.lblEspecie.Text = "ESPÉCIE:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCor.Location = new System.Drawing.Point(23, 106);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(40, 16);
            this.lblCor.TabIndex = 70;
            this.lblCor.Text = "COR:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSexo.Location = new System.Drawing.Point(273, 78);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(47, 16);
            this.lblSexo.TabIndex = 69;
            this.lblSexo.Text = "SEXO:";
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPorte.Location = new System.Drawing.Point(23, 80);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(56, 16);
            this.lblPorte.TabIndex = 68;
            this.lblPorte.Text = "PORTE:";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRaca.Location = new System.Drawing.Point(273, 52);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(48, 16);
            this.lblRaca.TabIndex = 67;
            this.lblRaca.Text = "RAÇA:";
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomePet.Location = new System.Drawing.Point(20, 54);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(51, 16);
            this.lblNomePet.TabIndex = 66;
            this.lblNomePet.Text = "NOME:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(466, 179);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 23);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(232, 179);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 179);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 23);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechar.Location = new System.Drawing.Point(573, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(14, 13);
            this.lblFechar.TabIndex = 81;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // lblCodPet
            // 
            this.lblCodPet.AutoSize = true;
            this.lblCodPet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodPet.Location = new System.Drawing.Point(22, 26);
            this.lblCodPet.Name = "lblCodPet";
            this.lblCodPet.Size = new System.Drawing.Size(68, 16);
            this.lblCodPet.TabIndex = 64;
            this.lblCodPet.Text = "COD PET:";
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodCli.Location = new System.Drawing.Point(262, 24);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(86, 16);
            this.lblCodCli.TabIndex = 65;
            this.lblCodCli.Text = "CÓDIGO CLI:";
            // 
            // txtCodP
            // 
            this.txtCodP.Location = new System.Drawing.Point(104, 21);
            this.txtCodP.Name = "txtCodP";
            this.txtCodP.Size = new System.Drawing.Size(41, 22);
            this.txtCodP.TabIndex = 79;
            // 
            // grpCadastroPets
            // 
            this.grpCadastroPets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpCadastroPets.Controls.Add(this.txtCodP);
            this.grpCadastroPets.Controls.Add(this.txtSexo);
            this.grpCadastroPets.Controls.Add(this.lblCodCli);
            this.grpCadastroPets.Controls.Add(this.txtEspecie);
            this.grpCadastroPets.Controls.Add(this.lblCodPet);
            this.grpCadastroPets.Controls.Add(this.txtCor);
            this.grpCadastroPets.Controls.Add(this.lblNomePet);
            this.grpCadastroPets.Controls.Add(this.lblRaca);
            this.grpCadastroPets.Controls.Add(this.txtPorte);
            this.grpCadastroPets.Controls.Add(this.lblPorte);
            this.grpCadastroPets.Controls.Add(this.txtRaca);
            this.grpCadastroPets.Controls.Add(this.lblSexo);
            this.grpCadastroPets.Controls.Add(this.txtNome);
            this.grpCadastroPets.Controls.Add(this.lblCor);
            this.grpCadastroPets.Controls.Add(this.txtCod);
            this.grpCadastroPets.Controls.Add(this.lblEspecie);
            this.grpCadastroPets.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadastroPets.Location = new System.Drawing.Point(12, 23);
            this.grpCadastroPets.Name = "grpCadastroPets";
            this.grpCadastroPets.Size = new System.Drawing.Size(555, 140);
            this.grpCadastroPets.TabIndex = 80;
            this.grpCadastroPets.TabStop = false;
            this.grpCadastroPets.Text = "CADASTRO DE ANIMAIS";
            this.grpCadastroPets.Enter += new System.EventHandler(this.grpCadastroPets_Enter);
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(354, 71);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(171, 22);
            this.txtSexo.TabIndex = 76;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 154);
            this.dataGridView1.TabIndex = 81;
            // 
            // frmPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(595, 386);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.grpCadastroPets);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet";
            this.Load += new System.EventHandler(this.frmPet_Load_1);
            this.grpCadastroPets.ResumeLayout(false);
            this.grpCadastroPets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtPorte;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblNomePet;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCodPet;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.TextBox txtCodP;
        private System.Windows.Forms.GroupBox grpCadastroPets;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}