namespace Projeto_Livraria
{
    partial class Form13
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
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRetornar = new System.Windows.Forms.Button();
            this.maskedTextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPais = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxUF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCidade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxBairro = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNumero = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRua = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNome = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCPFouCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.Color.DimGray;
            this.buttonAtualizar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAtualizar.ForeColor = System.Drawing.Color.White;
            this.buttonAtualizar.Location = new System.Drawing.Point(41, 387);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(155, 40);
            this.buttonAtualizar.TabIndex = 149;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.DimGray;
            this.buttonCancelar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(410, 387);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(155, 40);
            this.buttonCancelar.TabIndex = 148;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonRetornar
            // 
            this.buttonRetornar.BackColor = System.Drawing.Color.DimGray;
            this.buttonRetornar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRetornar.ForeColor = System.Drawing.Color.White;
            this.buttonRetornar.Location = new System.Drawing.Point(590, 387);
            this.buttonRetornar.Name = "buttonRetornar";
            this.buttonRetornar.Size = new System.Drawing.Size(175, 41);
            this.buttonRetornar.TabIndex = 147;
            this.buttonRetornar.Text = "Retornar";
            this.buttonRetornar.UseVisualStyleBackColor = false;
            this.buttonRetornar.Click += new System.EventHandler(this.buttonRetornar_Click);
            // 
            // maskedTextBoxEmail
            // 
            this.maskedTextBoxEmail.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxEmail.Location = new System.Drawing.Point(475, 322);
            this.maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            this.maskedTextBoxEmail.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxEmail.TabIndex = 144;
            this.maskedTextBoxEmail.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxEmail_MaskInputRejected);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(475, 282);
            this.maskedTextBoxTelefone.Mask = "(99)9999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxTelefone.TabIndex = 143;
            this.maskedTextBoxTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxTelefone_MaskInputRejected);
            // 
            // maskedTextBoxPais
            // 
            this.maskedTextBoxPais.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxPais.Location = new System.Drawing.Point(475, 234);
            this.maskedTextBoxPais.Name = "maskedTextBoxPais";
            this.maskedTextBoxPais.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxPais.TabIndex = 142;
            this.maskedTextBoxPais.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPais_MaskInputRejected);
            // 
            // maskedTextBoxUF
            // 
            this.maskedTextBoxUF.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxUF.Location = new System.Drawing.Point(475, 196);
            this.maskedTextBoxUF.Name = "maskedTextBoxUF";
            this.maskedTextBoxUF.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxUF.TabIndex = 141;
            this.maskedTextBoxUF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxUF_MaskInputRejected);
            // 
            // maskedTextBoxCidade
            // 
            this.maskedTextBoxCidade.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxCidade.Location = new System.Drawing.Point(475, 154);
            this.maskedTextBoxCidade.Name = "maskedTextBoxCidade";
            this.maskedTextBoxCidade.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxCidade.TabIndex = 140;
            this.maskedTextBoxCidade.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCidade_MaskInputRejected);
            // 
            // maskedTextBoxBairro
            // 
            this.maskedTextBoxBairro.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxBairro.Location = new System.Drawing.Point(475, 115);
            this.maskedTextBoxBairro.Name = "maskedTextBoxBairro";
            this.maskedTextBoxBairro.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxBairro.TabIndex = 139;
            this.maskedTextBoxBairro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxBairro_MaskInputRejected);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(395, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 138;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(395, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 137;
            this.label11.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(395, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 136;
            this.label10.Text = "Pais";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(395, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 135;
            this.label9.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(395, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 134;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(395, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 133;
            this.label7.Text = "Bairro";
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(178, 319);
            this.maskedTextBoxCEP.Mask = "99999.999";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxCEP.TabIndex = 132;
            this.maskedTextBoxCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCEP_MaskInputRejected);
            // 
            // maskedTextBoxNumero
            // 
            this.maskedTextBoxNumero.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxNumero.Location = new System.Drawing.Point(178, 282);
            this.maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            this.maskedTextBoxNumero.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxNumero.TabIndex = 131;
            this.maskedTextBoxNumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxNumero_MaskInputRejected);
            // 
            // maskedTextBoxRua
            // 
            this.maskedTextBoxRua.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxRua.Location = new System.Drawing.Point(178, 239);
            this.maskedTextBoxRua.Name = "maskedTextBoxRua";
            this.maskedTextBoxRua.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxRua.TabIndex = 130;
            this.maskedTextBoxRua.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxRua_MaskInputRejected);
            // 
            // maskedTextBoxNome
            // 
            this.maskedTextBoxNome.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxNome.Location = new System.Drawing.Point(178, 199);
            this.maskedTextBoxNome.Name = "maskedTextBoxNome";
            this.maskedTextBoxNome.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxNome.TabIndex = 129;
            this.maskedTextBoxNome.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxNome_MaskInputRejected);
            // 
            // maskedTextBoxSenha
            // 
            this.maskedTextBoxSenha.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxSenha.Location = new System.Drawing.Point(178, 154);
            this.maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            this.maskedTextBoxSenha.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxSenha.TabIndex = 128;
            this.maskedTextBoxSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxSenha_MaskInputRejected);
            // 
            // maskedTextBoxCPFouCNPJ
            // 
            this.maskedTextBoxCPFouCNPJ.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxCPFouCNPJ.Location = new System.Drawing.Point(178, 115);
            this.maskedTextBoxCPFouCNPJ.Mask = "999.999.999-99";
            this.maskedTextBoxCPFouCNPJ.Name = "maskedTextBoxCPFouCNPJ";
            this.maskedTextBoxCPFouCNPJ.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBoxCPFouCNPJ.TabIndex = 127;
            this.maskedTextBoxCPFouCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCPFouCNPJ_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(109, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 126;
            this.label6.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(106, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 125;
            this.label5.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(106, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 124;
            this.label4.Text = "Rua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(106, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 123;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(106, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 122;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(106, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "CPF";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.DimGray;
            this.buttonConsultar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConsultar.ForeColor = System.Drawing.Color.White;
            this.buttonConsultar.Location = new System.Drawing.Point(223, 387);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(155, 40);
            this.buttonConsultar.TabIndex = 150;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Italic);
            this.label13.Location = new System.Drawing.Point(300, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 25);
            this.label13.TabIndex = 152;
            this.label13.Text = "* AREA CLIENTE *";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Italic);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(214, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(389, 27);
            this.label14.TabIndex = 151;
            this.label14.Text = "----- LIVRARIA ACADEMY -----";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRetornar);
            this.Controls.Add(this.maskedTextBoxEmail);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxPais);
            this.Controls.Add(this.maskedTextBoxUF);
            this.Controls.Add(this.maskedTextBoxCidade);
            this.Controls.Add(this.maskedTextBoxBairro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.maskedTextBoxNumero);
            this.Controls.Add(this.maskedTextBoxRua);
            this.Controls.Add(this.maskedTextBoxNome);
            this.Controls.Add(this.maskedTextBoxSenha);
            this.Controls.Add(this.maskedTextBoxCPFouCNPJ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form13";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form13_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRetornar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPais;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxUF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumero;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRua;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNome;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSenha;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPFouCNPJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}