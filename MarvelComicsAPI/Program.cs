using System.Security.Cryptography;
using System.Text;
using MarvelComicsAPI.Projeto;
using Newtonsoft.Json;

GetApi();

const string urlApiToken = "http://gateway.marvel.com/v1/public/comics";
        
/*
 * <summary>
 * ts - a timestamp (or other long string which can change on a request-by-request basis)
 * hash - um hash MD5 composto pelos parâmetros 'ts', 'chave privada' e 'chave publica'. Ex: tsprivateKeypublicKey (https://www.md5hashgenerator.com/)
 * </summary>
 */
static object? GetApi()
{
    // TODO: Extrair os dados sensíveis para um local mais seguro (arquivo appconfig.json, variáveis de ambiente ou até um AWS Secrets Manager)
    const int ts = 1;
    const string publicApikey = "a47c903225ca26ff9099931c9cc9b66a";
    const string privateApikey = "9e348f38d6ae6122c7fd46ea6f62e5942abac705";
    var urlApi = $"{urlApiToken}?ts={1}&apikey={publicApikey}&hash={ConvertToMd5Hash($"{ts}{privateApikey}{publicApikey}")}";
    if (urlApi == null) throw new ArgumentNullException(nameof(urlApi));

    var retornoStringApi = ChamadaApis(HttpMethod.Get, urlApi);
    var objRetorno = JsonConvert.DeserializeObject<Project>(retornoStringApi);

    return objRetorno;
}

static string ChamadaApis(HttpMethod tipoHttpMethod, string api)
{
    var retorno = string.Empty;

    using var client = new HttpClient();
    using var request = new HttpRequestMessage(tipoHttpMethod, api);
    client.Timeout = new TimeSpan(0, 0, 100);

    var response = client.SendAsync(request).Result;
    if (response.IsSuccessStatusCode)
    {
        retorno = response.Content.ReadAsStringAsync().Result;
    }

    return retorno;
}

static string ConvertToMd5Hash(string input)
{
    var data = MD5.HashData(Encoding.UTF8.GetBytes(input));

    var sBuilder = new StringBuilder();

    foreach (var t in data)
    {
        sBuilder.Append(t.ToString("x2"));
    }

    return sBuilder.ToString();
}