
using Microsoft.AspNetCore.Hosting;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Portfolio.Helpers.File
{
    public class FileHelper : IFileHelper
    {
        IWebHostEnvironment _webHostEnvironment;


        public FileHelper(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;

        }
        public string SaveImage(IFormFile File, string folderName, string OldImageName = null)
        {

            string FinalName;
            if (File != null)
            {
                List<string> allowedExtensions = new List<string> {
                            ".pdf", ". doc", ".docx"
                };




                var rootPath = Path.Combine(_webHostEnvironment.WebRootPath, folderName);
                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }
                FileInfo fileInfo = new FileInfo(File.FileName);
                // /$!
                // new.jpg / new (1).jpg
                var newName = Guid.NewGuid().ToString() + fileInfo.Extension;
                if (allowedExtensions.Contains(fileInfo.Extension.ToString()))
                {

                    var fullPath = Path.Combine(rootPath, newName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))

                    {
                        File.CopyTo(stream);
                    }

                    FinalName = $"/{folderName}/{newName}";
                }

                else
                {
                    FinalName = "Error";
                }

            }
            else
            {
                return OldImageName;
            }
            return FinalName;
        }
        public string SaveDoc(IFormFile File, string folderName, string OldImageName = null)
        {

            string FinalName;
            if (File != null)
            {
                List<string> allowedExtensions = new List<string> {
                            ".png", ". jpeg", ".jpg", ".gif"
                };




                var rootPath = Path.Combine(_webHostEnvironment.WebRootPath, folderName);
                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }
                FileInfo fileInfo = new FileInfo(File.FileName);
                // /$!
                // new.jpg / new (1).jpg
                var newName = Guid.NewGuid().ToString() + fileInfo.Extension;
                if (allowedExtensions.Contains(fileInfo.Extension.ToString()))
                {

                    var fullPath = Path.Combine(rootPath, newName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))

                    {
                        File.CopyTo(stream);
                    }

                    FinalName = $"/{folderName}/{newName}";
                }

                else
                {
                    FinalName = "Error";
                }

            }
            else
            {
                return OldImageName;
            }
            return FinalName;
        }
    }
}
