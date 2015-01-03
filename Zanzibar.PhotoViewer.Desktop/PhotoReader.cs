using ServiceStack;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zanzibar.PhotoViewer.Desktop.Entities;

namespace Zanzibar.PhotoViewer.Desktop
{
    public class PhotoReader
    {

        
        public List<Photo> GetAllPhotos()
        {
            var photoURL = ConfigurationSettings.AppSettings["PhotoURL"];
            var client = new JsonServiceClient(photoURL);
            var photo = client.Get(new PhotoRequest());
            return photo;
        }


        
    }
}
