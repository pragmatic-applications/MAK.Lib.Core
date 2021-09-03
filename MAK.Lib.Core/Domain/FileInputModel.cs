using Microsoft.AspNetCore.Http;

namespace Domain
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
