namespace Academia
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Página_Cadastro = new System.Windows.Forms.Button();
            this.Página_Consultar = new System.Windows.Forms.Button();
            this.Página_Site = new System.Windows.Forms.Button();
            this.Página_Login_Aluno = new System.Windows.Forms.Button();
            this.Página_Login_Professor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Página_Cadastro
            // 
            this.Página_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Página_Cadastro.Location = new System.Drawing.Point(319, 218);
            this.Página_Cadastro.Name = "Página_Cadastro";
            this.Página_Cadastro.Size = new System.Drawing.Size(185, 75);
            this.Página_Cadastro.TabIndex = 0;
            this.Página_Cadastro.Text = "Página de Cadastro";
            this.Página_Cadastro.UseVisualStyleBackColor = true;
            this.Página_Cadastro.Click += new System.EventHandler(this.Página_Cadastro_Click);
            // 
            // Página_Consultar
            // 
            this.Página_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Página_Consultar.Location = new System.Drawing.Point(564, 218);
            this.Página_Consultar.Name = "Página_Consultar";
            this.Página_Consultar.Size = new System.Drawing.Size(185, 75);
            this.Página_Consultar.TabIndex = 1;
            this.Página_Consultar.Text = "Página de Consultar";
            this.Página_Consultar.UseVisualStyleBackColor = true;
            this.Página_Consultar.Click += new System.EventHandler(this.Página_Consultar_Click);
            // 
            // Página_Site
            // 
            this.Página_Site.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Página_Site.Location = new System.Drawing.Point(448, 453);
            this.Página_Site.Name = "Página_Site";
            this.Página_Site.Size = new System.Drawing.Size(185, 75);
            this.Página_Site.TabIndex = 2;
            this.Página_Site.Text = "Página do Site";
            this.Página_Site.UseVisualStyleBackColor = true;
            this.Página_Site.Click += new System.EventHandler(this.Página_Site_Click);
            // 
            // Página_Login_Aluno
            // 
            this.Página_Login_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Página_Login_Aluno.Location = new System.Drawing.Point(564, 329);
            this.Página_Login_Aluno.Name = "Página_Login_Aluno";
            this.Página_Login_Aluno.Size = new System.Drawing.Size(185, 75);
            this.Página_Login_Aluno.TabIndex = 3;
            this.Página_Login_Aluno.Text = "Página de Login do Aluno";
            this.Página_Login_Aluno.UseVisualStyleBackColor = true;
            this.Página_Login_Aluno.Click += new System.EventHandler(this.Página_Login_Aluno_Click);
            // 
            // Página_Login_Professor
            // 
            this.Página_Login_Professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Página_Login_Professor.Location = new System.Drawing.Point(319, 330);
            this.Página_Login_Professor.Name = "Página_Login_Professor";
            this.Página_Login_Professor.Size = new System.Drawing.Size(185, 75);
            this.Página_Login_Professor.TabIndex = 4;
            this.Página_Login_Professor.Text = "Página de Login do Professor";
            this.Página_Login_Professor.UseVisualStyleBackColor = true;
            this.Página_Login_Professor.Click += new System.EventHandler(this.Página_Login_Professor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu dos Administradores";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Página_Login_Professor);
            this.Controls.Add(this.Página_Login_Aluno);
            this.Controls.Add(this.Página_Site);
            this.Controls.Add(this.Página_Consultar);
            this.Controls.Add(this.Página_Cadastro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximumSize = new System.Drawing.Size(1095, 730);
            this.MinimumSize = new System.Drawing.Size(1095, 730);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Página_Cadastro;
        private System.Windows.Forms.Button Página_Consultar;
        private System.Windows.Forms.Button Página_Site;
        private System.Windows.Forms.Button Página_Login_Aluno;
        private System.Windows.Forms.Button Página_Login_Professor;
        private System.Windows.Forms.Label label1;
    }
}