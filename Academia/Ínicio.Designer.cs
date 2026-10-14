namespace Academia
{
    partial class tela_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_login));
            this.titulo_pagina = new System.Windows.Forms.Label();
            this.botão_aluno = new System.Windows.Forms.Button();
            this.botão_professor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo_pagina
            // 
            this.titulo_pagina.AutoSize = true;
            this.titulo_pagina.BackColor = System.Drawing.Color.OrangeRed;
            this.titulo_pagina.Font = new System.Drawing.Font("Malgun Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_pagina.ForeColor = System.Drawing.Color.White;
            this.titulo_pagina.Location = new System.Drawing.Point(251, 18);
            this.titulo_pagina.Name = "titulo_pagina";
            this.titulo_pagina.Size = new System.Drawing.Size(381, 47);
            this.titulo_pagina.TabIndex = 0;
            this.titulo_pagina.Text = "Página Inicial de Login";
            this.titulo_pagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botão_aluno
            // 
            this.botão_aluno.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botão_aluno.Location = new System.Drawing.Point(314, 216);
            this.botão_aluno.Name = "botão_aluno";
            this.botão_aluno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botão_aluno.Size = new System.Drawing.Size(265, 70);
            this.botão_aluno.TabIndex = 3;
            this.botão_aluno.Text = "Login como Aluno";
            this.botão_aluno.UseVisualStyleBackColor = true;
            this.botão_aluno.Click += new System.EventHandler(this.botão_aluno_Click);
            // 
            // botão_professor
            // 
            this.botão_professor.Font = new System.Drawing.Font("Monospac821 BT", 11.25F);
            this.botão_professor.Location = new System.Drawing.Point(314, 316);
            this.botão_professor.Name = "botão_professor";
            this.botão_professor.Size = new System.Drawing.Size(265, 70);
            this.botão_professor.TabIndex = 4;
            this.botão_professor.Text = "Login como Professor";
            this.botão_professor.UseVisualStyleBackColor = true;
            this.botão_professor.Click += new System.EventHandler(this.botão_professor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 442);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 463);
            this.Controls.Add(this.botão_professor);
            this.Controls.Add(this.botão_aluno);
            this.Controls.Add(this.titulo_pagina);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(888, 502);
            this.MinimumSize = new System.Drawing.Size(888, 502);
            this.Name = "tela_login";
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.tela_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_pagina;
        private System.Windows.Forms.Button botão_aluno;
        private System.Windows.Forms.Button botão_professor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

