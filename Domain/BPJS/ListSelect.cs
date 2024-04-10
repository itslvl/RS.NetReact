using Newtonsoft.Json;

namespace DotNet.RS.Models.BPJS
{
    public class ListSelect
    {
        [JsonProperty("kode")] public string Kode { get; set; }
        [JsonProperty("nama")] public string Nama { get; set; }
    }
}
