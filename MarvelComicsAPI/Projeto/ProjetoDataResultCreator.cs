namespace MarvelComicsAPI.Projeto;

public record ProjetoDataResultCreator()
{
    public int Available { get; set; }
    public string CollectionURI { get; set; }
    public List<ProjetoDataResultItem> Itens { get; set; }
    public int Returned { get; set; }
}