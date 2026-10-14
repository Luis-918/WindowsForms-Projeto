namespace Academia
{
    partial class tela_cadastro
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
            this.botão_professor = new System.Windows.Forms.Button();
            this.botão_aluno = new System.Windows.Forms.Button();
            this.titulo_pagina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botão_professor
            // 
            this.botão_professor.Font = new System.Drawing.Font("Monospac821 BT", 11.25F);
            this.botão_professor.Location = new System.Drawing.Point(288, 262);
            this.botão_professor.Name = "botão_professor";
            this.botão_professor.Size = new System.Drawing.Size(305, 90);
            this.botão_professor.TabIndex = 7;
            this.botão_professor.Text = "Cadastrar como Professor";
            this.botão_professor.UseVisualStyleBackColor = true;
            this.botão_professor.Click += new System.EventHandler(this.botão_professor_Click);
            // 
            // botão_aluno
            // 
            this.botão_aluno.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botão_aluno.Location = new System.Drawing.Point(288, 147);
            this.botão_aluno.Name = "botão_aluno";
            this.botão_aluno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botão_aluno.Size = new System.Drawing.Size(305, 90);
            this.botão_aluno.TabIndex = 6;
            this.botão_aluno.Text = "Cadastrar como Aluno";
            this.botão_aluno.UseVisualStyleBackColor = true;
            this.botão_aluno.Click += new System.EventHandler(this.botão_aluno_Click);
            // 
            // titulo_pagina
            // 
            this.titulo_pagina.AutoSize = true;
            this.titulo_pagina.Font = new System.Drawing.Font("Malgun Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_pagina.Location = new System.Drawing.Point(201, 34);
            this.titulo_pagina.Name = "titulo_pagina";
            this.titulo_pagina.Size = new System.Drawing.Size(432, 47);
            this.titulo_pagina.TabIndex = 5;
            this.titulo_pagina.Text = "Página Inicial de Cadastro";
            this.titulo_pagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tela_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 463);
            this.Controls.Add(this.botão_professor);
            this.Controls.Add(this.botão_aluno);
            this.Controls.Add(this.titulo_pagina);
            this.MaximumSize = new System.Drawing.Size(888, 502);
            this.MinimumSize = new System.Drawing.Size(888, 502);
            this.Name = "tela_cadastro";
            this.Text = "Página_de_Cadastro";
            this.Load += new System.EventHandler(this.tela_cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botão_professor;
        private System.Windows.Forms.Button botão_aluno;
        private System.Windows.Forms.Label titulo_pagina;
    }
}