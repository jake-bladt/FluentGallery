using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using NHibernate.Linq;

using JakeBladt.GalleryTools.Repositories;

using gallerysite.api.ViewModels;

namespace gallerysite.api.Controllers
{
    public class MigrateController : GalleryApiController
    {
        public MigrationStatusViewModel Get()
        {
            var cnStr = ConfigurationManager.ConnectionStrings["galleryDb"].ConnectionString;
            var dbRepo = new DbSubjectRepository(cnStr);

            var rootDir = ConfigurationManager.AppSettings["subjectDirectoryRoot"];
            var fsRepo = new FsSubjectRepository(rootDir);

            return new MigrationStatusViewModel
            {
                SubjectsInDatabase = dbRepo.SubjectCount,
                SubjectsInFileSystem = fsRepo.SubjectCount
            };
        }
    }
}
