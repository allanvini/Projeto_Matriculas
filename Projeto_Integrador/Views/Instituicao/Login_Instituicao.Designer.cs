
namespace Projeto_Integrador.Views.Instituicao
{
    partial class Login_Instituicao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cadastrar_instituicao = new System.Windows.Forms.Button();
            this.txb_login = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_senha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txb_senha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_login);
            this.groupBox1.Font = new System.Drawing.Font("Ubuntu Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(28, 180);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(288, 48);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Logar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(28, 234);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(288, 48);
            this.btn_voltar.TabIndex = 12;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 310);
            this.label4.MaximumSize = new System.Drawing.Size(120, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sua instituição não possui uma conta?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_cadastrar_instituicao
            // 
            this.btn_cadastrar_instituicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar_instituicao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cadastrar_instituicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cadastrar_instituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_instituicao.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_instituicao.Location = new System.Drawing.Point(142, 310);
            this.btn_cadastrar_instituicao.Name = "btn_cadastrar_instituicao";
            this.btn_cadastrar_instituicao.Size = new System.Drawing.Size(174, 32);
            this.btn_cadastrar_instituicao.TabIndex = 14;
            this.btn_cadastrar_instituicao.Text = "Cadastrar instituição";
            this.btn_cadastrar_instituicao.UseVisualStyleBackColor = true;
            this.btn_cadastrar_instituicao.Click += new System.EventHandler(this.btn_cadastrar_instituicao_Click);
            // 
            // txb_login
            // 
            this.txb_login.Depth = 0;
            this.txb_login.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_login.Hint = "";
            this.txb_login.Location = new System.Drawing.Point(55, 19);
            this.txb_login.MaxLength = 32767;
            this.txb_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_login.Name = "txb_login";
            this.txb_login.PasswordChar = '\0';
            this.txb_login.SelectedText = "";
            this.txb_login.SelectionLength = 0;
            this.txb_login.SelectionStart = 0;
            this.txb_login.Size = new System.Drawing.Size(207, 23);
            this.txb_login.TabIndex = 15;
            this.txb_login.TabStop = false;
            this.txb_login.UseSystemPasswordChar = false;
            // 
            // txb_senha
            // 
            this.txb_senha.Depth = 0;
            this.txb_senha.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_senha.Hint = "";
            this.txb_senha.Location = new System.Drawing.Point(55, 48);
            this.txb_senha.MaxLength = 32767;
            this.txb_senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.PasswordChar = '\0';
            this.txb_senha.SelectedText = "";
            this.txb_senha.SelectionLength = 0;
            this.txb_senha.SelectionStart = 0;
            this.txb_senha.Size = new System.Drawing.Size(207, 23);
            this.txb_senha.TabIndex = 16;
            this.txb_senha.TabStop = false;
            this.txb_senha.UseSystemPasswordChar = true;
            // 
            // Login_Instituicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 395);
            this.Controls.Add(this.btn_cadastrar_instituicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Login_Instituicao";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área da instituição";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cadastrar_instituicao;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_senha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_login;
    }
}