﻿namespace Projeto_Livraria
{
    partial class Form6
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
            this.buttonRetornar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.maskedTextBoxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxGenero = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAutor = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTitulo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRetornar
            // 
            this.buttonRetornar.BackColor = System.Drawing.Color.DimGray;
            this.buttonRetornar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRetornar.ForeColor = System.Drawing.Color.White;
            this.buttonRetornar.Location = new System.Drawing.Point(532, 329);
            this.buttonRetornar.Name = "buttonRetornar";
            this.buttonRetornar.Size = new System.Drawing.Size(175, 41);
            this.buttonRetornar.TabIndex = 51;
            this.buttonRetornar.Text = "Retornar";
            this.buttonRetornar.UseVisualStyleBackColor = false;
            this.buttonRetornar.Click += new System.EventHandler(this.buttonRetornar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.DimGray;
            this.buttonConsultar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConsultar.ForeColor = System.Drawing.Color.White;
            this.buttonConsultar.Location = new System.Drawing.Point(104, 329);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(155, 40);
            this.buttonConsultar.TabIndex = 50;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // maskedTextBoxQuantidade
            // 
            this.maskedTextBoxQuantidade.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxQuantidade.Location = new System.Drawing.Point(512, 256);
            this.maskedTextBoxQuantidade.Name = "maskedTextBoxQuantidade";
            this.maskedTextBoxQuantidade.Size = new System.Drawing.Size(218, 28);
            this.maskedTextBoxQuantidade.TabIndex = 47;
            this.maskedTextBoxQuantidade.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxQuantidade_MaskInputRejected);
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxValor.Location = new System.Drawing.Point(512, 201);
            this.maskedTextBoxValor.Mask = "9999.99";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(218, 28);
            this.maskedTextBoxValor.TabIndex = 46;
            this.maskedTextBoxValor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxValor_MaskInputRejected);
            // 
            // maskedTextBoxGenero
            // 
            this.maskedTextBoxGenero.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxGenero.Location = new System.Drawing.Point(512, 148);
            this.maskedTextBoxGenero.Name = "maskedTextBoxGenero";
            this.maskedTextBoxGenero.Size = new System.Drawing.Size(218, 28);
            this.maskedTextBoxGenero.TabIndex = 45;
            this.maskedTextBoxGenero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxGenero_MaskInputRejected);
            // 
            // maskedTextBoxAutor
            // 
            this.maskedTextBoxAutor.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxAutor.Location = new System.Drawing.Point(170, 256);
            this.maskedTextBoxAutor.Name = "maskedTextBoxAutor";
            this.maskedTextBoxAutor.Size = new System.Drawing.Size(218, 28);
            this.maskedTextBoxAutor.TabIndex = 44;
            this.maskedTextBoxAutor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxAutor_MaskInputRejected);
            // 
            // maskedTextBoxTitulo
            // 
            this.maskedTextBoxTitulo.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxTitulo.Location = new System.Drawing.Point(170, 201);
            this.maskedTextBoxTitulo.Name = "maskedTextBoxTitulo";
            this.maskedTextBoxTitulo.Size = new System.Drawing.Size(218, 28);
            this.maskedTextBoxTitulo.TabIndex = 43;
            this.maskedTextBoxTitulo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxTitulo_MaskInputRejected);
            // 
            // maskedTextBoxCodigo
            // 
            this.maskedTextBoxCodigo.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxCodigo.Location = new System.Drawing.Point(170, 151);
            this.maskedTextBoxCodigo.Name = "maskedTextBoxCodigo";
            this.maskedTextBoxCodigo.Size = new System.Drawing.Size(218, 28);
            this.maskedTextBoxCodigo.TabIndex = 42;
            this.maskedTextBoxCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCodigo_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(410, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(410, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(410, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Gênero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(101, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(101, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(101, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.DimGray;
            this.buttonCancelar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(307, 329);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(171, 40);
            this.buttonCancelar.TabIndex = 86;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(229, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(339, 25);
            this.label7.TabIndex = 91;
            this.label7.Text = "* ACESSO ADMINISTRADOR *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(203, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 27);
            this.label8.TabIndex = 90;
            this.label8.Text = "----- LIVRARIA ACADEMY -----";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRetornar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.maskedTextBoxQuantidade);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.maskedTextBoxGenero);
            this.Controls.Add(this.maskedTextBoxAutor);
            this.Controls.Add(this.maskedTextBoxTitulo);
            this.Controls.Add(this.maskedTextBoxCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetornar;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGenero;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAutor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTitulo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}