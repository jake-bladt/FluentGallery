using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using NHibernate.Linq;

using JakeBladt.GalleryTools.DAC;

using gallerysite.api.ViewModels;

namespace gallerysite.api.Controllers
{
    public class MigrateController : GalleryApiController
    {
        public MigrationStatusViewModel Get()
        {
            int dbCount = -1;
            int fsCount = -1;

            using (var session = DatabaseManager.CreateSessionFactory().OpenSession())
            {
                dbCount = session.QueryOver<Subject>().RowCount();
            }

            return new MigrationStatusViewModel
            {
                SubjectsInDatabase = dbCount,
                SubjectsInFileSystem = fsCount
            };
        }
    }
}
