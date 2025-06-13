using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void introducao_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {


        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void registro_Click(object sender, EventArgs e)
        {
            Form2 signIn = new Form2();
            signIn.ShowDialog();
        }

        private void logar_Click(object sender, EventArgs e)
        {

            string email = emailtext.Text;
            string senha = HashUtil.GerarHashSha256(senhatext.Text);

            // Gera o hash da senha
           
            

            UsuarioRepository repo = new UsuarioRepository(DbUtil.ConnectionString);
            Usuario usuario = repo.ObterPorEmailESenha(email,senha);

            if (usuario != null && usuario.Username != null)
            {
                MainForm main = new MainForm();
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas.");
            }


        }
    }
}