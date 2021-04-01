using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPost.Entidades
{
    class Post
    {
        public DateTime MomentoDoPost { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Post()
        {

        }

        public Post(DateTime momentoPost, string titulo, string legenda, int likes)
        {
            MomentoDoPost = momentoPost;
            Titulo = titulo;
            Conteudo = legenda;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoveComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(MomentoDoPost.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários: ");
            foreach(Comentario c in Comentarios)
            {
                sb.AppendLine(c.TextoComentario);
            }
            return sb.ToString();
        }
    }
}
