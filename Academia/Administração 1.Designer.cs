namespace Academia
{
    partial class Administração_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administração_1));
            this.título_cadastrar = new System.Windows.Forms.Label();
            this.botão_professor = new System.Windows.Forms.Button();
            this.botão_aluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // título_cadastrar
            // 
            this.título_cadastrar.AutoSize = true;
            this.título_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.título_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.título_cadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.título_cadastrar.Location = new System.Drawing.Point(310, 72);
            this.título_cadastrar.Name = "título_cadastrar";
            this.título_cadastrar.Size = new System.Drawing.Size(472, 37);
            this.título_cadastrar.TabIndex = 5;
            this.título_cadastrar.Text = "Cadastrar Alunos e Professores";
            // 
            // botão_professor
            // 
            this.botão_professor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botão_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.botão_professor.Location = new System.Drawing.Point(371, 365);
            this.botão_professor.Name = "botão_professor";
            this.botão_professor.Size = new System.Drawing.Size(345, 61);
            this.botão_professor.TabIndex = 4;
            this.botão_professor.Text = " Professor";
            this.botão_professor.UseVisualStyleBackColor = false;
            this.botão_professor.Click += new System.EventHandler(this.botão_professor_Click);
            // 
            // botão_aluno
            // 
            this.botão_aluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botão_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.botão_aluno.Location = new System.Drawing.Point(371, 262);
            this.botão_aluno.Name = "botão_aluno";
            this.botão_aluno.Size = new System.Drawing.Size(345, 57);
            this.botão_aluno.TabIndex = 3;
            this.botão_aluno.Text = " Aluno";
            this.botão_aluno.UseVisualStyleBackColor = false;
            this.botão_aluno.Click += new System.EventHandler(this.botão_aluno_Click);
            // 
            // Administração_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 691);
            this.Controls.Add(this.título_cadastrar);
            this.Controls.Add(this.botão_professor);
            this.Controls.Add(this.botão_aluno);
            this.MaximumSize = new System.Drawing.Size(1095, 730);
            this.MinimumSize = new System.Drawing.Size(1095, 730);
            this.Name = "Administração_1";
            this.Text = "Administração 1";
            this.Load += new System.EventHandler(this.Administração_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label título_cadastrar;
        private System.Windows.Forms.Button botão_professor;
        private System.Windows.Forms.Button botão_aluno;
    }
}