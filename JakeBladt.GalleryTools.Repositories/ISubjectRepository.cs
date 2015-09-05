using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakeBladt.GalleryTools.Repositories
{
    public interface ISubjectRepository
    {
        int SubjectCount { get; }
    }
}
