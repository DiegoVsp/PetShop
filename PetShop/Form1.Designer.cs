namespace PetShop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnServiços = new System.Windows.Forms.PictureBox();
            this.btnPet = new System.Windows.Forms.PictureBox();
            this.btnCliente = new System.Windows.Forms.PictureBox();
            this.btnFuncionario = new System.Windows.Forms.PictureBox();
            this.brnAtendimento = new System.Windows.Forms.PictureBox();
            this.lblFechar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnServiços)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnAtendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnServiços
            // 
            this.btnServiços.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnServiços.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnServiços.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiços.Image = ((System.Drawing.Image)(resources.GetObject("btnServiços.Image")));
            this.btnServiços.Location = new System.Drawing.Point(420, 326);
            this.btnServiços.Name = "btnServiços";
            this.btnServiços.Size = new System.Drawing.Size(102, 48);
            this.btnServiços.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnServiços.TabIndex = 10;
            this.btnServiços.TabStop = false;
            this.btnServiços.Click += new System.EventHandler(this.btnServiços_Click);
            // 
            // btnPet
            // 
            this.btnPet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPet.Image = ((System.Drawing.Image)(resources.GetObject("btnPet.Image")));
            this.btnPet.Location = new System.Drawing.Point(281, 326);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(102, 48);
            this.btnPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPet.TabIndex = 9;
            this.btnPet.TabStop = false;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(152, 326);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(102, 48);
            this.btnCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCliente.TabIndex = 8;
            this.btnCliente.TabStop = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.Location = new System.Drawing.Point(553, 326);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(102, 48);
            this.btnFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFuncionario.TabIndex = 7;
            this.btnFuncionario.TabStop = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // brnAtendimento
            // 
            this.brnAtendimento.BackColor = System.Drawing.SystemColors.Control;
            this.brnAtendimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brnAtendimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("brnAtendimento.Image")));
            this.brnAtendimento.Location = new System.Drawing.Point(23, 326);
            this.brnAtendimento.Name = "brnAtendimento";
            this.brnAtendimento.Size = new System.Drawing.Size(102, 48);
            this.brnAtendimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brnAtendimento.TabIndex = 6;
            this.brnAtendimento.TabStop = false;
            this.brnAtendimento.Click += new System.EventHandler(this.brnAtendimento_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechar.Location = new System.Drawing.Point(660, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(14, 13);
            this.lblFechar.TabIndex = 13;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::PetShop.Properties.Resources.image_petshop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 386);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.btnServiços);
            this.Controls.Add(this.btnPet);
            this.Controls.Add(this.brnAtendimento);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnServiços)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnAtendimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnServiços;
        private System.Windows.Forms.PictureBox btnPet;
        private System.Windows.Forms.PictureBox btnCliente;
        private System.Windows.Forms.PictureBox btnFuncionario;
        private System.Windows.Forms.PictureBox brnAtendimento;
        private System.Windows.Forms.Label lblFechar;
    }
}

