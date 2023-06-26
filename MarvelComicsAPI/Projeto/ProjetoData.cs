namespace MarvelComicsAPI.Projeto;

public record ProjetoData()
{
    public int Offset { get; set; }
    public int Limit { get; set; }
    public int Total { get; set; }
    public int Count { get; set; }
    public List<ProjetoDataResult> Results { get; set; }
}