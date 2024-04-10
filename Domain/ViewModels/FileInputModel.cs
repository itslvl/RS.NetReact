using Microsoft.AspNetCore.Http;

namespace DotNet.RS.Models.ViewModels
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
