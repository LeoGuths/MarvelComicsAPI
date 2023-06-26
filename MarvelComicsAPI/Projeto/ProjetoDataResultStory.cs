namespace MarvelComicsAPI.Projeto;

public record ProjetoDataResultStory()
{
    public int Available { get; set; }
    public string CollectionURI { get; set; }
    public List<ProjetoDataResultItem> Items { get; set; }
    public int Returned { get; set; }
}