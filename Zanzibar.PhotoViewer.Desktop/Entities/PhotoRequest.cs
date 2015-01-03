using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zanzibar.PhotoViewer.Desktop.Entities
{
    [Route("/api/Photo")]
    public class PhotoRequest : IReturn<List<Photo>>
    {
    }
}
