using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JakeBladt.GalleryTools.DAC;

namespace JakeBladt.GalleryTools.Repositories
{
    public class DbRepositoryBase
    {
        public DbManager DatabaseManager { get; set; }

        public DbRepositoryBase(string cnStr)
        {
            DatabaseManager = new DbManager(cnStr);
        }

    }
}
