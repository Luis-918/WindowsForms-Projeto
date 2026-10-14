namespace Academia
{
    partial class Login_do_Professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_do_Professor));
            this.titulo_professor = new System.Windows.Forms.Label();
            this.botão_voltar = new System.Windows.Forms.Button();
            this.botão_confirmar = new System.Windows.Forms.Button();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.label_senha = new System.Windows.Forms.Label();
            this.label_email_CPF = new System.Windows.Forms.Label();
            this.caixa_email_CPF = new System.Windows.Forms.TextBox();
            this.esqueci_senha = new System.Windows.Forms.Label();
            this.label_área = new System.Windows.Forms.Label();
            this.caixa_área = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lembrar_login = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo_professor
            // 
            this.titulo_professor.AutoSize = true;
            this.titulo_professor.BackColor = System.Drawing.Color.OrangeRed;
            this.titulo_professor.Font = new System.Drawing.Font("Malgun Gothic", 22.25F);
            this.titulo_professor.ForeColor = System.Drawing.Color.White;
            this.titulo_professor.Location = new System.Drawing.Point(25, 22);
            this.titulo_professor.Name = "titulo_professor";
            this.titulo_professor.Size = new System.Drawing.Size(387, 41);
            this.titulo_professor.TabIndex = 23;
            this.titulo_professor.Text = "Tela de Login do Professor";
            // 
            // botão_voltar
            // 
            this.botão_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botão_voltar.Location = new System.Drawing.Point(498, 359);
            this.botão_voltar.Name = "botão_voltar";
            this.botão_voltar.Size = new System.Drawing.Size(260, 59);
            this.botão_voltar.TabIndex = 22;
            this.botão_voltar.Text = "Voltar";
            this.botão_voltar.UseVisualStyleBackColor = true;
            this.botão_voltar.Click += new System.EventHandler(this.botão_voltar_Click);
            // 
            // botão_confirmar
            // 
            this.botão_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botão_confirmar.Location = new System.Drawing.Point(120, 359);
            this.botão_confirmar.Name = "botão_confirmar";
            this.botão_confirmar.Size = new System.Drawing.Size(260, 59);
            this.botão_confirmar.TabIndex = 21;
            this.botão_confirmar.Text = "Confirmar";
            this.botão_confirmar.UseVisualStyleBackColor = true;
            this.botão_confirmar.Click += new System.EventHandler(this.botão_confirmar_Click);
            // 
            // caixa_senha
            // 
            this.caixa_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_senha.Location = new System.Drawing.Point(235, 235);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(408, 23);
            this.caixa_senha.TabIndex = 20;
            this.caixa_senha.TextChanged += new System.EventHandler(this.caixa_senha_TextChanged);
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.BackColor = System.Drawing.Color.OrangeRed;
            this.label_senha.Font = new System.Drawing.Font("Arial", 13.25F);
            this.label_senha.ForeColor = System.Drawing.Color.White;
            this.label_senha.Location = new System.Drawing.Point(176, 211);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(67, 21);
            this.label_senha.TabIndex = 19;
            this.label_senha.Text = "Senha:";
            // 
            // label_email_CPF
            // 
            this.label_email_CPF.AutoSize = true;
            this.label_email_CPF.BackColor = System.Drawing.Color.OrangeRed;
            this.label_email_CPF.Font = new System.Drawing.Font("Arial", 13.25F);
            this.label_email_CPF.ForeColor = System.Drawing.Color.White;
            this.label_email_CPF.Location = new System.Drawing.Point(176, 94);
            this.label_email_CPF.Name = "label_email_CPF";
            this.label_email_CPF.Size = new System.Drawing.Size(125, 21);
            this.label_email_CPF.TabIndex = 18;
            this.label_email_CPF.Text = "Email ou CPF:";
            // 
            // caixa_email_CPF
            // 
            this.caixa_email_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_email_CPF.Location = new System.Drawing.Point(235, 118);
            this.caixa_email_CPF.Name = "caixa_email_CPF";
            this.caixa_email_CPF.Size = new System.Drawing.Size(408, 23);
            this.caixa_email_CPF.TabIndex = 17;
            this.caixa_email_CPF.TextChanged += new System.EventHandler(this.caixa_email_CPF_TextChanged);
            // 
            // esqueci_senha
            // 
            this.esqueci_senha.AutoSize = true;
            this.esqueci_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esqueci_senha.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.esqueci_senha.Location = new System.Drawing.Point(343, 281);
            this.esqueci_senha.Name = "esqueci_senha";
            this.esqueci_senha.Size = new System.Drawing.Size(196, 24);
            this.esqueci_senha.TabIndex = 24;
            this.esqueci_senha.Text = "Esqueci minha Senha";
            // 
            // label_área
            // 
            this.label_área.AutoSize = true;
            this.label_área.BackColor = System.Drawing.Color.OrangeRed;
            this.label_área.Font = new System.Drawing.Font("Arial", 13.25F);
            this.label_área.ForeColor = System.Drawing.Color.White;
            this.label_área.Location = new System.Drawing.Point(176, 154);
            this.label_área.Name = "label_área";
            this.label_área.Size = new System.Drawing.Size(53, 21);
            this.label_área.TabIndex = 26;
            this.label_área.Text = "Área:";
            // 
            // caixa_área
            // 
            this.caixa_área.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.caixa_área.Location = new System.Drawing.Point(235, 178);
            this.caixa_área.Name = "caixa_área";
            this.caixa_área.Size = new System.Drawing.Size(408, 23);
            this.caixa_área.TabIndex = 25;
            this.caixa_área.TextChanged += new System.EventHandler(this.caixa_área_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 442);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lembrar_login
            // 
            this.lembrar_login.AutoSize = true;
            this.lembrar_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lembrar_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lembrar_login.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lembrar_login.Location = new System.Drawing.Point(387, 317);
            this.lembrar_login.Name = "lembrar_login";
            this.lembrar_login.Size = new System.Drawing.Size(110, 17);
            this.lembrar_login.TabIndex = 29;
            this.lembrar_login.Text = "Lembrar de Mim";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(366, 320);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Login_do_Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 463);
            this.Controls.Add(this.lembrar_login);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label_área);
            this.Controls.Add(this.caixa_área);
            this.Controls.Add(this.esqueci_senha);
            this.Controls.Add(this.titulo_professor);
            this.Controls.Add(this.botão_voltar);
            this.Controls.Add(this.botão_confirmar);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_email_CPF);
            this.Controls.Add(this.caixa_email_CPF);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(888, 502);
            this.MinimumSize = new System.Drawing.Size(888, 502);
            this.Name = "Login_do_Professor";
            this.Text = "Login_do_Professor";
            this.Load += new System.EventHandler(this.Login_do_Professor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titulo_professor;
        private System.Windows.Forms.Button botão_voltar;
        private System.Windows.Forms.Button botão_confirmar;
        private System.Windows.Forms.TextBox caixa_senha;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Label label_email_CPF;
        private System.Windows.Forms.TextBox caixa_email_CPF;
        private System.Windows.Forms.Label esqueci_senha;
        private System.Windows.Forms.Label label_área;
        private System.Windows.Forms.TextBox caixa_área;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lembrar_login;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}