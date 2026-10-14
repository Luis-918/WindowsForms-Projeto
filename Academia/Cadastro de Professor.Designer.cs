namespace Academia
{
    partial class Cadastro_de_Professor
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
            this.caixa_nascimento_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.caixa_telefone_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.caixa_CPF_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.botão_voltar = new System.Windows.Forms.Button();
            this.botão_confirmar = new System.Windows.Forms.Button();
            this.especialidade_cadastro = new System.Windows.Forms.Label();
            this.sexo_cadastro = new System.Windows.Forms.Label();
            this.nascimento_cadastro = new System.Windows.Forms.Label();
            this.CREF_cadastro = new System.Windows.Forms.Label();
            this.telefone_cadastro = new System.Windows.Forms.Label();
            this.nome_cadastro = new System.Windows.Forms.Label();
            this.caixa_objetivo_cadastro = new System.Windows.Forms.TextBox();
            this.caixa_sexo_cadastro = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.Label();
            this.caixa_nome_cadastro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // caixa_nascimento_cadastro
            // 
            this.caixa_nascimento_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_nascimento_cadastro.Location = new System.Drawing.Point(259, 205);
            this.caixa_nascimento_cadastro.Mask = "00/00/0000";
            this.caixa_nascimento_cadastro.Name = "caixa_nascimento_cadastro";
            this.caixa_nascimento_cadastro.Size = new System.Drawing.Size(408, 23);
            this.caixa_nascimento_cadastro.TabIndex = 62;
            this.caixa_nascimento_cadastro.ValidatingType = typeof(System.DateTime);
            // 
            // caixa_telefone_cadastro
            // 
            this.caixa_telefone_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_telefone_cadastro.Location = new System.Drawing.Point(259, 145);
            this.caixa_telefone_cadastro.Mask = "(00) 00000-0000";
            this.caixa_telefone_cadastro.Name = "caixa_telefone_cadastro";
            this.caixa_telefone_cadastro.Size = new System.Drawing.Size(408, 23);
            this.caixa_telefone_cadastro.TabIndex = 59;
            // 
            // caixa_CPF_cadastro
            // 
            this.caixa_CPF_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_CPF_cadastro.Location = new System.Drawing.Point(259, 176);
            this.caixa_CPF_cadastro.Mask = "00000-A/AA";
            this.caixa_CPF_cadastro.Name = "caixa_CPF_cadastro";
            this.caixa_CPF_cadastro.Size = new System.Drawing.Size(408, 23);
            this.caixa_CPF_cadastro.TabIndex = 58;
            // 
            // botão_voltar
            // 
            this.botão_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botão_voltar.Location = new System.Drawing.Point(492, 366);
            this.botão_voltar.Name = "botão_voltar";
            this.botão_voltar.Size = new System.Drawing.Size(260, 59);
            this.botão_voltar.TabIndex = 57;
            this.botão_voltar.Text = "Voltar";
            this.botão_voltar.UseVisualStyleBackColor = true;
            this.botão_voltar.Click += new System.EventHandler(this.botão_voltar_Click);
            // 
            // botão_confirmar
            // 
            this.botão_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botão_confirmar.Location = new System.Drawing.Point(114, 366);
            this.botão_confirmar.Name = "botão_confirmar";
            this.botão_confirmar.Size = new System.Drawing.Size(260, 59);
            this.botão_confirmar.TabIndex = 56;
            this.botão_confirmar.Text = "Confirmar";
            this.botão_confirmar.UseVisualStyleBackColor = true;
            this.botão_confirmar.Click += new System.EventHandler(this.botão_confirmar_Click);
            // 
            // especialidade_cadastro
            // 
            this.especialidade_cadastro.AutoSize = true;
            this.especialidade_cadastro.Font = new System.Drawing.Font("Arial", 13.25F);
            this.especialidade_cadastro.Location = new System.Drawing.Point(126, 261);
            this.especialidade_cadastro.Name = "especialidade_cadastro";
            this.especialidade_cadastro.Size = new System.Drawing.Size(127, 21);
            this.especialidade_cadastro.TabIndex = 55;
            this.especialidade_cadastro.Text = "Especialidade:";
            // 
            // sexo_cadastro
            // 
            this.sexo_cadastro.AutoSize = true;
            this.sexo_cadastro.Font = new System.Drawing.Font("Arial", 13.25F);
            this.sexo_cadastro.Location = new System.Drawing.Point(198, 234);
            this.sexo_cadastro.Name = "sexo_cadastro";
            this.sexo_cadastro.Size = new System.Drawing.Size(55, 21);
            this.sexo_cadastro.TabIndex = 53;
            this.sexo_cadastro.Text = "Sexo:";
            // 
            // nascimento_cadastro
            // 
            this.nascimento_cadastro.AutoSize = true;
            this.nascimento_cadastro.Font = new System.Drawing.Font("Arial", 13.25F);
            this.nascimento_cadastro.Location = new System.Drawing.Point(124, 205);
            this.nascimento_cadastro.Name = "nascimento_cadastro";
            this.nascimento_cadastro.Size = new System.Drawing.Size(129, 21);
            this.nascimento_cadastro.TabIndex = 52;
            this.nascimento_cadastro.Text = "Data de Nasc.:";
            // 
            // CREF_cadastro
            // 
            this.CREF_cadastro.AutoSize = true;
            this.CREF_cadastro.Font = new System.Drawing.Font("Arial", 13.25F);
            this.CREF_cadastro.Location = new System.Drawing.Point(189, 176);
            this.CREF_cadastro.Name = "CREF_cadastro";
            this.CREF_cadastro.Size = new System.Drawing.Size(64, 21);
            this.CREF_cadastro.TabIndex = 51;
            this.CREF_cadastro.Text = "CREF:";
            // 
            // telefone_cadastro
            // 
            this.telefone_cadastro.AutoSize = true;
            this.telefone_cadastro.Font = new System.Drawing.Font("Arial", 13.25F);
            this.telefone_cadastro.Location = new System.Drawing.Point(169, 147);
            this.telefone_cadastro.Name = "telefone_cadastro";
            this.telefone_cadastro.Size = new System.Drawing.Size(84, 21);
            this.telefone_cadastro.TabIndex = 50;
            this.telefone_cadastro.Text = "Telefone:";
            // 
            // nome_cadastro
            // 
            this.nome_cadastro.AutoSize = true;
            this.nome_cadastro.Font = new System.Drawing.Font("Arial", 13.25F);
            this.nome_cadastro.Location = new System.Drawing.Point(191, 114);
            this.nome_cadastro.Name = "nome_cadastro";
            this.nome_cadastro.Size = new System.Drawing.Size(62, 21);
            this.nome_cadastro.TabIndex = 48;
            this.nome_cadastro.Text = "Nome:";
            // 
            // caixa_objetivo_cadastro
            // 
            this.caixa_objetivo_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_objetivo_cadastro.Location = new System.Drawing.Point(259, 261);
            this.caixa_objetivo_cadastro.Name = "caixa_objetivo_cadastro";
            this.caixa_objetivo_cadastro.Size = new System.Drawing.Size(408, 23);
            this.caixa_objetivo_cadastro.TabIndex = 47;
            // 
            // caixa_sexo_cadastro
            // 
            this.caixa_sexo_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_sexo_cadastro.Location = new System.Drawing.Point(259, 232);
            this.caixa_sexo_cadastro.Name = "caixa_sexo_cadastro";
            this.caixa_sexo_cadastro.Size = new System.Drawing.Size(408, 23);
            this.caixa_sexo_cadastro.TabIndex = 46;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Malgun Gothic", 26.25F);
            this.S.Location = new System.Drawing.Point(192, 9);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(500, 47);
            this.S.TabIndex = 45;
            this.S.Text = "Tela de Cadastro do Professor";
            // 
            // caixa_nome_cadastro
            // 
            this.caixa_nome_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_nome_cadastro.Location = new System.Drawing.Point(259, 112);
            this.caixa_nome_cadastro.Name = "caixa_nome_cadastro";
            this.caixa_nome_cadastro.Size = new System.Drawing.Size(408, 23);
            this.caixa_nome_cadastro.TabIndex = 44;
            // 
            // Cadastro_de_Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 463);
            this.Controls.Add(this.caixa_nascimento_cadastro);
            this.Controls.Add(this.caixa_telefone_cadastro);
            this.Controls.Add(this.caixa_CPF_cadastro);
            this.Controls.Add(this.botão_voltar);
            this.Controls.Add(this.botão_confirmar);
            this.Controls.Add(this.especialidade_cadastro);
            this.Controls.Add(this.sexo_cadastro);
            this.Controls.Add(this.nascimento_cadastro);
            this.Controls.Add(this.CREF_cadastro);
            this.Controls.Add(this.telefone_cadastro);
            this.Controls.Add(this.nome_cadastro);
            this.Controls.Add(this.caixa_objetivo_cadastro);
            this.Controls.Add(this.caixa_sexo_cadastro);
            this.Controls.Add(this.S);
            this.Controls.Add(this.caixa_nome_cadastro);
            this.MaximumSize = new System.Drawing.Size(888, 502);
            this.MinimumSize = new System.Drawing.Size(888, 502);
            this.Name = "Cadastro_de_Professor";
            this.Text = "Cadastro_de_Professor";
            this.Load += new System.EventHandler(this.Cadastro_de_Professor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox caixa_nascimento_cadastro;
        private System.Windows.Forms.MaskedTextBox caixa_telefone_cadastro;
        private System.Windows.Forms.MaskedTextBox caixa_CPF_cadastro;
        private System.Windows.Forms.Button botão_voltar;
        private System.Windows.Forms.Button botão_confirmar;
        private System.Windows.Forms.Label especialidade_cadastro;
        private System.Windows.Forms.Label sexo_cadastro;
        private System.Windows.Forms.Label nascimento_cadastro;
        private System.Windows.Forms.Label CREF_cadastro;
        private System.Windows.Forms.Label telefone_cadastro;
        private System.Windows.Forms.Label nome_cadastro;
        private System.Windows.Forms.TextBox caixa_objetivo_cadastro;
        private System.Windows.Forms.TextBox caixa_sexo_cadastro;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.TextBox caixa_nome_cadastro;
    }
}