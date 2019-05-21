using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTesting
{
    public interface IDownloader
    {
        string Filename { get; set; }
        Task DownloadAsync(Uri filePath, string filename = null);
    }
}
