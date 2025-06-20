using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        private Usuario usuarioLogado;
        private List<Fotos> fotos;
        private int indiceAtual = 0;
        public MainForm(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private bool liked = false;


        private void picliike_Click(object sender, EventArgs e)
        { }



        private void timerLike_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            indiceAtual = (indiceAtual - 1 + nomesFotos.Count) % nomesFotos.Count;
            CarregarFotoAtual();
        }

        private void picliike_Click_1(object sender, EventArgs e)
        {
           
       
            FotosRepository fotosRepo = new FotosRepository(DbUtil.ConnectionString);
            AvaliacaoRepository avaliacaoRepo = new AvaliacaoRepository(DbUtil.ConnectionString);

            int? idFoto = fotosRepo.ObterIdFotoPorNome(nomesFotos[indiceAtual]);

            if (idFoto == null) return;

            
            liked = !liked; //inverte aqui 

            if (liked)
            {
                picliike.Image = Properties.Resources.like_cheio;
            }
            else
            {
                picliike.Image = Properties.Resources.like_vazio;
            }

            // Atualiza o banco: Se já tiver avaliação, atualiza só a curtida. Se não tiver, faz insert.
            bool? curtidaNoBanco = avaliacaoRepo.ObterCurtidaPorUsuarioEFoto(usuarioLogado.Id, idFoto.Value);

            if (curtidaNoBanco == null)
            {
                // Não tem avaliação anterior -> INSERT
                Avaliacao novaAvaliacao = new Avaliacao()
                {
                    IdUsuario = usuarioLogado.Id,
                    IdFoto = idFoto.Value,
                    Comentario = null,
                    Curtida = liked
                };

                avaliacaoRepo.InserirComentario(novaAvaliacao);
            }
            else
            {
                // Já tinha avaliação -> UPDATE na curtida
                avaliacaoRepo.AtualizarCurtida(usuarioLogado.Id, idFoto.Value, liked);
            }
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
    

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            FotosRepository repo = new FotosRepository(DbUtil.ConnectionString);
            FotoPrincipal.Image = repo.ObterImagemPorNome("imagem1");
            indiceAtual = 0;
            this.Text = "As Frajolinhas de Realengo<3";
            CarregarFotoAtual();

        }
        
        private List<string> nomesFotos = new List<string>()
{
    "imagem1",
    "imagem2",
    "imagem3",
    "imagem4",
    "imagem5",
    "imagem6",
    "imagem7"
};
        private void CarregarFotoAtual()
        {
            FotosRepository fotosRepo = new FotosRepository(DbUtil.ConnectionString);
            AvaliacaoRepository avaliacaoRepo = new AvaliacaoRepository(DbUtil.ConnectionString);


            var imagem = fotosRepo.ObterImagemPorNome(nomesFotos[indiceAtual]);
            if (imagem != null)
                FotoPrincipal.Image = imagem;


            var desc = fotosRepo.ObterDescricaoPorNome(nomesFotos[indiceAtual]);
            descricao.Text = desc ?? "Descrição não disponível.";


            var idFoto = fotosRepo.ObterIdFotoPorNome(nomesFotos[indiceAtual]);
            if (idFoto != null)
            {
                bool? curtida = avaliacaoRepo.ObterCurtidaPorUsuarioEFoto(usuarioLogado.Id, idFoto.Value);

                if (curtida == true)
                {
                    picliike.Image = Properties.Resources.like_cheio;
                    liked = true;
                }
                else
                {
                    picliike.Image = Properties.Resources.like_vazio;
                    liked = false;
                }
            }
        }


        private void pular_Click(object sender, EventArgs e)
        {
            indiceAtual = (indiceAtual + 1) % nomesFotos.Count;
            CarregarFotoAtual();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            AvaliacaoRepository avaliacaoRepo = new AvaliacaoRepository(DbUtil.ConnectionString);
            FotosRepository fotosRepo = new FotosRepository(DbUtil.ConnectionString);

            var idFoto = fotosRepo.ObterIdFotoPorNome(nomesFotos[indiceAtual]);
            if (idFoto == null) return;

            Avaliacao novaAvaliacao = new Avaliacao()
            {
                IdUsuario = usuarioLogado.Id,
                IdFoto = idFoto.Value,
                Comentario = comentarios.Text,  
                Curtida = liked  
            };

            avaliacaoRepo.InserirComentario(novaAvaliacao);

            MessageBox.Show("Comentário enviado com sucesso!");
            comentarios.Clear();
        }
    }
    } 


