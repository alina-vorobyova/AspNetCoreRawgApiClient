using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GamesSearchAsp.Areas.Admin.Helpers
{
    public class ImageLoader
    {
        public static async Task<string> DownloadFile(string url)
        {
            using (var client = new HttpClient())
            {

                using (var result = await client.GetAsync(url))
                {
                    if (result.IsSuccessStatusCode)
                    {
                        var bytes = await result.Content.ReadAsByteArrayAsync();
                        string extension = "";
                        if (result.Content.Headers.ContentType.MediaType == "image/jpeg")
                        {
                            extension = ".jpeg";
                        }
                        else if(result.Content.Headers.ContentType.MediaType == "image/jpg")
                        {
                            extension = ".jpg";
                        }
                        else if (result.Content.Headers.ContentType.MediaType == "image/png")
                        {
                            extension = ".png";
                        }
                        var imageName = $"{Guid.NewGuid()}{extension}";
                        var path = @$"wwwroot/uploads/{imageName}";
                        await System.IO.File.WriteAllBytesAsync(path, bytes);
                        return @$"/uploads/{imageName}";
                    }

                }
            }
            throw new Exception("Invalid link adress");
        }

    }

}


