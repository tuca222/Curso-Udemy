using ExercicioPost.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand",
                "I'm going to visit this wonderful country!", 12); ;

            post1.AddComentario(new Comentario("Have a nice trip!"));
            post1.AddComentario(new Comentario("Wow, that's awesome!"));

            Post post2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", 
                "See you tomorrow", 5);

            post2.AddComentario(new Comentario("Good night"));
            post2.AddComentario(new Comentario("May the Force be with you"));

            Console.WriteLine(post1);
            Console.WriteLine(post2);

            Console.ReadLine();
        }
    }
}
