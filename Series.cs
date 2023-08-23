using System;

public class Series
{



    public int first_air_date;
    public string Title;
    public string Overwiu;
    public float Vote_averange;
    public int Vote_count;
    public string Poster_path;
    public int Genre_ids;

    public void BelAir()
	{
        first_air_date = 0;
        Title ="Bel Air";
        Overwiu = "Um re-make de um maluco no pedaço";
        Vote_averange = 10,0;
        Vote_count = 1;
        Poster_path = string.Empty;
        Genre_ids = 01;

	}
}
