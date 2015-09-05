using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakeBladt.GalleryTools.Repositories
{
    public class FsRepositoryBase
    {
        public DirectoryInfo RootDirectory { get; protected set; }

        public FsRepositoryBase(string rootPath)
        {
            RootDirectory = new DirectoryInfo(rootPath);
        }
    }
}
