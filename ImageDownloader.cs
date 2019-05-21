using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace projTesting
{
    public class ImageDownloader : IDownloader
    {
        private WebClient _client = new WebClient();

        public string Filename { get; set; }

        public Task DownloadAsync(Uri filePath, string filename = null)
        {
            Filename = filename == null ? Path.GetFileName(filePath.AbsolutePath) : filename;
            return _client.DownloadFileTaskAsync(filePath, Path.GetFileName(Filename));
        }
    }
}
