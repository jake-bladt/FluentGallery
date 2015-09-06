using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JakeBladt.GalleryTools.DAC;
using JakeBladt.GalleryTools.Repositories;

namespace JakeBladt.GalleryTools.Migration
{
    public class SubjectMigration
    {
        protected FsSubjectRepository _FileSystemRepo;
        protected DbSubjectRepository _DatabaseRepo;

        public SubjectMigration(FsSubjectRepository fs, DbSubjectRepository db)
        {
            _FileSystemRepo = fs;
            _DatabaseRepo = db;
        }

        public int MigrateFilesToDatabase()
        {
            var missing = _FileSystemRepo.Subjects.Where(s => !_DatabaseRepo.Subjects.Any(s1 => s1.FilePrefix == s.FilePrefix));
            return _DatabaseRepo.AddAll(missing);
        }

    }
}
