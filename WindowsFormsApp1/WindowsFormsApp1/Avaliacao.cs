using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Avaliacao
    {
      
        
            public int Id { get; set; }  // Novo campo de ID único
            public int IdUsuario { get; set; }
            public int IdFoto { get; set; }
            public string Comentario { get; set; }
            public bool Curtida { get; set; }
        


        public Avaliacao() { }

        public Avaliacao(int idUsuario, int idFoto, string comentario, bool curtida, int ID)
        {
            IdUsuario = idUsuario;
            IdFoto = idFoto;
            Comentario = comentario;
            Curtida = curtida;
            Id = Id;
        }
    }
}

