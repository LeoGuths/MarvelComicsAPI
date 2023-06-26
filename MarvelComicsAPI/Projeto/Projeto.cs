namespace MarvelComicsAPI.Projeto;

public record Project()
{
    public int Code { get; set; }
    public string Status { get; set; }
    public string Copyright { get; set; }       
    public string AttributionText { get; set; }       
    public string AttributionHTML { get; set; }       
    public string Etag { get; set; }       
    public ProjetoData Data { get; set; }       
}