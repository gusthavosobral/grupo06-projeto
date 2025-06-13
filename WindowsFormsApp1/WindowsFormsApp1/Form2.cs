using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string email = textEmail.Text.Trim();
            string senha = textSenha.Text;
            string confirmarSenha = textConfirmarSenha.Text;
            string username = textusername.Text.Trim();
            
            mensagemlabel.ForeColor = Color.Black;
            mensagemlabel.BackColor = Color.LightYellow;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username)||
                string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmarSenha))
            {
                mensagemlabel.Text = "Preencha todos os campos.";
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                mensagemlabel.Text = "Email inválido.";
                return;
            }

            if (senha.Length < 6)
            {
                mensagemlabel.Text = "A senha deve ter pelo menos 6 caracteres.";
                return;
            }

          
            if (senha != confirmarSenha)
            {
                mensagemlabel.Text = "As senhas não coincidem.";
                return;
            }

            

            UsuarioRepository repo = new UsuarioRepository(DbUtil.ConnectionString);
            Usuario novoUsuario = new Usuario
            {

                Poder = "básico",
                Email = email,
                Username = username,
                Senha = HashUtil.GerarHashSha256(senha),
            };





            repo.DarPoderPorId(1, "admin");

            try
            {
                int linhas = repo.InserirUsuario(novoUsuario);
                if (linhas > 0)
                {
                    mensagemlabel.ForeColor = Color.Green;
                    mensagemlabel.Text = "Usuário cadastrado com sucesso!";
                    LimparCampos();
                }
                else
                {
                    mensagemlabel.Text = "Erro ao cadastrar.";
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                if (ex.Number == 1062)
                    mensagemlabel.Text = "Já existe um usuário com este e-mail.";
            }
            catch (Exception ex)
            {
                mensagemlabel.Text = "Erro inesperado: " + ex.Message;
            }

            this.Close();
        }

       

        private void LimparCampos()
        {
            textEmail.Text = "";
            textusername.Text = "";
            textSenha.Text = "";
            textConfirmarSenha.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
