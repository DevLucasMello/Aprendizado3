namespace Projeto_Livraria
{
    partial class Form9
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
            this.buttonLivrosVendidos = new System.Windows.Forms.Button();
            this.buttonLivrosReserva = new System.Windows.Forms.Button();
            this.buttonRetornar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLivrosVendidos
            // 
            this.buttonLivrosVendidos.BackColor = System.Drawing.Color.DimGray;
            this.buttonLivrosVendidos.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLivrosVendidos.ForeColor = System.Drawing.Color.White;
            this.buttonLivrosVendidos.Location = new System.Drawing.Point(245, 150);
            this.buttonLivrosVendidos.Name = "buttonLivrosVendidos";
            this.buttonLivrosVendidos.Size = new System.Drawing.Size(268, 48);
            this.buttonLivrosVendidos.TabIndex = 0;
            this.buttonLivrosVendidos.Text = "Relatório de Livros Vendidos";
            this.buttonLivrosVendidos.UseVisualStyleBackColor = false;
            this.buttonLivrosVendidos.Click += new System.EventHandler(this.buttonLivrosVendidos_Click);
            // 
            // buttonLivrosReserva
            // 
            this.buttonLivrosReserva.BackColor = System.Drawing.Color.DimGray;
            this.buttonLivrosReserva.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLivrosReserva.ForeColor = System.Drawing.Color.White;
            this.buttonLivrosReserva.Location = new System.Drawing.Point(245, 231);
            this.buttonLivrosReserva.Name = "buttonLivrosReserva";
            this.buttonLivrosReserva.Size = new System.Drawing.Size(268, 48);
            this.buttonLivrosReserva.TabIndex = 1;
            this.buttonLivrosReserva.Text = "Relatório de Livros em Reserva";
            this.buttonLivrosReserva.UseVisualStyleBackColor = false;
            this.buttonLivrosReserva.Click += new System.EventHandler(this.buttonLivrosReserva_Click);
            // 
            // buttonRetornar
            // 
            this.buttonRetornar.BackColor = System.Drawing.Color.DimGray;
            this.buttonRetornar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRetornar.ForeColor = System.Drawing.Color.White;
            this.buttonRetornar.Location = new System.Drawing.Point(245, 313);
            this.buttonRetornar.Name = "buttonRetornar";
            this.buttonRetornar.Size = new System.Drawing.Size(268, 48);
            this.buttonRetornar.TabIndex = 2;
            this.buttonRetornar.Text = "Retornar";
            this.buttonRetornar.UseVisualStyleBackColor = false;
            this.buttonRetornar.Click += new System.EventHandler(this.buttonRetornar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(212, 62);
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
            this.label8.Location = new System.Drawing.Point(186, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 27);
            this.label8.TabIndex = 96;
            this.label8.Text = "----- LIVRARIA ACADEMY -----";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonRetornar);
            this.Controls.Add(this.buttonLivrosReserva);
            this.Controls.Add(this.buttonLivrosVendidos);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLivrosVendidos;
        private System.Windows.Forms.Button buttonLivrosReserva;
        private System.Windows.Forms.Button buttonRetornar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}