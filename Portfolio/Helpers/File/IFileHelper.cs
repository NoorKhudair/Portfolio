namespace Portfolio.Helpers.File
{
    public interface IFileHelper
    {
        string SaveImage(IFormFile File, string folderName, string OldImageName = null);
        string SaveDoc(IFormFile File, string folderName, string OldImageName = null);
        public void DeleteFile(string relativePath);
    }
}
