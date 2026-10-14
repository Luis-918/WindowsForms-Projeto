namespace Academia
{
    partial class Login_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Aluno));
            this.S = new System.Windows.Forms.Label();
            this.botão_voltar = new System.Windows.Forms.Button();
            this.botão_confirmar = new System.Windows.Forms.Button();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.label_senha = new System.Windows.Forms.Label();
            this.label_email_CPF = new System.Windows.Forms.Label();
            this.caixa_email_CPF = new System.Windows.Forms.TextBox();
            this.esqueci_senha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lembrar_login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.BackColor = System.Drawing.Color.OrangeRed;
            this.S.Font = new System.Drawing.Font("Malgun Gothic", 22.25F);
            this.S.ForeColor = System.Drawing.Color.White;
            this.S.Location = new System.Drawing.Point(23, 20);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(229, 41);
            this.S.TabIndex = 15;
            this.S.Text = "Login do Aluno";
            // 
            // botão_voltar
            // 
            this.botão_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botão_voltar.Location = new System.Drawing.Point(520, 359);
            this.botão_voltar.Name = "botão_voltar";
            this.botão_voltar.Size = new System.Drawing.Size(260, 59);
            this.botão_voltar.TabIndex = 14;
            this.botão_voltar.Text = "Voltar";
            this.botão_voltar.UseVisualStyleBackColor = true;
            this.botão_voltar.Click += new System.EventHandler(this.botão_voltar_Click);
            // 
            // botão_confirmar
            // 
            this.botão_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botão_confirmar.Location = new System.Drawing.Point(142, 359);
            this.botão_confirmar.Name = "botão_confirmar";
            this.botão_confirmar.Size = new System.Drawing.Size(260, 59);
            this.botão_confirmar.TabIndex = 13;
            this.botão_confirmar.Text = "Confirmar";
            this.botão_confirmar.UseVisualStyleBackColor = true;
            this.botão_confirmar.Click += new System.EventHandler(this.botão_confirmar_Click);
            // 
            // caixa_senha
            // 
            this.caixa_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_senha.Location = new System.Drawing.Point(243, 194);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(408, 23);
            this.caixa_senha.TabIndex = 12;
            this.caixa_senha.TextChanged += new System.EventHandler(this.caixa_senha_TextChanged);
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.BackColor = System.Drawing.Color.OrangeRed;
            this.label_senha.Font = new System.Drawing.Font("Arial", 13.25F);
            this.label_senha.ForeColor = System.Drawing.Color.White;
            this.label_senha.Location = new System.Drawing.Point(189, 170);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(67, 21);
            this.label_senha.TabIndex = 11;
            this.label_senha.Text = "Senha:";
            // 
            // label_email_CPF
            // 
            this.label_email_CPF.AutoSize = true;
            this.label_email_CPF.BackColor = System.Drawing.Color.OrangeRed;
            this.label_email_CPF.Font = new System.Drawing.Font("Arial", 13.25F);
            this.label_email_CPF.ForeColor = System.Drawing.Color.White;
            this.label_email_CPF.Location = new System.Drawing.Point(189, 104);
            this.label_email_CPF.Name = "label_email_CPF";
            this.label_email_CPF.Size = new System.Drawing.Size(125, 21);
            this.label_email_CPF.TabIndex = 10;
            this.label_email_CPF.Text = "Email ou CPF:";
            // 
            // caixa_email_CPF
            // 
            this.caixa_email_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_email_CPF.Location = new System.Drawing.Point(243, 128);
            this.caixa_email_CPF.Name = "caixa_email_CPF";
            this.caixa_email_CPF.Size = new System.Drawing.Size(408, 23);
            this.caixa_email_CPF.TabIndex = 9;
            this.caixa_email_CPF.TextChanged += new System.EventHandler(this.caixa_email_CPF_TextChanged);
            // 
            // esqueci_senha
            // 
            this.esqueci_senha.AutoSize = true;
            this.esqueci_senha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.esqueci_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esqueci_senha.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.esqueci_senha.Location = new System.Drawing.Point(341, 241);
            this.esqueci_senha.Name = "esqueci_senha";
            this.esqueci_senha.Size = new System.Drawing.Size(196, 24);
            this.esqueci_senha.TabIndex = 16;
            this.esqueci_senha.Text = "Esqueci minha Senha";
            this.esqueci_senha.Click += new System.EventHandler(this.esqueci_senha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 442);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(374, 290);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lembrar_login
            // 
            this.lembrar_login.AutoSize = true;
            this.lembrar_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lembrar_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lembrar_login.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lembrar_login.Location = new System.Drawing.Point(395, 287);
            this.lembrar_login.Name = "lembrar_login";
            this.lembrar_login.Size = new System.Drawing.Size(110, 17);
            this.lembrar_login.TabIndex = 19;
            this.lembrar_login.Text = "Lembrar de Mim";
            // 
            // Login_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(872, 463);
            this.Controls.Add(this.lembrar_login);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.esqueci_senha);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.S);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.botão_voltar);
            this.Controls.Add(this.label_email_CPF);
            this.Controls.Add(this.botão_confirmar);
            this.Controls.Add(this.caixa_email_CPF);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(888, 502);
            this.MinimumSize = new System.Drawing.Size(888, 502);
            this.Name = "Login_Aluno";
            this.Text = "Login_do_Aluno";
            this.Load += new System.EventHandler(this.Login_do_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Button botão_voltar;
        private System.Windows.Forms.Button botão_confirmar;
        private System.Windows.Forms.TextBox caixa_senha;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Label label_email_CPF;
        private System.Windows.Forms.TextBox caixa_email_CPF;
        private System.Windows.Forms.Label esqueci_senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lembrar_login;
    }
}