using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace myFirtstProject
{
    public static class Program
    {
        public static List<Filme> InicializadorFilme()
        {
            Filme asBranquelas = new Filme()
            {

                Adult = false,
                Id = 123456,
                Title = "As Branquelas",
                Overwiu = "Dois amigos pretos policiais, que se infiltram na sociality, se passando por irmas gemeas loiras",
                Vote_avarange = 10.2f,
                Vote_count = 10,
                Poster_path = "",
                Genre_ids = null,

            };

            Filme titanic = new Filme()
            {
                Adult = true,
                Id = 1,
                Title = "Titanic",
                Overwiu = " Uma mulher da alta sociedade se apaixona por um tripulante pobre, e vivem uma romance impossivel.",
                Vote_avarange = 10.5f,
                Vote_count = 7,
                Poster_path = "",
                Genre_ids = null,
            };

            Filme moana = new Filme()
            {
                Adult = false,
                Id = 678910,
                Title = "Moana",
                Overwiu = "Uma princesa que se junta com um semi deus, para salvar o mundo",
                Vote_avarange = 0.2f,
                Vote_count = 6,
                Poster_path = "",
                Genre_ids = null,
            };
            Filme avatar = new Filme()
            {
                Adult = false,
                Id = 670,
                Title = "Avatar",
                Overwiu = "Um mundo utopico que os humanos descobrem, e destroem esse mundo dos seres utopicos",
                Vote_avarange = 11.2f,
                Vote_count = 3,
                Poster_path = "",
                Genre_ids = null,
            };

            List<Filme> listaDeFilmes = new List<Filme>();
            listaDeFilmes.Add(asBranquelas);
            listaDeFilmes.Add(titanic);
            listaDeFilmes.Add(moana);
            listaDeFilmes.Add(avatar);
            return listaDeFilmes;
        }


        public static List<Serie> InicializadorSerie()
        {
            Serie belAir = new Serie()
            {
                first_air_date = 0,
                Title = "Bel Air",
                Overwiu = "Um re-make de um maluco no pedaço",
                Vote_averange = 10.0f,
                Vote_count = 1,
                Poster_path = string.Empty,
                Genre_ids = null,

            };
            Serie anne = new Serie()
            {
                first_air_date = 10,
                Title = "Anne with E",
                Overwiu = "Uma orfã que foi adota por um casal de irmaos idosos",
                Vote_averange = 20.0f,
                Vote_count = 2,
                Poster_path = string.Empty,
                Genre_ids = null,

            };
            List<Serie> listaDeSeries = new List<Serie>();
            listaDeSeries.Add(anne);
            listaDeSeries.Add(belAir);
            return listaDeSeries;
        }

        public static void Main(string[] args)
        {
            List<Filme> listaDeFilmes = InicializadorFilme();
            ExibirFilme(listaDeFilmes);

            List<Serie> listaDeSeries = InicializadorSerie();
            ExibirSerie(listaDeSeries);
            ExibirSerie(series: listaDeSeries);

            
           
            Console.ReadLine();

        }
        public static void ExibirSerie(List<Serie> series)
        {
            foreach (var serie in series)
            {
                Console.WriteLine(serie.Title);
            };
        }

        public static void ExibirFilme(List<Filme> filmes)
        {
            foreach (var filme in filmes)
            {
                Console.WriteLine(filme.Title);
                Classificacao(filme.Vote_avarange);
            };
        }
     
        public static void Classificacao(float notaFilme)
        {   
           
            if (notaFilme > 9)
                Console.WriteLine("Muito Bom");
            else if (notaFilme > 6)
                Console.WriteLine("Bom");
            else if (notaFilme < 6)
                Console.WriteLine("Ruim");
            else
                Console.WriteLine("Muito Ruim");



        }              

    }
}

