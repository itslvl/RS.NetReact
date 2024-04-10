namespace DotNet.RS.Models.ViewModels
{
    public class ERMItem
    {
        public int Id { get; set; }
        public string Kelompok { get; set; } = string.Empty;
        public string Uraian { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string Controller { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
    }
}
