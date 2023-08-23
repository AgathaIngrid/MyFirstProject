using System;

public class Filmes
{
	public bool Adult;
	public int Id;
	public string Title;
	public string Overwiu;
	public float Vote_avarange;
	public int Vote_count;
	public string Poster_path;
	public int[] Genre_ids;




    public void asBranquelas()
	{
	    Adult = false;
		Id = 123456;
		Title = "As Branquelas";
		Overwiu = "Dois amigos pretos policiais, que se infiltram na sociality, se passando por irmas gemeas loiras";
		Vote_avarange = 10,2;
		Vote_count = 1;
		Poster_patb = "";
		Genre_ids = 01;
	}

	public void moana()	{

        Adult = false;
        Id = 678910;
        Title = "Moana";
        Overwiu = "Uma princesa que se junta com um semi deus, para salvar o mundo";
        Vote_avarange = 0,2;
        Vote_count = 2;
        Poster_patb = "";
        Genre_ids = 02;
    }
}
