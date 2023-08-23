using System;

public class RespostaAPI
{


	public int page;
	public list results;
	public list total_pages;
	public int total_results;


	public void Main()
	{
		Filmes Filme01 = new Filme();
			Filme01.page = 1;
        Console.WriteLine(Filme01.asBranquelas);
    }
}
