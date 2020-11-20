namespace Projeto_Livraria
{
    partial class Form10
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
            this.buttonConsultarConta = new System.Windows.Forms.Button();
            this.buttonAtualizarConta = new System.Windows.Forms.Button();
            this.buttonExcluirConta = new System.Windows.Forms.Button();
            this.buttonFazerCompra = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConsultarConta
            // 
            this.buttonConsultarConta.BackColor = System.Drawing.Color.DimGray;
            this.buttonConsultarConta.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConsultarConta.ForeColor = System.Drawing.Color.White;
            this.buttonConsultarConta.Location = new System.Drawing.Point(167, 253);
            this.buttonConsultarConta.Name = "buttonConsultarConta";
            this.buttonConsultarConta.Size = new System.Drawing.Size(167, 49);
            this.buttonConsultarConta.TabIndex = 1;
            this.buttonConsultarConta.Text = "Consultar Conta";
            this.buttonConsultarConta.UseVisualStyleBackColor = false;
            this.buttonConsultarConta.Click += new System.EventHandler(this.buttonConsultarConta_Click);
            // 
            // buttonAtualizarConta
            // 
            this.buttonAtualizarConta.BackColor = System.Drawing.Color.DimGray;
            this.buttonAtualizarConta.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAtualizarConta.ForeColor = System.Drawing.Color.White;
            this.buttonAtualizarConta.Location = new System.Drawing.Point(167, 128);
            this.buttonAtualizarConta.Name = "buttonAtualizarConta";
            this.buttonAtualizarConta.Size = new System.Drawing.Size(167, 49);
            this.buttonAtualizarConta.TabIndex = 2;
            this.buttonAtualizarConta.Text = "Atualizar Conta";
            this.buttonAtualizarConta.UseVisualStyleBackColor = false;
            this.buttonAtualizarConta.Click += new System.EventHandler(this.buttonAtualizarConta_Click);
            // 
            // buttonExcluirConta
            // 
            this.buttonExcluirConta.BackColor = System.Drawing.Color.DimGray;
            this.buttonExcluirConta.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonExcluirConta.ForeColor = System.Drawing.Color.White;
            this.buttonExcluirConta.Location = new System.Drawing.Point(428, 128);
            this.buttonExcluirConta.Name = "buttonExcluirConta";
            this.buttonExcluirConta.Size = new System.Drawing.Size(171, 49);
            this.buttonExcluirConta.TabIndex = 3;
            this.buttonExcluirConta.Text = "Excluir Conta";
            this.buttonExcluirConta.UseVisualStyleBackColor = false;
            this.buttonExcluirConta.Click += new System.EventHandler(this.buttonExcluirConta_Click);
            // 
            // buttonFazerCompra
            // 
            this.buttonFazerCompra.BackColor = System.Drawing.Color.DimGray;
            this.buttonFazerCompra.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFazerCompra.ForeColor = System.Drawing.Color.White;
            this.buttonFazerCompra.Location = new System.Drawing.Point(225, 348);
            this.buttonFazerCompra.Name = "buttonFazerCompra";
            this.buttonFazerCompra.Size = new System.Drawing.Size(312, 49);
            this.buttonFazerCompra.TabIndex = 4;
            this.buttonFazerCompra.Text = "Fazer Compra";
            this.buttonFazerCompra.UseVisualStyleBackColor = false;
            this.buttonFazerCompra.Click += new System.EventHandler(this.buttonFazerCompra_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.DimGray;
            this.buttonSair.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(428, 253);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(171, 49);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(218, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(339, 25);
            this.label7.TabIndex = 97;
            this.label7.Text = "* ACESSO ADMINISTRADOR *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(192, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 27);
            this.label8.TabIndex = 96;
            this.label8.Text = "----- LIVRARIA ACADEMY -----";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonFazerCompra);
            this.Controls.Add(this.buttonExcluirConta);
            this.Controls.Add(this.buttonAtualizarConta);
            this.Controls.Add(this.buttonConsultarConta);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConsultarConta;
        private System.Windows.Forms.Button buttonAtualizarConta;
        private System.Windows.Forms.Button buttonExcluirConta;
        private System.Windows.Forms.Button buttonFazerCompra;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}