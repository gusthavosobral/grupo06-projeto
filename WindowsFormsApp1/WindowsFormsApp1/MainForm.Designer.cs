namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.voltar = new System.Windows.Forms.Button();
            this.pular = new System.Windows.Forms.Button();
            this.picliike = new System.Windows.Forms.PictureBox();
            this.FotoPrincipal = new System.Windows.Forms.PictureBox();
            this.descricao = new System.Windows.Forms.Label();
            this.comentarios = new System.Windows.Forms.RichTextBox();
            this.enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picliike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(29, 32);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(179, 49);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "<<";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.button3_Click);
            // 
            // pular
            // 
            this.pular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pular.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pular.Location = new System.Drawing.Point(29, 108);
            this.pular.Name = "pular";
            this.pular.Size = new System.Drawing.Size(179, 49);
            this.pular.TabIndex = 2;
            this.pular.Text = ">>";
            this.pular.UseVisualStyleBackColor = false;
            this.pular.Click += new System.EventHandler(this.pular_Click);
            // 
            // picliike
            // 
            this.picliike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picliike.Image = global::WindowsFormsApp1.Properties.Resources.like_vazio;
            this.picliike.Location = new System.Drawing.Point(241, 66);
            this.picliike.Name = "picliike";
            this.picliike.Size = new System.Drawing.Size(61, 62);
            this.picliike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picliike.TabIndex = 3;
            this.picliike.TabStop = false;
            this.picliike.Click += new System.EventHandler(this.picliike_Click_1);
            // 
            // FotoPrincipal
            // 
            this.FotoPrincipal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FotoPrincipal.Location = new System.Drawing.Point(326, 12);
            this.FotoPrincipal.Name = "FotoPrincipal";
            this.FotoPrincipal.Size = new System.Drawing.Size(416, 379);
            this.FotoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPrincipal.TabIndex = 0;
            this.FotoPrincipal.TabStop = false;
            this.FotoPrincipal.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descricao.Font = new System.Drawing.Font("SimSun-ExtG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(322, 429);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(0, 19);
            this.descricao.TabIndex = 4;
            // 
            // comentarios
            // 
            this.comentarios.Location = new System.Drawing.Point(29, 166);
            this.comentarios.Name = "comentarios";
            this.comentarios.Size = new System.Drawing.Size(261, 104);
            this.comentarios.TabIndex = 5;
            this.comentarios.Text = "";
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.enviar.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.Location = new System.Drawing.Point(29, 276);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(111, 30);
            this.enviar.TabIndex = 6;
            this.enviar.Text = "enviar";
            this.enviar.UseVisualStyleBackColor = false;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(776, 506);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.comentarios);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.picliike);
            this.Controls.Add(this.pular);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.FotoPrincipal);
            this.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainForm";
            this.Text = "As Frajolinhas de Realengo<3";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picliike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picLike;
        private System.Windows.Forms.Timer timerLike;
        private System.Windows.Forms.PictureBox FotoPrincipal;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button pular;
        private System.Windows.Forms.PictureBox picliike;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.RichTextBox comentarios;
        private System.Windows.Forms.Button enviar;
    }
}