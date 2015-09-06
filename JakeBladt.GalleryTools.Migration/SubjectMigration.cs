using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JakeBladt.GalleryTools.Repositories;

namespace JakeBladt.GalleryTools.Migration
{
    public class SubjectMigration
    {
        protected FsSubjectRepository _FileSystemRepo;
        protected DbSubjectRepository _DatabaseRepo;

        public SubjectMigration(FsSubjectRepository fs, DbSubjectRepository db)
        {

        }
    }
}
