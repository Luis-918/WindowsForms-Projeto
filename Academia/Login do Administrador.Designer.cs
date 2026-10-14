namespace Academia
{
    partial class Login_do_Administrador
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
            this.caixa_código = new System.Windows.Forms.TextBox();
            this.label_código = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.botão_confirmar = new System.Windows.Forms.Button();
            this.botão_voltar = new System.Windows.Forms.Button();
            this.titulo_administrador = new System.Windows.Forms.Label();
            this.esqueci_senha = new System.Windows.Forms.Label();
            this.label_setor = new System.Windows.Forms.Label();
            this.caixa_setor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // caixa_código
            // 
            this.caixa_código.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_código.Location = new System.Drawing.Point(280, 120);
            this.caixa_código.Name = "caixa_código";
            this.caixa_código.Size = new System.Drawing.Size(408, 23);
            this.caixa_código.TabIndex = 0;
            this.caixa_código.TextChanged += new System.EventHandler(this.caixa_código_TextChanged);
            // 
            // label_código
            // 
            this.label_código.AutoSize = true;
            this.label_código.Font = new System.Drawing.Font("Arial", 13.25F);
            this.label_código.Location = new System.Drawing.Point(91, 121);
            this.label_código.Name = "label_código";
            this.label_código.Size = new System.Drawing.Size(183, 21);
            this.label_código.TabIndex = 2;
            this.label_código.Text = "Cód. de Identificação:";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Arial", 13.25F);
            this.label_senha.Location = new System.Drawing.Point(207, 180);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(67, 21);
            this.label_senha.TabIndex = 3;
            this.label_senha.Text = "Senha:";
            // 
            // caixa_senha
            // 
            this.caixa_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_senha.Location = new System.Drawing.Point(280, 178);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(408, 23);
            this.caixa_senha.TabIndex = 4;
            this.caixa_senha.TextChanged += new System.EventHandler(this.caixa_senha_TextChanged);
            // 
            // botão_confirmar
            // 
            this.botão_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botão_confirmar.Location = new System.Drawing.Point(121, 314);
            this.botão_confirmar.Name = "botão_confirmar";
            this.botão_confirmar.Size = new System.Drawing.Size(260, 59);
            this.botão_confirmar.TabIndex = 5;
            this.botão_confirmar.Text = "Confirmar";
            this.botão_confirmar.UseVisualStyleBackColor = true;
            this.botão_confirmar.Click += new System.EventHandler(this.botão_confirmar_Click);
            // 
            // botão_voltar
            // 
            this.botão_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botão_voltar.Location = new System.Drawing.Point(499, 314);
            this.botão_voltar.Name = "botão_voltar";
            this.botão_voltar.Size = new System.Drawing.Size(260, 59);
            this.botão_voltar.TabIndex = 6;
            this.botão_voltar.Text = "Voltar";
            this.botão_voltar.UseVisualStyleBackColor = true;
            this.botão_voltar.Click += new System.EventHandler(this.botão_voltar_Click);
            // 
            // titulo_administrador
            // 
            this.titulo_administrador.AutoSize = true;
            this.titulo_administrador.Font = new System.Drawing.Font("Malgun Gothic", 26.25F);
            this.titulo_administrador.Location = new System.Drawing.Point(194, 19);
            this.titulo_administrador.Name = "titulo_administrador";
            this.titulo_administrador.Size = new System.Drawing.Size(527, 47);
            this.titulo_administrador.TabIndex = 7;
            this.titulo_administrador.Text = "Tela de Login do Administrador";
            // 
            // esqueci_senha
            // 
            this.esqueci_senha.AutoSize = true;
            this.esqueci_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esqueci_senha.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.esqueci_senha.Location = new System.Drawing.Point(374, 218);
            this.esqueci_senha.Name = "esqueci_senha";
            this.esqueci_senha.Size = new System.Drawing.Size(196, 24);
            this.esqueci_senha.TabIndex = 8;
            this.esqueci_senha.Text = "Esqueci minha Senha";
            this.esqueci_senha.Click += new System.EventHandler(this.esqueci_senha_Click);
            // 
            // label_setor
            // 
            this.label_setor.AutoSize = true;
            this.label_setor.Font = new System.Drawing.Font("Arial", 13.25F);
            this.label_setor.Location = new System.Drawing.Point(216, 149);
            this.label_setor.Name = "label_setor";
            this.label_setor.Size = new System.Drawing.Size(58, 21);
            this.label_setor.TabIndex = 12;
            this.label_setor.Text = "Setor:";
            // 
            // caixa_setor
            // 
            this.caixa_setor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_setor.Location = new System.Drawing.Point(280, 149);
            this.caixa_setor.Name = "caixa_setor";
            this.caixa_setor.Size = new System.Drawing.Size(408, 23);
            this.caixa_setor.TabIndex = 11;
            this.caixa_setor.TextChanged += new System.EventHandler(this.caixa_setor_TextChanged);
            // 
            // Login_do_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 463);
            this.Controls.Add(this.label_setor);
            this.Controls.Add(this.caixa_setor);
            this.Controls.Add(this.esqueci_senha);
            this.Controls.Add(this.titulo_administrador);
            this.Controls.Add(this.botão_voltar);
            this.Controls.Add(this.botão_confirmar);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_código);
            this.Controls.Add(this.caixa_código);
            this.MaximumSize = new System.Drawing.Size(888, 502);
            this.MinimumSize = new System.Drawing.Size(888, 502);
            this.Name = "Login_do_Administrador";
            this.Text = "Login_do_Administrador";
            this.Load += new System.EventHandler(this.Login_do_Administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caixa_código;
        private System.Windows.Forms.Label label_código;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.TextBox caixa_senha;
        private System.Windows.Forms.Button botão_confirmar;
        private System.Windows.Forms.Button botão_voltar;
        private System.Windows.Forms.Label titulo_administrador;
        private System.Windows.Forms.Label esqueci_senha;
        private System.Windows.Forms.Label label_setor;
        private System.Windows.Forms.TextBox caixa_setor;
    }
}