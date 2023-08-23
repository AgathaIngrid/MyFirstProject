using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirtstProject
{
    public static class Program
    {
        public static void Main(string[] args) {



            Filme asBranquelas = new Filme()
            {
                Adult = false,
                Id = 123456,
                Title = "As Branquelas",
                Overwiu = "Dois amigos pretos policiais, que se infiltram na sociality, se passando por irmas gemeas loiras",
                Vote_avarange = 10.2f,
                Vote_count = 1,
                Poster_path = "",
                //Genre_ids = [01];
            };

            Filme titanic = new Filme()
            {
                Adult = true,
                Id = 1,
                Title = "Titanic",
                Overwiu = " Uma mulher da alta sociedade se apaixona por um tripulante pobre, e vivem uma romance impossivel.",
                Vote_avarange = 10.5f,
                Vote_count = 2,
                Poster_path = "",
            };

            Filme moana = new Filme()
            {
                Adult = false,
                Id = 678910,
                Title = "Moana",
                Overwiu = "Uma princesa que se junta com um semi deus, para salvar o mundo",
                Vote_avarange = 0.2f,
                Vote_count = 2,
                Poster_path = "",
                // Genre_ids = [02];
            };
            Filme avatar = new Filme()
            {
                Adult = false,
                Id = 670,
                Title = "Avatar",
                Overwiu = "Um mundo utopico que os humanos descobrem, e destroem esse mundo dos seres utopicos",
                Vote_avarange = 11.2f,
                Vote_count = 5,
                Poster_path = "",
                // Genre_ids = [02];
            };


            Serie belAir = new Serie()
            {
            first_air_date = 0,
            Title = "Bel Air",
            Overwiu = "Um re-make de um maluco no pedaço",
            Vote_averange = 10.0f,
            Vote_count = 1,
            Poster_path = string.Empty,
            // Genre_ids = 01;

        };
            Serie anne = new Serie()
            {
                first_air_date = 10,
                Title = "Anne with E",
                Overwiu = "Uma orfã que foi adota por um casal de irmaos idosos",
                Vote_averange = 20.0f,
                Vote_count = 2,
                Poster_path = string.Empty,
                // Genre_ids = 01;

            };
            Console.WriteLine("Lista de Filmes");
            Console.WriteLine(asBranquelas.Title);
            Console.WriteLine(titanic.Title);
            Console.WriteLine(moana.Title);
            Console.WriteLine("Lista de Series");
            Console.WriteLine(belAir.Title);
            Console.WriteLine(anne.Title);
            Console.ReadLine();

        }

            
    }
}
