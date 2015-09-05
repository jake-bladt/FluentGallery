using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallerysite.api.ViewModels
{
    public class MigrationStatusViewModel
    {
        public int SubjectsInDatabase { get; set; }
        public int SubjectsInFileSystem { get; set; }
    }
}
