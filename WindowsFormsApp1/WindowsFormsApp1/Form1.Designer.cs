namespace WindowsFormsApp1
{
    partial class Form1
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
            this.LOGIN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailtext = new System.Windows.Forms.RichTextBox();
            this.senhatext = new System.Windows.Forms.RichTextBox();
            this.introducao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logar = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.LOGIN.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(12, 95);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(61, 22);
            this.LOGIN.TabIndex = 0;
            this.LOGIN.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(84, 95);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(175, 22);
            this.emailtext.TabIndex = 3;
            this.emailtext.Text = "";
            this.emailtext.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // senhatext
            // 
            this.senhatext.Location = new System.Drawing.Point(84, 140);
            this.senhatext.Name = "senhatext";
            this.senhatext.Size = new System.Drawing.Size(175, 22);
            this.senhatext.TabIndex = 4;
            this.senhatext.Text = "";
            this.senhatext.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // introducao
            // 
            this.introducao.AutoSize = true;
            this.introducao.BackColor = System.Drawing.Color.Transparent;
            this.introducao.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introducao.ForeColor = System.Drawing.Color.Black;
            this.introducao.Location = new System.Drawing.Point(4, 29);
            this.introducao.Name = "introducao";
            this.introducao.Size = new System.Drawing.Size(237, 24);
            this.introducao.TabIndex = 5;
            this.introducao.Text = "Olá, seja bem-vindo! ";
            this.introducao.Click += new System.EventHandler(this.introducao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insira seu login para continuar, por favor! XoXo";
            // 
            // logar
            // 
            this.logar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.logar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logar.Location = new System.Drawing.Point(8, 181);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(251, 31);
            this.logar.TabIndex = 7;
            this.logar.Text = "DIVAR";
            this.logar.UseVisualStyleBackColor = false;
            this.logar.Click += new System.EventHandler(this.logar_Click);
            // 
            // registro
            // 
            this.registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.registro.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Location = new System.Drawing.Point(8, 218);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(98, 49);
            this.registro.TabIndex = 8;
            this.registro.Text = "registrar-se";
            this.registro.UseVisualStyleBackColor = false;
            this.registro.Click += new System.EventHandler(this.registro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.OIP__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 492);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.logar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.introducao);
            this.Controls.Add(this.senhatext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LOGIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "login :)";
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LOGIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox emailtext;
        private System.Windows.Forms.RichTextBox senhatext;
        private System.Windows.Forms.Label introducao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logar;
        private System.Windows.Forms.Button registro;
    }
}

