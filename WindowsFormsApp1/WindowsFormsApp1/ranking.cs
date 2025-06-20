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
    public partial class ranking : Form
    {   Usuario usuarioLogado;
        private List<RankingFoto> rankingFotos = new List<RankingFoto>();
        private int indiceRankingAtual = 0;
        public ranking(Usuario usuario)
        
        {   
            usuarioLogado = usuario;
            InitializeComponent();
            this.MaximizeBox = false;
        }
        
        
        private void CarregarRanking()
        {
            FotosRepository fotosRepo = new FotosRepository(DbUtil.ConnectionString);

            rankingFotos = fotosRepo.Ranking();

            if (rankingFotos.Count == 0)
            {
                MessageBox.Show("Nenhuma foto no ranking ainda!");
                return;
            }

            indiceRankingAtual = 0;
            MostrarFotoDoRankingAtual();
        }

    
        private void ranking_Load(object sender, EventArgs e)
        {
            CarregarRanking();
                    
    }
        private void MostrarFotoDoRankingAtual()
        {
            FotosRepository fotosRepo = new FotosRepository(DbUtil.ConnectionString);

            int idFoto = rankingFotos[indiceRankingAtual].IdFoto; //lista
            string nomeFoto = fotosRepo.ObterNomePorIdFoto(idFoto);

            if (nomeFoto != null)
            {
                var imagem = fotosRepo.ObterImagemPorNome(nomeFoto);
                if (imagem != null)
                {
                    pictureBox1.Image = imagem;
                    label1.Text = $"TOP {indiceRankingAtual + 1}: {rankingFotos[indiceRankingAtual].TotalCurtidas} curtidas!";
                }
            }
            int idFoto2 = rankingFotos[indiceRankingAtual + 1].IdFoto; //lista
            string nomeFoto2 = fotosRepo.ObterNomePorIdFoto(idFoto2);

            if (nomeFoto2 != null)
            {
                var imagem2 = fotosRepo.ObterImagemPorNome(nomeFoto2);
                if (imagem2 != null)
                {
                    pictureBox2.Image = imagem2;
                    label2.Text = $"TOP {indiceRankingAtual + 2}: {rankingFotos[indiceRankingAtual + 1].TotalCurtidas} curtidas!";
                }
            }
            int idFoto3 = rankingFotos[indiceRankingAtual + 2].IdFoto; //lista
            string nomeFoto3 = fotosRepo.ObterNomePorIdFoto(idFoto3);

            if (nomeFoto3 != null)
            {
                var imagem = fotosRepo.ObterImagemPorNome(nomeFoto3);
                if (imagem != null)
                {
                    pictureBox3.Image = imagem;
                    label3.Text = $"TOP {indiceRankingAtual + 3}: {rankingFotos[indiceRankingAtual + 2].TotalCurtidas} curtidas!";
                }
            }
        }
    }
}
