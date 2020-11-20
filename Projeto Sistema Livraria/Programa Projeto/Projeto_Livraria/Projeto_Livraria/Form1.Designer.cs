namespace Projeto_Livraria
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
            this.buttonAcessarAdministrador = new System.Windows.Forms.Button();
            this.buttonAcessarCliente = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAcessarAdministrador
            // 
            this.buttonAcessarAdministrador.BackColor = System.Drawing.Color.DimGray;
            this.buttonAcessarAdministrador.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcessarAdministrador.ForeColor = System.Drawing.Color.White;
            this.buttonAcessarAdministrador.Location = new System.Drawing.Point(279, 181);
            this.buttonAcessarAdministrador.Name = "buttonAcessarAdministrador";
            this.buttonAcessarAdministrador.Size = new System.Drawing.Size(239, 48);
            this.buttonAcessarAdministrador.TabIndex = 0;
            this.buttonAcessarAdministrador.Text = "Acessar Administrador";
            this.buttonAcessarAdministrador.UseVisualStyleBackColor = false;
            this.buttonAcessarAdministrador.Click += new System.EventHandler(this.buttonAcessarAdministrador_Click);
            // 
            // buttonAcessarCliente
            // 
            this.buttonAcessarCliente.BackColor = System.Drawing.Color.DimGray;
            this.buttonAcessarCliente.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAcessarCliente.ForeColor = System.Drawing.Color.White;
            this.buttonAcessarCliente.Location = new System.Drawing.Point(279, 256);
            this.buttonAcessarCliente.Name = "buttonAcessarCliente";
            this.buttonAcessarCliente.Size = new System.Drawing.Size(239, 48);
            this.buttonAcessarCliente.TabIndex = 1;
            this.buttonAcessarCliente.Text = "Acessar Sistema Cliente";
            this.buttonAcessarCliente.UseVisualStyleBackColor = false;
            this.buttonAcessarCliente.Click += new System.EventHandler(this.buttonAcessarCliente_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.DimGray;
            this.buttonSair.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(279, 335);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(239, 48);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "----- LIVRARIA ACADEMY -----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(281, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "* ÁREA DE ACESSO *";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonAcessarCliente);
            this.Controls.Add(this.buttonAcessarAdministrador);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAcessarAdministrador;
        private System.Windows.Forms.Button buttonAcessarCliente;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

