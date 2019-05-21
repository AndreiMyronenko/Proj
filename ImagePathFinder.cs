using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FindImagesTest
{
    public class ImagePathFinder:IImagePathFinder
    {
        private readonly DirectoryInfo _startDirectory;
        public List<string> Result { get; set; } = new List<string>();

        public ImagePathFinder()
        {
            _startDirectory = DriveInfo.GetDrives()[0].RootDirectory;
        }

        public ImagePathFinder(DriveInfo drive)
        {
            _startDirectory = drive.RootDirectory;
        }

        public ImagePathFinder(string startPath)
        {
            if (Directory.Exists(startPath))
                _startDirectory = new DirectoryInfo(startPath);
        }

        private void Find(DirectoryInfo directory) 
        {
            try
            {
                ArrayList contains = new ArrayList();
                contains.AddRange(directory?.GetDirectories());
                contains.AddRange(directory?.GetFiles());

                foreach (var item in contains)
                {
                    if (item is DirectoryInfo dir)
                    {
                        Find(dir);
                    }
                    else if (item is FileInfo file)
                    {
                        if (file.Extension == ".png" || file.Extension == ".jpg" || file.Extension == ".jpeg")
                        {
                            Result.Add(file.FullName);
                        }
                    }
                }
            }
            catch(UnauthorizedAccessException) { }
            catch (Exception) { }
        }

        public void FindSync()
        {
            Find(_startDirectory);
        }

        public Task FindAsync()
        {
            return Task.Run(() => Find(_startDirectory));
        }
    }
}
