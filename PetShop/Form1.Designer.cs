﻿namespace PetShop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnServiços)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnAtendimento)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnServiços
            // 
            this.btnServiços.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnServiços.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnServiços.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiços.Image = ((System.Drawing.Image)(resources.GetObject("btnServiços.Image")));
            this.btnServiços.Location = new System.Drawing.Point(529, 40);
            this.btnServiços.Name = "btnServiços";
            this.btnServiços.Size = new System.Drawing.Size(154, 69);
            this.btnServiços.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnServiços.TabIndex = 10;
            this.btnServiços.TabStop = false;
            // 
            // btnPet
            // 
            this.btnPet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPet.Image = ((System.Drawing.Image)(resources.GetObject("btnPet.Image")));
            this.btnPet.Location = new System.Drawing.Point(400, 40);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(123, 69);
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
            this.btnCliente.Location = new System.Drawing.Point(141, 40);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(123, 69);
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
            this.btnFuncionario.Location = new System.Drawing.Point(271, 40);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(123, 69);
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
            this.brnAtendimento.Location = new System.Drawing.Point(3, 40);
            this.brnAtendimento.Name = "brnAtendimento";
            this.brnAtendimento.Size = new System.Drawing.Size(132, 69);
            this.brnAtendimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brnAtendimento.TabIndex = 6;
            this.brnAtendimento.TabStop = false;
            this.brnAtendimento.Click += new System.EventHandler(this.brnAtendimento_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnServiços);
            this.panel1.Controls.Add(this.brnAtendimento);
            this.panel1.Controls.Add(this.btnFuncionario);
            this.panel1.Controls.Add(this.btnPet);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 114);
            this.panel1.TabIndex = 12;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechar.Location = new System.Drawing.Point(660, 3);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(14, 13);
            this.lblFechar.TabIndex = 13;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PETSHOP";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 115);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(683, 272);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(686, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnServiços)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnAtendimento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnServiços;
        private System.Windows.Forms.PictureBox btnPet;
        private System.Windows.Forms.PictureBox btnCliente;
        private System.Windows.Forms.PictureBox btnFuncionario;
        private System.Windows.Forms.PictureBox brnAtendimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblFechar;
    }
}

