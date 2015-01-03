using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zanzibar.PhotoViewer.Desktop.Entities
{
    public class Photo
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FileName { get; set; }
        public string ImageType { get; set; }
        public string Base64Image { get; set; }
        public byte[] RawImage { get; set; }
    }
}