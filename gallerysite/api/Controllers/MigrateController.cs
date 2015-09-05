using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using gallerysite.api.ViewModels;

namespace gallerysite.api.Controllers
{
    public class MigrateController : ApiController
    {
        public MigrationStatusViewModel Get()
        {
            return new MigrationStatusViewModel();
        }
    }
}
