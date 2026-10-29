namespace Academia
{
    partial class Administração_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administração_2));
            this.botão_excluir = new System.Windows.Forms.Button();
            this.botão_atualizar = new System.Windows.Forms.Button();
            this.título_consultar = new System.Windows.Forms.Label();
            this.Grid_consultar = new System.Windows.Forms.DataGridView();
            this.botão_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_consultar)).BeginInit();
            this.SuspendLayout();
            // 
            // botão_excluir
            // 
            this.botão_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botão_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.botão_excluir.Location = new System.Drawing.Point(321, 577);
            this.botão_excluir.Name = "botão_excluir";
            this.botão_excluir.Size = new System.Drawing.Size(254, 58);
            this.botão_excluir.TabIndex = 7;
            this.botão_excluir.Text = "Excluir";
            this.botão_excluir.UseVisualStyleBackColor = false;
            this.botão_excluir.Click += new System.EventHandler(this.botão_excluir_Click);
            // 
            // botão_atualizar
            // 
            this.botão_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botão_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botão_atualizar.Location = new System.Drawing.Point(49, 577);
            this.botão_atualizar.Name = "botão_atualizar";
            this.botão_atualizar.Size = new System.Drawing.Size(254, 58);
            this.botão_atualizar.TabIndex = 6;
            this.botão_atualizar.Text = "Atualizar";
            this.botão_atualizar.UseVisualStyleBackColor = false;
            this.botão_atualizar.Click += new System.EventHandler(this.botão_atualizar_Click);
            // 
            // título_consultar
            // 
            this.título_consultar.AutoSize = true;
            this.título_consultar.BackColor = System.Drawing.Color.Transparent;
            this.título_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.título_consultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.título_consultar.Location = new System.Drawing.Point(314, 39);
            this.título_consultar.Name = "título_consultar";
            this.título_consultar.Size = new System.Drawing.Size(468, 37);
            this.título_consultar.TabIndex = 5;
            this.título_consultar.Text = "Consultar Alunos e Professores";
            // 
            // Grid_consultar
            // 
            this.Grid_consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_consultar.Location = new System.Drawing.Point(56, 118);
            this.Grid_consultar.Name = "Grid_consultar";
            this.Grid_consultar.Size = new System.Drawing.Size(976, 419);
            this.Grid_consultar.TabIndex = 4;
            this.Grid_consultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_consultar_CellContentClick);
            // 
            // botão_voltar
            // 
            this.botão_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botão_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botão_voltar.Location = new System.Drawing.Point(802, 577);
            this.botão_voltar.Name = "botão_voltar";
            this.botão_voltar.Size = new System.Drawing.Size(254, 58);
            this.botão_voltar.TabIndex = 8;
            this.botão_voltar.Text = "Voltar";
            this.botão_voltar.UseVisualStyleBackColor = false;
            this.botão_voltar.Click += new System.EventHandler(this.botão_voltar_Click);
            // 
            // Administração_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 691);
            this.Controls.Add(this.botão_voltar);
            this.Controls.Add(this.botão_excluir);
            this.Controls.Add(this.botão_atualizar);
            this.Controls.Add(this.título_consultar);
            this.Controls.Add(this.Grid_consultar);
            this.MaximumSize = new System.Drawing.Size(1095, 730);
            this.MinimumSize = new System.Drawing.Size(1095, 730);
            this.Name = "Administração_2";
            this.Text = "Administração_2";
            this.Load += new System.EventHandler(this.Adminstração_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_consultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botão_excluir;
        private System.Windows.Forms.Button botão_atualizar;
        private System.Windows.Forms.Label título_consultar;
        private System.Windows.Forms.DataGridView Grid_consultar;
        private System.Windows.Forms.Button botão_voltar;
    }
}