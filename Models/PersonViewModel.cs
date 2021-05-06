using Microsoft.AspNetCore.Http;

namespace FileUploadApp.Models
{
    public class PersonViewModel
    {
        public string Name { get; set; }
        public IFormFile Avatar { get; set; }
    }
}

