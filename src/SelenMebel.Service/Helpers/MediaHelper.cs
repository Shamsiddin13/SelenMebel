using Microsoft.AspNetCore.Http;

namespace SelenMebel.Service.Helpers;

public class MediaHelper
{
    public static async Task<string> UploadFile(IFormFile file, string pathName)
    {
        string uniqueFileName = "";
        if (file != null && file.Length > 0)
        {
            string uploadsFolder = Path.Combine(WebHostEnviromentHelper.WebRootPath, pathName, "Images");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string imageFilePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(imageFilePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
        }

        return uniqueFileName;
    }
}
