namespace MarvelComicsAPI.Projeto;

public record ProjetoDataResult()
{
    public int Id { get; set; }
    public int DigitalId { get; set; }
    public string Title { get; set; }
    public int IssueNumber { get; set; }
    public string VariantDescription { get; set; }
    public string Description { get; set; }
    public string Modified { get; set; }
    public string Isbn { get; set; }
    public string Upc { get; set; }
    public string DiamondCode { get; set; }
    public string Ean { get; set; }
    public string Issn { get; set; }
    public string Format { get; set; }
    public int PageCount { get; set; }
    public List<object> TextObjects { get; set; }
    public string ResourceURI { get; set; }
    public List<ProjetoDataResultUrl> Urls { get; set; }
    public ProjetoDataResultSerie Series { get; set; }
    public List<ProjetoDataResultVariant> Variants { get; set; }
    public List<object> Collections { get; set; }
    public List<object> CollectedIssues { get; set; }
    public List<ProjetoDataResultDate> Dates { get; set; }
    public List<ProjetoDataResultPrice> Prices { get; set; }
    public ProjetoDataResultThumbnail Thumbnail { get; set; }
    public List<object> Images { get; set; }
    public ProjetoDataResultCreator Creator { get; set; }
    public ProjetoDataResultCharacter Characters { get; set; }
    public ProjetoDataResultStory Stories { get; set; }
    public ProjetoDataResultEvent Events { get; set; }
}