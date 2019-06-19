namespace PetShop
{
    partial class frmServicos
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodServico = new System.Windows.Forms.TextBox();
            this.lblCodPet = new System.Windows.Forms.Label();
            this.txtPorte = new System.Windows.Forms.TextBox();
            this.lblPorte = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(327, 133);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 36);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(522, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 36);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(101, 133);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 36);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.panel1.TabIndex = 24;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechar.Location = new System.Drawing.Point(660, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(14, 13);
            this.lblFechar.TabIndex = 96;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SERVIÇOS";
            // 
            // txtCodServico
            // 
            this.txtCodServico.Location = new System.Drawing.Point(101, 67);
            this.txtCodServico.Name = "txtCodServico";
            this.txtCodServico.Size = new System.Drawing.Size(48, 20);
            this.txtCodServico.TabIndex = 89;
            // 
            // lblCodPet
            // 
            this.lblCodPet.AutoSize = true;
            this.lblCodPet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodPet.Location = new System.Drawing.Point(12, 71);
            this.lblCodPet.Name = "lblCodPet";
            this.lblCodPet.Size = new System.Drawing.Size(83, 13);
            this.lblCodPet.TabIndex = 88;
            this.lblCodPet.Text = "COD SERVIÇO:";
            // 
            // txtPorte
            // 
            this.txtPorte.Location = new System.Drawing.Point(101, 96);
            this.txtPorte.Name = "txtPorte";
            this.txtPorte.Size = new System.Drawing.Size(163, 20);
            this.txtPorte.TabIndex = 91;
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPorte.Location = new System.Drawing.Point(12, 99);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(47, 13);
            this.lblPorte.TabIndex = 90;
            this.lblPorte.Text = "PORTE:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(271, 68);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(163, 20);
            this.txtTipo.TabIndex = 93;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipo.Location = new System.Drawing.Point(216, 74);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 13);
            this.lblTipo.TabIndex = 92;
            this.lblTipo.Text = "TIPO:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(531, 68);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(92, 20);
            this.txtValor.TabIndex = 95;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValor.Location = new System.Drawing.Point(475, 72);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 13);
            this.lblValor.TabIndex = 94;
            this.lblValor.Text = "VALOR:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 150);
            this.dataGridView1.TabIndex = 96;
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(686, 386);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtPorte);
            this.Controls.Add(this.lblPorte);
            this.Controls.Add(this.txtCodServico);
            this.Controls.Add(this.lblCodPet);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodServico;
        private System.Windows.Forms.Label lblCodPet;
        private System.Windows.Forms.TextBox txtPorte;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}