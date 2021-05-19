
namespace Projeto_Integrador.Views.Instituicao.Paineis
{
    partial class Dashboard_Instituicao
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_listar_analises = new System.Windows.Forms.Button();
            this.btn_listar_disciplinas = new System.Windows.Forms.Button();
            this.btn_listar_alunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Image = global::Projeto_Integrador.Properties.Resources.Sair;
            this.btn_sair.Location = new System.Drawing.Point(12, 190);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(469, 51);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_listar_analises
            // 
            this.btn_listar_analises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listar_analises.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_listar_analises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_listar_analises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listar_analises.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar_analises.Image = global::Projeto_Integrador.Properties.Resources.Analise;
            this.btn_listar_analises.Location = new System.Drawing.Point(12, 133);
            this.btn_listar_analises.Name = "btn_listar_analises";
            this.btn_listar_analises.Size = new System.Drawing.Size(469, 51);
            this.btn_listar_analises.TabIndex = 2;
            this.btn_listar_analises.Text = "Ver matriculas pendentes de análise";
            this.btn_listar_analises.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_listar_analises.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_listar_analises.UseVisualStyleBackColor = true;
            this.btn_listar_analises.Click += new System.EventHandler(this.btn_listar_analises_Click);
            // 
            // btn_listar_disciplinas
            // 
            this.btn_listar_disciplinas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listar_disciplinas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_listar_disciplinas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_listar_disciplinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listar_disciplinas.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar_disciplinas.Image = global::Projeto_Integrador.Properties.Resources.Disciplinas;
            this.btn_listar_disciplinas.Location = new System.Drawing.Point(241, 76);
            this.btn_listar_disciplinas.Name = "btn_listar_disciplinas";
            this.btn_listar_disciplinas.Size = new System.Drawing.Size(240, 51);
            this.btn_listar_disciplinas.TabIndex = 1;
            this.btn_listar_disciplinas.Text = "Listar disciplinas cadastradas";
            this.btn_listar_disciplinas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_listar_disciplinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_listar_disciplinas.UseVisualStyleBackColor = true;
            this.btn_listar_disciplinas.Click += new System.EventHandler(this.btn_listar_disciplinas_Click);
            // 
            // btn_listar_alunos
            // 
            this.btn_listar_alunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listar_alunos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_listar_alunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_listar_alunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listar_alunos.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar_alunos.Image = global::Projeto_Integrador.Properties.Resources.Alunos;
            this.btn_listar_alunos.Location = new System.Drawing.Point(12, 76);
            this.btn_listar_alunos.Name = "btn_listar_alunos";
            this.btn_listar_alunos.Size = new System.Drawing.Size(223, 51);
            this.btn_listar_alunos.TabIndex = 0;
            this.btn_listar_alunos.Text = "Listar alunos matriculados";
            this.btn_listar_alunos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_listar_alunos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_listar_alunos.UseVisualStyleBackColor = true;
            this.btn_listar_alunos.Click += new System.EventHandler(this.btn_listar_alunos_Click);
            // 
            // Dashboard_Instituicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 254);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_listar_analises);
            this.Controls.Add(this.btn_listar_disciplinas);
            this.Controls.Add(this.btn_listar_alunos);
            this.MaximizeBox = false;
            this.Name = "Dashboard_Instituicao";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olá, Instituição";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_listar_alunos;
        private System.Windows.Forms.Button btn_listar_disciplinas;
        private System.Windows.Forms.Button btn_listar_analises;
        private System.Windows.Forms.Button btn_sair;
    }
}