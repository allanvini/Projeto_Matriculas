
namespace Projeto_Integrador.Views.Usuario.Paineis
{
    partial class Matricular_Aluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_curso = new System.Windows.Forms.DataGridView();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgv_instituicao = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_finaliza_matricula = new System.Windows.Forms.Button();
            this.btn_cancela = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_instituicao = new System.Windows.Forms.Label();
            this.lbl_curso_valor = new System.Windows.Forms.Label();
            this.txb_nome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_idade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_telefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_endereco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_curso)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_instituicao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txb_endereco);
            this.groupBox1.Controls.Add(this.txb_telefone);
            this.groupBox1.Controls.Add(this.txb_email);
            this.groupBox1.Controls.Add(this.txb_idade);
            this.groupBox1.Controls.Add(this.txb_nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Ubuntu Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 174);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do aluno";
            // 
            // dtgv_curso
            // 
            this.dtgv_curso.AllowUserToAddRows = false;
            this.dtgv_curso.AllowUserToDeleteRows = false;
            this.dtgv_curso.AllowUserToOrderColumns = true;
            this.dtgv_curso.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_curso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_curso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_curso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.Nome1,
            this.Valor});
            this.dtgv_curso.Location = new System.Drawing.Point(6, 19);
            this.dtgv_curso.Name = "dtgv_curso";
            this.dtgv_curso.ReadOnly = true;
            this.dtgv_curso.Size = new System.Drawing.Size(318, 150);
            this.dtgv_curso.TabIndex = 12;
            this.dtgv_curso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_curso_CellClick);
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Width = 25;
            // 
            // Nome1
            // 
            this.Nome1.HeaderText = "Nome";
            this.Nome1.Name = "Nome1";
            this.Nome1.ReadOnly = true;
            this.Nome1.Width = 150;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dtgv_curso);
            this.groupBox2.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(504, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 188);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selação do curso";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dtgv_instituicao);
            this.groupBox3.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 188);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selação da instituição";
            // 
            // dtgv_instituicao
            // 
            this.dtgv_instituicao.AllowUserToAddRows = false;
            this.dtgv_instituicao.AllowUserToDeleteRows = false;
            this.dtgv_instituicao.AllowUserToOrderColumns = true;
            this.dtgv_instituicao.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_instituicao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_instituicao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgv_instituicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_instituicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Telefone,
            this.Email,
            this.Endereco});
            this.dtgv_instituicao.Location = new System.Drawing.Point(6, 19);
            this.dtgv_instituicao.Name = "dtgv_instituicao";
            this.dtgv_instituicao.ReadOnly = true;
            this.dtgv_instituicao.Size = new System.Drawing.Size(468, 150);
            this.dtgv_instituicao.TabIndex = 12;
            this.dtgv_instituicao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_instituicao_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            // 
            // btn_finaliza_matricula
            // 
            this.btn_finaliza_matricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finaliza_matricula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_finaliza_matricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_finaliza_matricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finaliza_matricula.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finaliza_matricula.Location = new System.Drawing.Point(504, 350);
            this.btn_finaliza_matricula.Name = "btn_finaliza_matricula";
            this.btn_finaliza_matricula.Size = new System.Drawing.Size(330, 44);
            this.btn_finaliza_matricula.TabIndex = 15;
            this.btn_finaliza_matricula.Text = "Finalizar matrícula";
            this.btn_finaliza_matricula.UseVisualStyleBackColor = true;
            this.btn_finaliza_matricula.Click += new System.EventHandler(this.btn_finaliza_matricula_Click);
            // 
            // btn_cancela
            // 
            this.btn_cancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancela.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancela.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancela.Location = new System.Drawing.Point(504, 400);
            this.btn_cancela.Name = "btn_cancela";
            this.btn_cancela.Size = new System.Drawing.Size(330, 44);
            this.btn_cancela.TabIndex = 16;
            this.btn_cancela.Text = "Cancelar";
            this.btn_cancela.UseVisualStyleBackColor = true;
            this.btn_cancela.Click += new System.EventHandler(this.btn_cancela_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Instituição selecionada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Curso selecionado:";
            // 
            // lbl_instituicao
            // 
            this.lbl_instituicao.AutoSize = true;
            this.lbl_instituicao.BackColor = System.Drawing.Color.White;
            this.lbl_instituicao.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instituicao.Location = new System.Drawing.Point(443, 270);
            this.lbl_instituicao.Name = "lbl_instituicao";
            this.lbl_instituicao.Size = new System.Drawing.Size(62, 16);
            this.lbl_instituicao.TabIndex = 19;
            this.lbl_instituicao.Text = "Instituição";
            // 
            // lbl_curso_valor
            // 
            this.lbl_curso_valor.AutoSize = true;
            this.lbl_curso_valor.BackColor = System.Drawing.Color.White;
            this.lbl_curso_valor.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curso_valor.Location = new System.Drawing.Point(443, 298);
            this.lbl_curso_valor.Name = "lbl_curso_valor";
            this.lbl_curso_valor.Size = new System.Drawing.Size(84, 16);
            this.lbl_curso_valor.TabIndex = 20;
            this.lbl_curso_valor.Text = "Curso: / valor: ";
            // 
            // txb_nome
            // 
            this.txb_nome.Depth = 0;
            this.txb_nome.Hint = "";
            this.txb_nome.Location = new System.Drawing.Point(81, 19);
            this.txb_nome.MaxLength = 32767;
            this.txb_nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.PasswordChar = '\0';
            this.txb_nome.SelectedText = "";
            this.txb_nome.SelectionLength = 0;
            this.txb_nome.SelectionStart = 0;
            this.txb_nome.Size = new System.Drawing.Size(176, 23);
            this.txb_nome.TabIndex = 10;
            this.txb_nome.TabStop = false;
            this.txb_nome.UseSystemPasswordChar = false;
            // 
            // txb_idade
            // 
            this.txb_idade.Depth = 0;
            this.txb_idade.Hint = "";
            this.txb_idade.Location = new System.Drawing.Point(81, 48);
            this.txb_idade.MaxLength = 32767;
            this.txb_idade.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_idade.Name = "txb_idade";
            this.txb_idade.PasswordChar = '\0';
            this.txb_idade.SelectedText = "";
            this.txb_idade.SelectionLength = 0;
            this.txb_idade.SelectionStart = 0;
            this.txb_idade.Size = new System.Drawing.Size(176, 23);
            this.txb_idade.TabIndex = 21;
            this.txb_idade.TabStop = false;
            this.txb_idade.UseSystemPasswordChar = false;
            // 
            // txb_email
            // 
            this.txb_email.Depth = 0;
            this.txb_email.Hint = "";
            this.txb_email.Location = new System.Drawing.Point(81, 78);
            this.txb_email.MaxLength = 32767;
            this.txb_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_email.Name = "txb_email";
            this.txb_email.PasswordChar = '\0';
            this.txb_email.SelectedText = "";
            this.txb_email.SelectionLength = 0;
            this.txb_email.SelectionStart = 0;
            this.txb_email.Size = new System.Drawing.Size(176, 23);
            this.txb_email.TabIndex = 22;
            this.txb_email.TabStop = false;
            this.txb_email.UseSystemPasswordChar = false;
            // 
            // txb_telefone
            // 
            this.txb_telefone.Depth = 0;
            this.txb_telefone.Hint = "";
            this.txb_telefone.Location = new System.Drawing.Point(81, 107);
            this.txb_telefone.MaxLength = 32767;
            this.txb_telefone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_telefone.Name = "txb_telefone";
            this.txb_telefone.PasswordChar = '\0';
            this.txb_telefone.SelectedText = "";
            this.txb_telefone.SelectionLength = 0;
            this.txb_telefone.SelectionStart = 0;
            this.txb_telefone.Size = new System.Drawing.Size(176, 23);
            this.txb_telefone.TabIndex = 23;
            this.txb_telefone.TabStop = false;
            this.txb_telefone.UseSystemPasswordChar = false;
            // 
            // txb_endereco
            // 
            this.txb_endereco.Depth = 0;
            this.txb_endereco.Hint = "";
            this.txb_endereco.Location = new System.Drawing.Point(81, 136);
            this.txb_endereco.MaxLength = 32767;
            this.txb_endereco.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_endereco.Name = "txb_endereco";
            this.txb_endereco.PasswordChar = '\0';
            this.txb_endereco.SelectedText = "";
            this.txb_endereco.SelectionLength = 0;
            this.txb_endereco.SelectionStart = 0;
            this.txb_endereco.Size = new System.Drawing.Size(176, 23);
            this.txb_endereco.TabIndex = 24;
            this.txb_endereco.TabStop = false;
            this.txb_endereco.UseSystemPasswordChar = false;
            // 
            // Matricular_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 455);
            this.Controls.Add(this.lbl_curso_valor);
            this.Controls.Add(this.lbl_instituicao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cancela);
            this.Controls.Add(this.btn_finaliza_matricula);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Matricular_Aluno";
            this.Text = "Matricular aluno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_curso)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_instituicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_curso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgv_instituicao;
        private System.Windows.Forms.Button btn_finaliza_matricula;
        private System.Windows.Forms.Button btn_cancela;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_instituicao;
        private System.Windows.Forms.Label lbl_curso_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_endereco;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_telefone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_email;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_idade;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_nome;
    }
}