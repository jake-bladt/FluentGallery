using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using JakeBladt.GalleryTools.DAC;

namespace gallerysite.api.Controllers
{
    public class GalleryApiController : ApiController
    {
        protected DbManager DatabaseManager { get; set; }

        public GalleryApiController() : base()
        {
            var cnStr = ConfigurationManager.ConnectionStrings["galleryDb"].ConnectionString;
            DatabaseManager = new DbManager(cnStr);
        }
    }
}
