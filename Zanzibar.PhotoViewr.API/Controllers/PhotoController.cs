using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zanzibar.PhotoViewr.API.Entities;

namespace Zanzibar.PhotoViewr.API.Controllers
{
    public class PhotoController : ApiController
    {

        [HttpGet]
        public List<Photo> GetAllPhotos()
        {

            var photoPath = System.Web.Hosting.HostingEnvironment.MapPath("~");
            //var photoPath = Directory.GetCurrentDirectory();

            DirectoryInfo info = new DirectoryInfo(photoPath + "..\\Photos");
            var result = new List<Photo>();
            if (info.Exists)
            {

                var files = info.GetFiles();
                int index = 1;
                foreach (var file in files)
                {
                    var photo = new Photo
                    {
                        ID = index++,
                        FileName = file.FullName,
                        CreatedDate = file.CreationTime,
                        ImageType = file.Extension,

                        RawImage = File.ReadAllBytes(file.FullName)
                    };
                    photo.Base64Image = Convert.ToBase64String(photo.RawImage);
                    
                    result.Add(photo);
                }
            }

            return result;
        }

    }
}
