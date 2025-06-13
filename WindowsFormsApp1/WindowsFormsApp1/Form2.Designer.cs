namespace WindowsFormsApp1
{
    partial class Form2
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
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.mensagemlabel = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(12, 37);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(176, 20);
            this.textEmail.TabIndex = 1;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(12, 108);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(100, 20);
            this.textSenha.TabIndex = 2;
            // 
            // textConfirmarSenha
            // 
            this.textConfirmarSenha.Location = new System.Drawing.Point(12, 182);
            this.textConfirmarSenha.Name = "textConfirmarSenha";
            this.textConfirmarSenha.Size = new System.Drawing.Size(100, 20);
            this.textConfirmarSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(216, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Registrar-se";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttoncancelar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancelar.Location = new System.Drawing.Point(239, 12);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(75, 23);
            this.buttoncancelar.TabIndex = 9;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = false;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // mensagemlabel
            // 
            this.mensagemlabel.AutoSize = true;
            this.mensagemlabel.BackColor = System.Drawing.Color.Transparent;
            this.mensagemlabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagemlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mensagemlabel.Location = new System.Drawing.Point(12, 296);
            this.mensagemlabel.Name = "mensagemlabel";
            this.mensagemlabel.Size = new System.Drawing.Size(0, 20);
            this.mensagemlabel.TabIndex = 10;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(18, 252);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(100, 20);
            this.textusername.TabIndex = 11;
            this.textusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Username";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.vanessastockard2;
            this.ClientSize = new System.Drawing.Size(326, 333);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.mensagemlabel);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textConfirmarSenha);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "registro";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.Label mensagemlabel;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Label label4;
    }
}