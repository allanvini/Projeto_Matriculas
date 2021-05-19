
namespace Projeto_Integrador.Views.Usuario.Paineis
{
    partial class Dashboard_Usuario
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
            this.btn_ver_matriculas = new System.Windows.Forms.Button();
            this.btn_matricular_aluno = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ver_matriculas
            // 
            this.btn_ver_matriculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ver_matriculas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ver_matriculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ver_matriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_matriculas.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_matriculas.Image = global::Projeto_Integrador.Properties.Resources.Alunos;
            this.btn_ver_matriculas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ver_matriculas.Location = new System.Drawing.Point(12, 76);
            this.btn_ver_matriculas.Name = "btn_ver_matriculas";
            this.btn_ver_matriculas.Size = new System.Drawing.Size(196, 55);
            this.btn_ver_matriculas.TabIndex = 0;
            this.btn_ver_matriculas.Text = "Ver minhas matriculas";
            this.btn_ver_matriculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver_matriculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ver_matriculas.UseVisualStyleBackColor = true;
            this.btn_ver_matriculas.Click += new System.EventHandler(this.btn_ver_matriculas_Click);
            // 
            // btn_matricular_aluno
            // 
            this.btn_matricular_aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_matricular_aluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_matricular_aluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_matricular_aluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_matricular_aluno.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matricular_aluno.Image = global::Projeto_Integrador.Properties.Resources.Novo_aluno;
            this.btn_matricular_aluno.Location = new System.Drawing.Point(214, 76);
            this.btn_matricular_aluno.Name = "btn_matricular_aluno";
            this.btn_matricular_aluno.Size = new System.Drawing.Size(196, 55);
            this.btn_matricular_aluno.TabIndex = 1;
            this.btn_matricular_aluno.Text = "Matricular aluno";
            this.btn_matricular_aluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_matricular_aluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_matricular_aluno.UseVisualStyleBackColor = true;
            this.btn_matricular_aluno.Click += new System.EventHandler(this.btn_matricular_aluno_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Image = global::Projeto_Integrador.Properties.Resources.Sair;
            this.btn_sair.Location = new System.Drawing.Point(12, 137);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(398, 55);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Dashboard_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 206);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_matricular_aluno);
            this.Controls.Add(this.btn_ver_matriculas);
            this.Name = "Dashboard_Usuario";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olá, usuário";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ver_matriculas;
        private System.Windows.Forms.Button btn_matricular_aluno;
        private System.Windows.Forms.Button btn_sair;
    }
}